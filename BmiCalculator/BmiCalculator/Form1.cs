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

namespace BmiCalculator
{
    public partial class Form1 : Form
    {
        BindingList<Measurement> measurements = new BindingList<Measurement>();
        public Form1()
        {

            InitializeComponent();

            weightDataGridView.DataSource = measurements;
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

                    measurements.Add(m);
                }
            }
        }
    
    }
}
