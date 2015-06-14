using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Configuration;

namespace SysClock
{
    public partial class frm_Sysclock : Form
    {

        //Windows API Calls
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();


        public frm_Sysclock()
        {


            InitializeComponent();

            //Set some form properties so it doesn't look like a form
            this.ControlBox = false;
            this.Text = "";
            this.FormBorderStyle = FormBorderStyle.None;

            //Set the size of the form
            this.MaximumSize = new Size(73, 30);

            //Set the form color
            this.BackColor = Color.CadetBlue;
            this.Font = new Font(this.Font, FontStyle.Bold);

            //Add Labels
            CreateLabels();

            //Add contextMenuStrip
            this.ContextMenuStrip = cms_RightClick;


            //Decide if we are loading the users desired location or defaulting to the lower right of the screen
            //The user is able to make this change on the right click menu. All they have to do is click the button and it will change accordingly. It will be bottom right by default
            if(Properties.Settings.Default.alwaysBottomRight)
            {
                tmr_ResetForm.Enabled = true;
                conbtn_Switcher.Text = "Always Bottom Right: True";
            }
            else
            {
                this.Location = new Point(Properties.Settings.Default.windowPos.X, Properties.Settings.Default.windowPos.Y);
                this.TopMost = true;
                conbtn_Switcher.Text = "Always Bottom Right: False";
            }

        }

        private void CreateLabels()
        {

            //Create Label objects
            Label dayLabel = new Label
            {
                Name = "lbl_dayLabel",
                BackColor = Color.Transparent,
                ForeColor = Color.White,
                Location = new Point(this.Size.Width -100,-5),
                Text = DateTime.Now.DayOfWeek.ToString().Substring(0,3) + " " +  DateTime.Now.ToString("M/d/yyyy"),
                Font = new Font(this.Font.FontFamily, 9),
                TextAlign = System.Drawing.ContentAlignment.MiddleRight
                                 
            };


            Label timeLabel = new Label
            {
                Name = "lbl_timeLabel",
                BackColor = Color.Transparent,
                ForeColor = Color.White,
                Location = new Point(this.Size.Width - 100, 10),
                Text =DateTime.Now.ToString("hh:mm:ss tt"),
                Font = new Font(this.Font.FontFamily, 9),
                TextAlign = System.Drawing.ContentAlignment.MiddleRight
            };


            //Add Labels to the form
            this.Controls.Add(dayLabel);
            this.Controls.Add(timeLabel);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tmr_ResetForm_Tick(object sender, EventArgs e)
        {
            Rectangle workingArea = Screen.GetBounds(this);
            this.Location = new Point(workingArea.Right - Size.Width, workingArea.Bottom - Size.Height);          
            this.TopMost = true;
        }

        private void tmr_UpdateTime_Tick(object sender, EventArgs e)
        {


           foreach (Control Label in this.Controls)
           {
               if (Label.Name == "lbl_dayLabel")
                   Label.Text = DateTime.Now.DayOfWeek.ToString().Substring(0, 3) + " " + DateTime.Now.ToString("M/d/yyyy"); 
         
               if (Label.Name == "lbl_timeLabel")            
                   Label.Text = DateTime.Now.ToString("hh:mm:ss tt");
           
           }            
        }

        private void frm_Sysclock_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            Properties.Settings.Default.windowPos = new Point(this.Location.X, this.Location.Y);
            Properties.Settings.Default.Save();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (conbtn_Switcher.Text == "Always Bottom Right: True")
            {
                conbtn_Switcher.Text = "Always Bottom Right: False";
                Properties.Settings.Default.alwaysBottomRight = false;
                Properties.Settings.Default.Save();
                tmr_ResetForm.Enabled = false;
           
            }
            else if (conbtn_Switcher.Text == "Always Bottom Right: False")
            {
                conbtn_Switcher.Text = "Always Bottom Right: True";
                Properties.Settings.Default.alwaysBottomRight = true;
                Properties.Settings.Default.Save();
                tmr_ResetForm.Enabled = true;

            }
        }

    }
}
