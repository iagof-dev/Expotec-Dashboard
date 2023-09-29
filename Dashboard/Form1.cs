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
using LiveCharts.Helpers;
using LiveCharts.Wpf;
using LiveCharts;
using System.Reflection;
using Dashboard.paginas;

namespace Dashboard
{
    public partial class Form1 : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
         (
              int nLeftRect,
              int nTopRect,
              int nRightRect,
              int nBottomRect,
              int nWidthEllipse,
             int nHeightEllipse

          );

        public void CHANGE_FORM(Form pagina)
        {
            panel_forms.Controls.Clear();
            pagina.TopLevel = false;
            panel_forms.Controls.Add(pagina);   
            pagina.Dock = DockStyle.Fill;
            pagina.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            pagina.Show();
        }

        public Form1()
        {
            InitializeComponent();
            //Estilização
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = btnDashboard.Height;
            pnlNav.Top = btnDashboard.Top;
            pnlNav.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromArgb(46, 51, 73);
            // -- --
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            CHANGE_FORM(new inicio());
        }

        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnDashboard.Height;    
            pnlNav.Top  = btnDashboard.Top;
            pnlNav.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromArgb(46, 51, 73);
            CHANGE_FORM(new inicio());


        }

        private void btnAnalytics_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnAnalytics.Height;
            pnlNav.Top = btnAnalytics.Top;
            pnlNav.Left = btnAnalytics.Left;
            btnAnalytics.BackColor = Color.FromArgb(46, 51, 73);
            CHANGE_FORM(new estatisticas());
        }

        private void btnCalender_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnCalender.Height;
            pnlNav.Top = btnCalender.Top;
            pnlNav.Left = btnCalender.Left;
            btnCalender.BackColor = Color.FromArgb(46, 51, 73);
            CHANGE_FORM(new vendas());
        }



        private void btnDashBoard_Leave(object sender, EventArgs e)
        {
            btnDashboard.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnAnalytics_Leave(object sender, EventArgs e)
        {
            btnAnalytics.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnCalender_Leave(object sender, EventArgs e)
        {
            btnCalender.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnSettings_Leave(object sender, EventArgs e)
        {
            btnSettings.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_forms_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
