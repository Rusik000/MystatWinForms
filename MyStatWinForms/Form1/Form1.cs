using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyStatWinForms
{
    public partial class Form1 : Form
    {

        public static int DiamondCount { get; set; } = 5;
        public static string Mytext { get; set; }

        public Form1()
        {
            InitializeComponent();
            Student student1 = new Student
            {
                ID = 1,
                Name = "Kamran",
                Surname = "Aliyev",
                FatherName = "Yusif",
                EntryTime = DateTime.Now
            };
            Student student2 = new Student
            {
                ID = 2,
                Name = "Samir",
                Surname = "Memmedov",
                FatherName = "Fuzuli",
                EntryTime = DateTime.Now.AddDays(-4)
            };
            Student student3 = new Student
            {
                ID = 3,
                Name = "Lale",
                Surname = "Muradova",
                FatherName = "Asif",
                EntryTime = DateTime.Now.AddDays(-3)
            };
            Student student4 = new Student
            {
                ID = 4,
                Name = "Ruslan",
                Surname = "Mustafayev",
                FatherName = "Aydin",
                EntryTime = DateTime.Now
            };
            Student student5 = new Student
            {
                ID = 5,
                Name = "Teymur",
                Surname = "Novruzov",
                FatherName = "Rasim",
                EntryTime = DateTime.Now.AddDays(-7)
            };
            Student student6 = new Student
            {
                ID = 6,
                Name = "Huseyn",
                Surname = "Rustemli",
                FatherName = "Senan",
                EntryTime = DateTime.Now.AddDays(-1)
            };
            Student student7 = new Student
            {
                ID = 7,
                Name = "Rafael",
                Surname = "Xelilzade",
                FatherName = "Ilham",
                EntryTime = DateTime.Now.AddDays(-2)
            };


           

            Students studentsControl1 = new Students(student1);
            Students studentsControl2 = new Students(student2);
            Students studentsControl3 = new Students(student3);
            Students studentsControl4 = new Students(student4);
            Students studentsControl5 = new Students(student5);
            Students studentsControl6 = new Students(student6);
            Students studentsControl7 = new Students(student7);






            studentsControl1.Location = new Point(0, 200);
            this.Controls.Add(studentsControl1);


            studentsControl2.Location = new Point(0, 260);
            this.Controls.Add(studentsControl2);


            studentsControl3.Location = new Point(0, 320);
            this.Controls.Add(studentsControl3);


            studentsControl4.Location = new Point(0, 380);
            this.Controls.Add(studentsControl4);



            studentsControl5.Location = new Point(0, 440);
            this.Controls.Add(studentsControl5);


            studentsControl6.Location = new Point(0, 500);
            this.Controls.Add(studentsControl6);



            studentsControl7.Location = new Point(0, 560);
            this.Controls.Add(studentsControl7);

        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (SubjectTxtBx.Text != String.Empty)
            {
                LessonNameLbl.Text = SubjectTxtBx.Text;
                SubjectTxtBx.Visible = false;
                LessonNameLbl.Visible = true;
            }
            else
            {
                return;
            }
        }

        private void RejectBtn_Click(object sender, EventArgs e)
        {
            if (LessonNameLbl.Visible == true)
            {
                LessonNameLbl.Visible = false;
                SubjectTxtBx.Visible = true;
                SubjectTxtBx.Text = String.Empty;
            }
            else
            {
                SubjectTxtBx.Text = String.Empty;
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (LessonNameLbl.Visible == true)
            {
                SubjectTxtBx.Text = LessonNameLbl.Text;
                LessonNameLbl.Visible = false;
                SubjectTxtBx.Visible = true;
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (LessonNameLbl.Visible == true)
            {
                SubjectTxtBx.Text = LessonNameLbl.Text;
                LessonNameLbl.Visible = false;
                SubjectTxtBx.Visible = true;
            }
        }
    }
}
