namespace SysClock
{
    partial class frm_Sysclock
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
            this.components = new System.ComponentModel.Container();
            this.cms_RightClick = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tmr_ResetForm = new System.Windows.Forms.Timer(this.components);
            this.tmr_UpdateTime = new System.Windows.Forms.Timer(this.components);
            this.cms_RightClick.SuspendLayout();
            this.SuspendLayout();
            // 
            // cms_RightClick
            // 
            this.cms_RightClick.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.cms_RightClick.Name = "cms_RightClick";
            this.cms_RightClick.Size = new System.Drawing.Size(93, 26);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // tmr_ResetForm
            // 
            this.tmr_ResetForm.Enabled = true;
            this.tmr_ResetForm.Interval = 1000;
            this.tmr_ResetForm.Tick += new System.EventHandler(this.tmr_ResetForm_Tick);
            // 
            // tmr_UpdateTime
            // 
            this.tmr_UpdateTime.Enabled = true;
            this.tmr_UpdateTime.Interval = 1000;
            this.tmr_UpdateTime.Tick += new System.EventHandler(this.tmr_UpdateTime_Tick);
            // 
            // frm_Sysclock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "frm_Sysclock";
            this.Text = "Form1";
            this.cms_RightClick.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip cms_RightClick;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Timer tmr_ResetForm;
        private System.Windows.Forms.Timer tmr_UpdateTime;

    }
}

