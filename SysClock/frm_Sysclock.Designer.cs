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
            this.conbtn_Switcher = new System.Windows.Forms.ToolStripMenuItem();
            this.conbtn_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.tmr_ResetForm = new System.Windows.Forms.Timer(this.components);
            this.tmr_UpdateTime = new System.Windows.Forms.Timer(this.components);
            this.cms_RightClick.SuspendLayout();
            this.SuspendLayout();
            // 
            // cms_RightClick
            // 
            this.cms_RightClick.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.conbtn_Switcher,
            this.conbtn_Exit});
            this.cms_RightClick.Name = "cms_RightClick";
            this.cms_RightClick.Size = new System.Drawing.Size(216, 48);
            // 
            // conbtn_Switcher
            // 
            this.conbtn_Switcher.Name = "conbtn_Switcher";
            this.conbtn_Switcher.Size = new System.Drawing.Size(215, 22);
            this.conbtn_Switcher.Text = "Always Bottom Right: True";
            this.conbtn_Switcher.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // conbtn_Exit
            // 
            this.conbtn_Exit.Name = "conbtn_Exit";
            this.conbtn_Exit.Size = new System.Drawing.Size(215, 22);
            this.conbtn_Exit.Text = "E&xit";
            this.conbtn_Exit.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // tmr_ResetForm
            // 
            this.tmr_ResetForm.Interval = 1;
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
            this.ClientSize = new System.Drawing.Size(127, 25);
            this.ControlBox = false;
            this.Name = "frm_Sysclock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frm_Sysclock_MouseDown);
            this.cms_RightClick.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip cms_RightClick;
        private System.Windows.Forms.ToolStripMenuItem conbtn_Exit;
        private System.Windows.Forms.Timer tmr_ResetForm;
        private System.Windows.Forms.Timer tmr_UpdateTime;
        private System.Windows.Forms.ToolStripMenuItem conbtn_Switcher;

    }
}

