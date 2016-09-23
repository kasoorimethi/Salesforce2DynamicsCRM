using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salesforce2DynamicsCRM
{
    public partial class ProgressForm : Form
    {
        private Action<ProgressForm> action;


        public ProgressForm(Action<ProgressForm> action)
        {
            InitializeComponent();
            this.action = action;
        }

        private void ProgressForm_Shown(object sender, EventArgs e)
        {
            var errorOccurred = true;

            Task.Factory.StartNew(() =>
            {
                try
                {
                    action(this);
                    errorOccurred = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            })
            .ContinueWith(task =>
            {
                Invoke(new Action(() =>
                {
                    if (errorOccurred)
                    {
                        Close(); 
                    }
                    else
                    {
                        this.btOk.Enabled = true;
                    }
                }));
            });
        }


        public void AppendText(string s)
        {
            Invoke(new Action(() => { this.tbMessage.Text += s + Environment.NewLine; }));
        }
    }
}
