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

namespace ContactTracingApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            StreamWriter outputFile;
            outputFile = File.CreateText("Output.txt");
            outputFile.WriteLine(lbl_lastName.Text + " " + txtBox_lastName.Text);
            outputFile.WriteLine(lbl_firstName.Text + " " + txtBox_firstName.Text);
            outputFile.WriteLine(lbl_middleName.Text + " " + txtBox_middleName.Text);
            outputFile.WriteLine(lbl_age.Text + " " + txtBox_age.Text);
            outputFile.WriteLine(lbl_gender.Text + " " + comboBox_gender.Text);
            outputFile.WriteLine(lbl_date.Text + " " + txtBox_date.Text);
            outputFile.WriteLine(lbl_contactNum.Text + " " + txtBox_contactNum.Text);
            outputFile.WriteLine(lbl_address.Text + " " + txtBox_address.Text);
            outputFile.WriteLine(lbl_emailAdd.Text + " " + txtBox_emailAdd.Text);
            outputFile.WriteLine("==========================================");
            outputFile.WriteLine(lbl_Question.Text);
            outputFile.WriteLine(lbl_dryCough.Text + " " + comboBox_YN1.Text);
            outputFile.WriteLine(lbl_shortBreath.Text + " " + comboBox_YN2.Text);
            outputFile.WriteLine(lbl_fatigue.Text + " " + comboBox_YN3.Text);
            outputFile.WriteLine(lbl_headache.Text + " " + comboBox_YN4.Text);
            outputFile.WriteLine(lbl_loss.Text + " " + comboBox_YN5.Text);
            outputFile.WriteLine(lbl_musclePain.Text + " " + comboBox_YN6.Text);
            outputFile.Close();

            StreamReader inputFile;
            inputFile = File.OpenText("Output.txt");
            rtb_ReadFiles.Text = inputFile.ReadToEnd();
            inputFile.Close();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
