using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApplication6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }

            for (int i = 0; i < 30; i++)
            {
                float a = Program.l1.ElementAt(i).getb();
                chart1.Series["method1"].Points.AddXY(i + 1, a);
                float b = Program.l2.ElementAt(i).getb();
                chart1.Series["method2"].Points.AddXY(i + 1, b);
            }

            chart1.Series["method1"].ChartType = SeriesChartType.FastLine;
            chart1.Series["method1"].Color = Color.Red;

            chart1.Series["method2"].ChartType = SeriesChartType.FastLine;
            chart1.Series["method2"].Color = Color.Blue;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }
            for (int i = 0; i < 30; i++)
            {
                float a = Program.l1.ElementAt(i).getc();
                chart1.Series["method1"].Points.AddXY(i + 1, a);
                float b = Program.l2.ElementAt(i).getc();
                chart1.Series["method2"].Points.AddXY(i+1, b);
            }

            chart1.Series["method1"].ChartType = SeriesChartType.FastLine;
            chart1.Series["method1"].Color = Color.Red;

            chart1.Series["method2"].ChartType = SeriesChartType.FastLine;
            chart1.Series["method2"].Color = Color.Blue;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }
            for (int i = 0; i < 30; i++)
            {
                float a = Program.l1.ElementAt(i).getd();
                chart1.Series["method1"].Points.AddXY(i + 1, a);
                float b = Program.l2.ElementAt(i).getd();
                chart1.Series["method2"].Points.AddXY(i + 1, b);
            }

            chart1.Series["method1"].ChartType = SeriesChartType.FastLine;
            chart1.Series["method1"].Color = Color.Red;

            chart1.Series["method2"].ChartType = SeriesChartType.FastLine;
            chart1.Series["method2"].Color = Color.Blue;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }
            for (int i = 0; i < 30; i++)
            {
                float a = Program.l1.ElementAt(i).gete();
                chart1.Series["method1"].Points.AddXY(i + 1, a);
                float b = Program.l2.ElementAt(i).gete();
                chart1.Series["method2"].Points.AddXY(i + 1, b);
            }

            chart1.Series["method1"].ChartType = SeriesChartType.FastLine;
            chart1.Series["method1"].Color = Color.Red;

            chart1.Series["method2"].ChartType = SeriesChartType.FastLine;
            chart1.Series["method2"].Color = Color.Blue;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }
            for (int i = 0; i < 30; i++)
            {
                float a = Program.l1.ElementAt(i).getf();
                chart1.Series["method1"].Points.AddXY(i + 1, a);
                float b = Program.l2.ElementAt(i).getf();
                chart1.Series["method2"].Points.AddXY(i + 1, b);
            }

            chart1.Series["method1"].ChartType = SeriesChartType.FastLine;
            chart1.Series["method1"].Color = Color.Red;

            chart1.Series["method2"].ChartType = SeriesChartType.FastLine;
            chart1.Series["method2"].Color = Color.Blue;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }
            for (int i = 0; i < 30; i++)
            {
                float a = Program.l1.ElementAt(i).getg();
                chart1.Series["method1"].Points.AddXY(i + 1, a);
                float b = Program.l2.ElementAt(i).getg();
                chart1.Series["method2"].Points.AddXY(i + 1, b);
            }

            chart1.Series["method1"].ChartType = SeriesChartType.FastLine;
            chart1.Series["method1"].Color = Color.Red;

            chart1.Series["method2"].ChartType = SeriesChartType.FastLine;
            chart1.Series["method2"].Color = Color.Blue;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }
            for (int i = 0; i < 30; i++)
            {
                float a = Program.l1.ElementAt(i).geth();
                chart1.Series["method1"].Points.AddXY(i + 1, a);
                float b = Program.l2.ElementAt(i).geth();
                chart1.Series["method2"].Points.AddXY(i + 1, b);
            }

            chart1.Series["method1"].ChartType = SeriesChartType.FastLine;
            chart1.Series["method1"].Color = Color.Red;

            chart1.Series["method2"].ChartType = SeriesChartType.FastLine;
            chart1.Series["method2"].Color = Color.Blue;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }
            for (int i = 0; i < 30; i++)
            {
                float a = Program.l1.ElementAt(i).geti();
                chart1.Series["method1"].Points.AddXY(i+1, a);
                float b = Program.l2.ElementAt(i).geti();
                chart1.Series["method2"].Points.AddXY(i+1, b);
            }

            chart1.Series["method1"].ChartType = SeriesChartType.FastLine;
            chart1.Series["method1"].Color = Color.Red;

            chart1.Series["method2"].ChartType = SeriesChartType.FastLine;
            chart1.Series["method2"].Color = Color.Blue;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }
            for (int i = 0; i < 30; i++)
            {
                float a = Program.l1.ElementAt(i).getj();
                chart1.Series["method1"].Points.AddXY(i + 1, a);
                float b = Program.l2.ElementAt(i).getj();
                chart1.Series["method2"].Points.AddXY(i + 1, b);
            }

            chart1.Series["method1"].ChartType = SeriesChartType.FastLine;
            chart1.Series["method1"].Color = Color.Red;

            chart1.Series["method2"].ChartType = SeriesChartType.FastLine;
            chart1.Series["method2"].Color = Color.Blue;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }
            for (int i = 0; i < 30; i++)
            {
                float a = Program.l1.ElementAt(i).getk();
                chart1.Series["method1"].Points.AddXY(i + 1, a);
                float b = Program.l2.ElementAt(i).getk();
                chart1.Series["method2"].Points.AddXY(i + 1, b);
            }

            chart1.Series["method1"].ChartType = SeriesChartType.FastLine;
            chart1.Series["method1"].Color = Color.Red;

            chart1.Series["method2"].ChartType = SeriesChartType.FastLine;
            chart1.Series["method2"].Color = Color.Blue;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }
            for (int i = 0; i < 30; i++)
            {
                float a = Program.l1.ElementAt(i).getl();
                chart1.Series["method1"].Points.AddXY(i + 1, a);
                float b = Program.l2.ElementAt(i).getl();
                chart1.Series["method2"].Points.AddXY(i + 1, b);
            }

            chart1.Series["method1"].ChartType = SeriesChartType.FastLine;
            chart1.Series["method1"].Color = Color.Red;

            chart1.Series["method2"].ChartType = SeriesChartType.FastLine;
            chart1.Series["method2"].Color = Color.Blue;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }
            for (int i = 0; i < 30; i++)
            {
                float a = Program.l1.ElementAt(i).getm();
                chart1.Series["method1"].Points.AddXY(i + 1, a);
                float b = Program.l2.ElementAt(i).getm();
                chart1.Series["method2"].Points.AddXY(i + 1, b);
            }

            chart1.Series["method1"].ChartType = SeriesChartType.FastLine;
            chart1.Series["method1"].Color = Color.Red;

            chart1.Series["method2"].ChartType = SeriesChartType.FastLine;
            chart1.Series["method2"].Color = Color.Blue;
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
