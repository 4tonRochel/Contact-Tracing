using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Contact_Tracing
{
    public partial class Form1 : Form
    {
        string my_answer;
        string[] my_arr = new string[4];
        

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            StreamWriter file = new StreamWriter(Application.StartupPath + "\\Data\\" + txtbxFName.Text + " " + txtbxLName.Text + ".txt");
            file.WriteLine(lblFN.Text + " " + txtbxFName.Text);
            file.WriteLine(lblLN.Text + " " + txtbxLName.Text);
            file.WriteLine(lblAge.Text + " " + txtbxAge.Text);
            file.WriteLine(lblAddress.Text + " " + txtbxADD.Text);
            file.WriteLine(lblPNum.Text + " " + txtbxPNum.Text);
            file.WriteLine(lblGender.Text + " " + cbxGender.Text);
            file.WriteLine(gbxQ1.Text + " " + my_answer);


            int i = 0;
            file.WriteLine("Experiencing:");
            for(i=0; i<4; i++)
            {
                if (my_arr[i] != "")
                {
                    file.WriteLine("" + my_arr[i]);
                }
                    

            }
            file.Close();

           
        }

        private void radioYes_CheckedChanged(object sender, EventArgs e)
        {
            if (radioYes.Checked == true)
            {
                my_answer = "<Yes>";
            }
        }

        private void radioNo_CheckedChanged(object sender, EventArgs e)
        {
            if (radioNo.Checked == true)
            {
                my_answer = "<No>";
            }
        }

        private void checkbxCough_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbxCough.Checked == true)
            {
                my_arr[0] = "New and persistent cough";
            }
            else
            {
                my_arr[0] = "";
            }
        }

        private void checkbxBreathing_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbxBreathing.Checked == true)
            {
                my_arr[1] = "Shortness of breath or any difficulty breathing";
            }
            else
            {
                my_arr[1] = "";
            }
        }

        private void checkbxFever_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbxFever.Checked == true)
            {
                my_arr[2] = "Fever";
            }
            else
            {
                my_arr[2] = "";
            }
        }

        private void checkbxNoSymptoms_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbxNoSymptoms.Checked == true)
            {
                my_arr[3] = "No Symptoms";
            }
            else
            {
                my_arr[3] = "";
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
