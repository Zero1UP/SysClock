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
using System.Drawing;
namespace SysClock
{
    public partial class frm_Sysclock : Form
    {
        // Windows API calls
        //public const int WM_NCLBUTTONDOWN = 0xA1;
        //public const int HT_CAPTION = 0x2;
        //[DllImportAttribute("user32.dll")]
        //public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        //[DllImportAttribute("user32.dll")]
        //public static extern bool ReleaseCapture();

        public frm_Sysclock()
        {
            InitializeComponent();

            //Set the form so it is topmost
            this.TopMost = true;

            //Set some form properties so it doesn't look like a form
            this.ControlBox = false;
            this.Text = "";
            this.FormBorderStyle = FormBorderStyle.None;

            //Set the form size
            this.Width = 75;
            this.Height = 60;

            //Set the form color
            this.BackColor = Color.CadetBlue;
            this.Font = new Font(this.Font, FontStyle.Bold);



            //Set the form to the bottom right of the screen
            Rectangle workingArea = Screen.GetWorkingArea(this);
            this.Location = new Point(workingArea.Right - Size.Width, workingArea.Bottom - Size.Height);

            //Add Labels
            CreateLabels();

            //Add contextMenuStrip
            this.ContextMenuStrip = cms_RightClick;
        }

       
       //Un-used code at the time being. This would be used to allow the use to drag the window by clicking anywhere on the form 
        //private void frm_Sysclock_MouseDown(object sender, MouseEventArgs e)
        //{
        //    ReleaseCapture();
        //    SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0); 
        //}


        private void CreateLabels()
        {

            //Create Label objects
            Label dayLabel = new Label
            {
                Name = "lbl_dayLabel",
                BackColor = Color.Transparent,
                ForeColor = Color.White,
                Location = new Point(30,0),
                Text = DateTime.Now.DayOfWeek.ToString(),
                Font = new Font(this.Font.FontFamily, 10)
            };


            Label timeLabel = new Label
            {
                Name = "lbl_timeLabel",
                BackColor = Color.Transparent,
                ForeColor = Color.White,
                Location = new Point(30, 20),
                Text =DateTime.Now.ToString("hh:mm:ss tt"),
                Font = new Font(this.Font.FontFamily, 10)
            };

            Label  dateLabel = new Label
            {
                Name = "lbl_dateLabel",
                BackColor = Color.Transparent,
                ForeColor = Color.White,
                Location = new Point(30, 40),
                Text =DateTime.Now.ToString(),
                Font = new Font(this.Font.FontFamily, 10)
            };

            //Add Labels to the form
            this.Controls.Add(dayLabel);
            this.Controls.Add(timeLabel);
            this.Controls.Add(dateLabel);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tmr_ResetForm_Tick(object sender, EventArgs e)
        {
            Rectangle workingArea = Screen.GetWorkingArea(this);
            this.Location = new Point(workingArea.Right - Size.Width, workingArea.Bottom - Size.Height);
        }

        private void tmr_UpdateTime_Tick(object sender, EventArgs e)
        {
           foreach (Control Label in this.Controls)
           {
               if (Label.Name == "lbl_timeLabel")
                   Label.Text = DateTime.Now.ToString("hh:mm:ss tt");

           }
        }


    }
}
