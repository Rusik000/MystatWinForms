using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyStatWinForms
{
    public partial class Students : UserControl
    {


        List<string> ScoreClassWork = new List<string>
        {
            "-","12","11","10","9","8","7","6","5","4","3","2","1","0"
        };

        List<string> ScoreInspection = new List<string>
        {
            "-","12","11","10","9","8","7","6","5","4","3","2","1","0"
        };


        public Students()
        {
            InitializeComponent();
            InspectionComboBx.DataSource = ScoreInspection;
            ClassWorkComboBx.DataSource = ScoreClassWork;
        }

        public Students(Student student)
        {
            InitializeComponent();
            InspectionComboBx.DataSource = ScoreInspection;
            ClassWorkComboBx.DataSource = ScoreClassWork;
            IDLbl.Text = student.ID.ToString();
            FullNamelbl.Text = student.getFullname();
            EntryLbl.Text = student.EntryTime.ToString("dd.MM.yyyy");
            

        }


        private void RedRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (RedRadioBtn.Checked == true)
            {
                ClassWorkComboBx.Text = "-";
                InspectionComboBx.Text = "-";
                ClassWorkComboBx.Enabled = false;
                InspectionComboBx.Enabled = false;
            }
            else
            {
                ClassWorkComboBx.Enabled = true;
                InspectionComboBx.Enabled = true;
            }
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (Form1.DiamondCount > 0)
            {
                Form1.DiamondCount--;
                
                this.pictureBox1.Image = global::MyStatWinForms.Properties.Resources.Diamond;
            }
            else
            {
                MessageBox.Show("You can not give Diamond");
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (Form1.DiamondCount > 0)
            {
                Form1.DiamondCount--;
               
                this.pictureBox2.Image = global::MyStatWinForms.Properties.Resources.Diamond;
            }
            else
            {
                MessageBox.Show("You can not give Diamond");
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (Form1.DiamondCount > 0)
            {
                Form1.DiamondCount--;
               
                this.pictureBox3.Image = global::MyStatWinForms.Properties.Resources.Diamond;
            }
            else
            {
                MessageBox.Show("You can not give Diamond");
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.pictureBox1.Image = global::MyStatWinForms.Properties.Resources.Diomand1;
            this.pictureBox2.Image = global::MyStatWinForms.Properties.Resources.Diomand1;
            this.pictureBox3.Image = global::MyStatWinForms.Properties.Resources.Diomand1;
            Form1.DiamondCount += 3;
        }


        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pictureBox5.Visible = false;
            CommentUserController comment = new CommentUserController();
            comment.Location = new Point(1136, 16);
            this.Controls.Add(comment);
            this.pictureBox5.Hide();

        }

        private void InspectionComboBx_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (InspectionComboBx.Text == "-")
            {
                InspectionComboBx.BorderColor = Color.DarkMagenta;
                InspectionComboBx.FillColor = Color.White;
                InspectionComboBx.ForeColor = Color.Magenta;
            }
            else
            {
                InspectionComboBx.FillColor = Color.DarkMagenta;
                InspectionComboBx.ForeColor = Color.White;

            }


        }

        private void ClassWorkComboBx_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (ClassWorkComboBx.Text == "-")
            {
                ClassWorkComboBx.BorderColor = Color.Lime;
                ClassWorkComboBx.ForeColor = Color.Lime;
                ClassWorkComboBx.FillColor = Color.White;
            }
            else if (int.Parse(ClassWorkComboBx.Text) >= 10 && int.Parse(ClassWorkComboBx.Text) <= 12)
            {
                ClassWorkComboBx.FillColor = Color.Lime;
                ClassWorkComboBx.ForeColor = Color.White;

            }

            else if (int.Parse(ClassWorkComboBx.Text) >= 6 && int.Parse(ClassWorkComboBx.Text) <= 9)
            {
                ClassWorkComboBx.FillColor = Color.Yellow;
                ClassWorkComboBx.ForeColor = Color.White;

            }

            else if (int.Parse(ClassWorkComboBx.Text) >= 3 && int.Parse(ClassWorkComboBx.Text) <= 5)
            {
                ClassWorkComboBx.FillColor = Color.DarkRed;
                ClassWorkComboBx.ForeColor = Color.White;

            }
            else if (int.Parse(ClassWorkComboBx.Text) >= 0 && int.Parse(ClassWorkComboBx.Text) <= 2)
            {
                ClassWorkComboBx.FillColor = Color.Red;
                ClassWorkComboBx.ForeColor = Color.White;
            }




        }
    }
}
