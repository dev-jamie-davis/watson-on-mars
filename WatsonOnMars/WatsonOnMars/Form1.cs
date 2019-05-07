using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WatsonOnMars
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }    

        private void button1_Click(object sender, EventArgs e)
        {
            calcButton.Visible = false;
            massBox.Visible = false;
            radiusBox.Visible = false;
            massLabel.Visible = false;
            radiusLabel.Visible = false;
            resetButton.Visible = true;
            


            double gravConstant = 0.0000000000667408;
            // 6.67408 × 10^11 m^3 kg^-1 s^-2
            double earthAcceleration = 9.807;
            // 9.807 m/s^2
            double watson = 4.4225; // 9.75 lbs converted to kg
            double watsonWithEVA = watson + 8.44; // Add his EVA suit
            double mass = double.Parse(massBox.Text);
            double radius = double.Parse(radiusBox.Text);
            radius *= radius;
            double num = gravConstant * mass;
            double result = num / radius;
            
            double diff = result / earthAcceleration;
            
            double watsonNewWeight = (watson * diff) * 2.205;
            watsonNewWeight = Math.Round(watsonNewWeight, 3);
            double watsonNewEVA = (watsonWithEVA * diff) * 2.205;
            watsonNewEVA = Math.Round(watsonNewEVA, 3);
            watsonWeightOutput.Text = "Watson's Weight: " + watsonNewWeight.ToString() + " lbs.";
            watsonWeightOutput.Visible = true;
            watsonEVAoutput.Text = "w/ EVA suit: " + watsonNewEVA.ToString() + " lbs.";
            watsonEVAoutput.Visible = true;
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            watsonWeightOutput.Visible = false;
            watsonEVAoutput.Visible = false;
            calcButton.Visible = true;
            massBox.Visible = true;
            radiusBox.Visible = true;
            massLabel.Visible = true;
            radiusLabel.Visible = true;
            resetButton.Visible = false;
            

        }
    }
}
