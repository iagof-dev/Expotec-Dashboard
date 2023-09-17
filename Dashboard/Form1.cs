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


        public Form1()
        {
            InitializeComponent();
            //Estilização
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = btnDashBoard.Height;
            pnlNav.Top = btnDashBoard.Top;
            pnlNav.Left = btnDashBoard.Left;
            btnDashBoard.BackColor = Color.FromArgb(46, 51, 73);
            // -- --
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            revenueBindingSource.DataSource = new List<Revenue>();
            cartesianChart1.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Month",
                Labels = new[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" }
            });
            cartesianChart1.AxisY.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Reveneu",
                LabelFormatter = value => value.ToString("C")
            });

            cartesianChart1.LegendLocation = LiveCharts.LegendLocation.Right;
        }

        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnDashBoard.Height;    
            pnlNav.Top  = btnDashBoard.Top;
            pnlNav.Left = btnDashBoard.Left;
            btnDashBoard.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnAnalytics_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnAnalytics.Height;
            pnlNav.Top = btnAnalytics.Top;
            pnlNav.Left = btnAnalytics.Left;
            btnAnalytics.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnCalender_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnCalender.Height;
            pnlNav.Top = btnCalender.Top;
            pnlNav.Left = btnCalender.Left;
            btnCalender.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnContactUs_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnContactUs.Height;
            pnlNav.Top = btnContactUs.Top;
            pnlNav.Left = btnContactUs.Left;
            btnContactUs.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnDashBoard_Leave(object sender, EventArgs e)
        {
            btnDashBoard.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnAnalytics_Leave(object sender, EventArgs e)
        {
            btnAnalytics.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnCalender_Leave(object sender, EventArgs e)
        {
            btnCalender.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnContactUs_Leave(object sender, EventArgs e)
        {
            btnContactUs.BackColor = Color.FromArgb(24, 30, 54);
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
            //Init data

            cartesianChart1.Series.Clear();
            SeriesCollection series = new SeriesCollection();
            var years = (from o in revenueBindingSource.DataSource as List<Revenue>
                         select new { Year = o.Year }).Distinct();
            foreach (var year in years)
            {
                List<double> values = new List<double>();
                for (int month = 1; month <= 12; month++)
                {
                    double value = 0;
                    var data = from o in revenueBindingSource.DataSource as List<Revenue>
                               where o.Year.Equals(year.Year) && o.Month.Equals(month)
                               orderby o.Month ascending
                               select new { o.Value, o.Month };
                    if (data.SingleOrDefault() != null)
                        value = data.SingleOrDefault().Value;
                    values.Add(value);

                }

                series.Add(new LineSeries() { Title = year.Year.ToString(), Values = new ChartValues<double>(values) });

            }
            cartesianChart1.Series = series;
        }
    }
}
