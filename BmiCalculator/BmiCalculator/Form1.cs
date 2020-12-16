using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace BmiCalculator
{
    public partial class Form1 : Form
    {
        BindingList<Measurement> measurements = new BindingList<Measurement>();
        public decimal bmi;
        public Form1()
        {

            InitializeComponent();
            weightDataGridView.DataSource = measurements;

            reaction9.BackColor = Color.Gray;
            reaction19.BackColor = Color.Gray;
            reaction4.BackColor = Color.Gray;
            reaction7.BackColor = Color.Gray;
            reaction12.BackColor = Color.Gray;
            reaction17.BackColor = Color.Gray;
            reaction22.BackColor = Color.Gray;

        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.InitialDirectory = Application.StartupPath;
            ofd.Filter = "Comma Seperated Values (*.csv)|*.csv";
            ofd.DefaultExt = "csv";
            ofd.AddExtension = true;

            if (ofd.ShowDialog() != DialogResult.OK) return;

            using (StreamReader sr = new StreamReader(ofd.FileName, Encoding.Default))
            {
                sr.ReadLine();

                while (!sr.EndOfStream)
                {
                    string[] sor = sr.ReadLine().Split(';');

                    Measurement m = new Measurement();
                    m.MeasurDate = Convert.ToDateTime(sor[0]);
                    m.Weight = decimal.Parse(sor[1]);
                    m.Height = decimal.Parse(sor[2]);

                    measurements.Add(m);
                }

                
            }
            LoadChart();
            textBoxWeight.Text = measurements[measurements.Count - 1].Weight.ToString();
            textBoxHeight.Text = measurements[measurements.Count - 1].Height.ToString();
            CalculateBmi();
        }

        private void LoadChart()
        {
            chartMeasurments.DataSource = measurements;

            var series = chartMeasurments.Series[0];
            series.ChartType = SeriesChartType.Line;
            series.XValueMember = "MeasurDate";
            series.XValueType = ChartValueType.Date;
            series.YValueMembers = "Weight";
            series.BorderWidth = 2;

            var legend = chartMeasurments.Legends[0];
            legend.Enabled = false;

            var chartArea = chartMeasurments.ChartAreas[0];
            chartArea.AxisX.MajorGrid.Enabled = false;
            chartArea.AxisY.MajorGrid.Enabled = false;
            chartArea.AxisY.IsStartedFromZero = false;
        }

        private void CalculateBmi()
        {
            if (textBoxWeight.Text != "" & textBoxHeight.Text != "")
            {
                bmi = decimal.Parse(textBoxWeight.Text) / ((decimal.Parse(textBoxHeight.Text) / 100) * (decimal.Parse(textBoxHeight.Text) / 100));
                labelBmiValue.Text = Math.Round(bmi, 2).ToString();
            }

            ShowReaction();
        }

        private void ShowReaction()
        {
            if (bmi < decimal.Parse("18,5") | bmi > decimal.Parse("25"))
            {
                reaction9.BackColor = Color.Red;
                reaction19.BackColor = Color.Red;
                reaction7.BackColor = Color.Red;
                reaction12.BackColor = Color.Red;
                reaction17.BackColor = Color.Red;
                
                reaction5.BackColor = Color.Red;
                reaction21.BackColor = Color.Red;

                reaction4.BackColor = Color.White;
                reaction22.BackColor = Color.White;

                reaction3.BackColor = Color.White;
                reaction23.BackColor = Color.White;
            }
            else
            {
                reaction9.BackColor = Color.Green;
                reaction19.BackColor = Color.Green;
                reaction7.BackColor = Color.Green;
                reaction12.BackColor = Color.Green;
                reaction17.BackColor = Color.Green;

                reaction5.BackColor = Color.White;
                reaction21.BackColor = Color.White;

                reaction4.BackColor = Color.White;
                reaction22.BackColor = Color.White;

                reaction3.BackColor = Color.Green;
                reaction23.BackColor = Color.Green;
            }
        }

        private void buttonAddAndSave_Click(object sender, EventArgs e)
        {
            Measurement lm = new Measurement();
            lm.MeasurDate = Convert.ToDateTime(DateTime.Now);
            lm.Weight = decimal.Parse(textBoxWeight.Text);
            lm.Height = decimal.Parse(textBoxHeight.Text);
            measurements.Add(lm);

            SaveFileDialog sfd = new SaveFileDialog();

            sfd.InitialDirectory = Application.StartupPath; 
            sfd.Filter = "Comma Seperated Values (*.csv)|*.csv"; 
            sfd.DefaultExt = "csv";
            sfd.AddExtension = true;

             if (sfd.ShowDialog() != DialogResult.OK) return;

            using (StreamWriter sw = new StreamWriter(sfd.FileName, false, Encoding.UTF8))
            {
                sw.Write("Dátum;Súly;Magasság");
                sw.WriteLine();

                foreach (var m in measurements)
                {
                    sw.Write(m.MeasurDate.ToString());
                    sw.Write(";");
                    sw.Write(m.Weight.ToString());
                    sw.Write(";");
                    sw.Write(m.Height.ToString());
                    sw.Write(";");
                    sw.WriteLine(); // Ez a sor az alábbi módon is írható: sr.Write("\n");
                }
            }
        }

        private void textBoxWeight_TextChanged(object sender, EventArgs e)
        {
            CalculateBmi();
        }

        private void textBoxHeight_TextChanged(object sender, EventArgs e)
        {
            CalculateBmi();
        }
    }
}
