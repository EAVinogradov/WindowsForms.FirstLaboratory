using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EAVinogradov.CSWindowsForms.FirstLaboratory.FifthExample
{
    public partial class SecondForm : Form
    {
        public SecondForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SecondForm_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath myPath = new System.Drawing.Drawing2D.GraphicsPath();
            myPath.AddLines(new Point[] { new Point(100, 0), new Point(200, 100), new Point(100, 200), new Point(0,100) });
            Region myRegion = new Region(myPath); 
            this.Region = myRegion;
        }
    }
}
