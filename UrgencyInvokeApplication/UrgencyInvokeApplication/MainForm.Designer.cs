namespace UrgencyInvokeApplication
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this._fileMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this._fileCreateFileMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this._fileOpenMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this._fileSaveMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this._fileExitMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this._editMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this._settingMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.90839F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.0916F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(37, 47);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(655, 436);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this._fileMenuStrip, this._editMenuStrip, this._settingMenuStrip});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(823, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // _fileMenuStrip
            // 
            this._fileMenuStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this._fileCreateFileMenuStrip, this._fileOpenMenuStrip, this._fileSaveMenuStrip, this._fileExitMenuStrip});
            this._fileMenuStrip.Name = "_fileMenuStrip";
            this._fileMenuStrip.Size = new System.Drawing.Size(53, 20);
            this._fileMenuStrip.Text = "ファイル";
            // 
            // _fileCreateFileMenuStrip
            // 
            this._fileCreateFileMenuStrip.Name = "_fileCreateFileMenuStrip";
            this._fileCreateFileMenuStrip.Size = new System.Drawing.Size(122, 22);
            this._fileCreateFileMenuStrip.Text = "新規作成";
            // 
            // _fileOpenMenuStrip
            // 
            this._fileOpenMenuStrip.Name = "_fileOpenMenuStrip";
            this._fileOpenMenuStrip.Size = new System.Drawing.Size(122, 22);
            this._fileOpenMenuStrip.Text = "開く";
            // 
            // _fileSaveMenuStrip
            // 
            this._fileSaveMenuStrip.Name = "_fileSaveMenuStrip";
            this._fileSaveMenuStrip.Size = new System.Drawing.Size(122, 22);
            this._fileSaveMenuStrip.Text = "保存";
            // 
            // _fileExitMenuStrip
            // 
            this._fileExitMenuStrip.Name = "_fileExitMenuStrip";
            this._fileExitMenuStrip.Size = new System.Drawing.Size(122, 22);
            this._fileExitMenuStrip.Text = "終了";
            // 
            // _editMenuStrip
            // 
            this._editMenuStrip.Name = "_editMenuStrip";
            this._editMenuStrip.Size = new System.Drawing.Size(43, 20);
            this._editMenuStrip.Text = "編集";
            // 
            // _settingMenuStrip
            // 
            this._settingMenuStrip.Name = "_settingMenuStrip";
            this._settingMenuStrip.Size = new System.Drawing.Size(43, 20);
            this._settingMenuStrip.Text = "設定";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 552);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "UrgencyInvokeApp";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem _fileMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem _editMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem _settingMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem _fileCreateFileMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem _fileOpenMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem _fileSaveMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem _fileExitMenuStrip;

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

        #endregion
    }
}