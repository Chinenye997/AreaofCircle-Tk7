using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApps_for_AreaofCircle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        //private void Form1_Load(object sender, EventArgs e)
        //{
            
        //}

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // ' Delcare veriables
            double radius, area;
            radius = Convert.ToDouble(TxtRadius.Text);

            area = Math.PI * radius * radius;


            IbIAnswer.Text = area.ToString();
            IbIAnswer.BackColor = Color.White;
           
        }

        private void btnShowFormula_Click(object sender, EventArgs e)
        {
          
            if (btnShowFormula.Text == "Show Formula")
            {
                btnShowFormula.Text = "Area = π * radius²";
            }
            else
            {
                btnShowFormula.Text = "Show Formula";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear the text in the radius input box
            TxtRadius.Clear();

            IbIAnswer.Text = string.Empty;

        }
    }
}
