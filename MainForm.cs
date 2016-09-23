using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Salesforce2DynamicsCRM
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.cbObject.DataSource = new string[] { "", "Account", /*"Lead", "Opportunity"*/ };
        }

        private void btLoad_Click(object sender, EventArgs e)
        {
            var tableName = this.cbObject.SelectedItem.ToString();

            if (tableName == "")
            {
                MessageBox.Show("インポート対象を選択してください。", "確認");
                return;
            }

            this.btLoad.Enabled = false;

            using (var progressForm = new ProgressForm(message =>
            {
                message.AppendText("データを読み込んでいます...");

                using (var salesforce = new DbWrapper(CDataFactory.Salesforce, Properties.Settings.Default.SalesforceConnectionString))
                using (var dynamicsCRM = new DbWrapper(CDataFactory.DynamicsCRM, Properties.Settings.Default.DynamicsCRMConnectionString))
                {
                    var salesforceDataTable = salesforce.CreateDataTable(tableName);
                    var dynamicsCRMDataTable = dynamicsCRM.CreateDataTable(tableName);

                    Invoke(new Action(() =>
                    {
                        this.dgvSource.DataSource = salesforceDataTable;
                        this.dgvDestination.DataSource = dynamicsCRMDataTable;

                        this.btImport.Enabled = true;
                    }));
                }

                message.AppendText("完了しました。");
            }))
            {
                progressForm.ShowDialog();
            }

            this.btLoad.Enabled = true;
        }

        private void btImport_Click(object sender, EventArgs e)
        {
            var importTargetRows = this.dgvSource.Rows.Cast<DataGridViewRow>()
                .Where(o => o.Selected)
                .Select(o => ((DataRowView)o.DataBoundItem).Row)
                .Where(o => !string.IsNullOrWhiteSpace(o["AccountNumber"].ToString()))
                .ToList();

            if (importTargetRows.Count == 0)
            {
                MessageBox.Show("インポート対象がありません。", "確認");
                return;
            }

            var destinationRowMap = this.dgvDestination.Rows.Cast<DataGridViewRow>()
                .Select(o => ((DataRowView)o.DataBoundItem).Row)
                .Where(o => !string.IsNullOrWhiteSpace(o["AccountNumber"].ToString()))
                .ToDictionary(o => o["AccountNumber"].ToString(), o => o);

            using (var progressForm = new ProgressForm(message =>
            {
                var importNew = 0;
                var importUpdate = 0;
                var tableName = ((DataTable)this.dgvSource.DataSource).TableName;

                message.AppendText("インポートしています...");

                foreach (var importTargetRow in importTargetRows)
                {
                    DataRow dataRow = null;

                    if (destinationRowMap.ContainsKey(importTargetRow["AccountNumber"].ToString()))
                    {
                        dataRow = destinationRowMap[importTargetRow["AccountNumber"].ToString()];
                        importUpdate++;
                    }
                    else
                    {
                        dataRow = ((DataTable)this.dgvDestination.DataSource).NewRow();
                        ((DataTable)this.dgvDestination.DataSource).Rows.Add(dataRow);
                        importNew++;
                    }

                    ColumnMapperRegistry.GetMapper(tableName).Map(importTargetRow, dataRow);
                }

                message.AppendText("インポート先のデータを再読み込みしています...");

                using (var dynamicsCRM = new DbWrapper(CDataFactory.DynamicsCRM, Properties.Settings.Default.DynamicsCRMConnectionString))
                {
                    dynamicsCRM.Update((DataTable)this.dgvDestination.DataSource);

                    Invoke(new Action(() =>
                    {
                        this.dgvDestination.DataSource = dynamicsCRM.CreateDataTable(tableName);
                    }));
                }

                message.AppendText("新規: " + importNew + " 件");
                message.AppendText("更新: " + importUpdate + " 件");
                message.AppendText("完了しました。");
            }))
            {
                progressForm.ShowDialog();
            }
        }
    }
}
