namespace Salesforce2DynamicsCRM
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.cbObject = new System.Windows.Forms.ComboBox();
            this.dgvSource = new System.Windows.Forms.DataGridView();
            this.btImport = new System.Windows.Forms.Button();
            this.btLoad = new System.Windows.Forms.Button();
            this.scMain = new System.Windows.Forms.SplitContainer();
            this.scRight = new System.Windows.Forms.SplitContainer();
            this.pbArrow = new System.Windows.Forms.PictureBox();
            this.dgvDestination = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).BeginInit();
            this.scMain.Panel1.SuspendLayout();
            this.scMain.Panel2.SuspendLayout();
            this.scMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scRight)).BeginInit();
            this.scRight.Panel1.SuspendLayout();
            this.scRight.Panel2.SuspendLayout();
            this.scRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbArrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDestination)).BeginInit();
            this.SuspendLayout();
            // 
            // cbObject
            // 
            this.cbObject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbObject.FormattingEnabled = true;
            this.cbObject.Location = new System.Drawing.Point(12, 12);
            this.cbObject.Name = "cbObject";
            this.cbObject.Size = new System.Drawing.Size(183, 20);
            this.cbObject.TabIndex = 0;
            // 
            // dgvSource
            // 
            this.dgvSource.AllowUserToAddRows = false;
            this.dgvSource.AllowUserToDeleteRows = false;
            this.dgvSource.AllowUserToResizeRows = false;
            this.dgvSource.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSource.Location = new System.Drawing.Point(0, 0);
            this.dgvSource.Name = "dgvSource";
            this.dgvSource.ReadOnly = true;
            this.dgvSource.RowTemplate.Height = 21;
            this.dgvSource.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSource.Size = new System.Drawing.Size(481, 428);
            this.dgvSource.TabIndex = 1;
            // 
            // btImport
            // 
            this.btImport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btImport.Enabled = false;
            this.btImport.Location = new System.Drawing.Point(7, 220);
            this.btImport.Name = "btImport";
            this.btImport.Size = new System.Drawing.Size(73, 27);
            this.btImport.TabIndex = 3;
            this.btImport.Text = "インポート";
            this.btImport.UseVisualStyleBackColor = true;
            this.btImport.Click += new System.EventHandler(this.btImport_Click);
            // 
            // btLoad
            // 
            this.btLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btLoad.Location = new System.Drawing.Point(213, 9);
            this.btLoad.Name = "btLoad";
            this.btLoad.Size = new System.Drawing.Size(75, 23);
            this.btLoad.TabIndex = 4;
            this.btLoad.Text = "選択";
            this.btLoad.UseVisualStyleBackColor = true;
            this.btLoad.Click += new System.EventHandler(this.btLoad_Click);
            // 
            // scMain
            // 
            this.scMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scMain.Location = new System.Drawing.Point(12, 71);
            this.scMain.Name = "scMain";
            // 
            // scMain.Panel1
            // 
            this.scMain.Panel1.Controls.Add(this.dgvSource);
            // 
            // scMain.Panel2
            // 
            this.scMain.Panel2.Controls.Add(this.scRight);
            this.scMain.Size = new System.Drawing.Size(1097, 428);
            this.scMain.SplitterDistance = 481;
            this.scMain.TabIndex = 5;
            // 
            // scRight
            // 
            this.scRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scRight.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.scRight.Location = new System.Drawing.Point(0, 0);
            this.scRight.Name = "scRight";
            // 
            // scRight.Panel1
            // 
            this.scRight.Panel1.Controls.Add(this.pbArrow);
            this.scRight.Panel1.Controls.Add(this.btImport);
            // 
            // scRight.Panel2
            // 
            this.scRight.Panel2.Controls.Add(this.dgvDestination);
            this.scRight.Size = new System.Drawing.Size(612, 428);
            this.scRight.SplitterDistance = 87;
            this.scRight.TabIndex = 0;
            // 
            // pbArrow
            // 
            this.pbArrow.Image = ((System.Drawing.Image)(resources.GetObject("pbArrow.Image")));
            this.pbArrow.Location = new System.Drawing.Point(16, 171);
            this.pbArrow.Name = "pbArrow";
            this.pbArrow.Size = new System.Drawing.Size(54, 33);
            this.pbArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbArrow.TabIndex = 4;
            this.pbArrow.TabStop = false;
            // 
            // dgvDestination
            // 
            this.dgvDestination.AllowUserToAddRows = false;
            this.dgvDestination.AllowUserToDeleteRows = false;
            this.dgvDestination.AllowUserToResizeRows = false;
            this.dgvDestination.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDestination.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDestination.Location = new System.Drawing.Point(0, 0);
            this.dgvDestination.Name = "dgvDestination";
            this.dgvDestination.ReadOnly = true;
            this.dgvDestination.RowTemplate.Height = 21;
            this.dgvDestination.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDestination.Size = new System.Drawing.Size(521, 428);
            this.dgvDestination.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 523);
            this.Controls.Add(this.scMain);
            this.Controls.Add(this.btLoad);
            this.Controls.Add(this.cbObject);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salesforce -> DynamicsCRM";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSource)).EndInit();
            this.scMain.Panel1.ResumeLayout(false);
            this.scMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).EndInit();
            this.scMain.ResumeLayout(false);
            this.scRight.Panel1.ResumeLayout(false);
            this.scRight.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scRight)).EndInit();
            this.scRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbArrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDestination)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbObject;
        private System.Windows.Forms.DataGridView dgvSource;
        private System.Windows.Forms.Button btImport;
        private System.Windows.Forms.Button btLoad;
        private System.Windows.Forms.SplitContainer scMain;
        private System.Windows.Forms.SplitContainer scRight;
        private System.Windows.Forms.DataGridView dgvDestination;
        private System.Windows.Forms.PictureBox pbArrow;
    }
}

