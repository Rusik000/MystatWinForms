namespace MyStatWinForms
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LessonNameLbl = new System.Windows.Forms.Label();
            this.EditBtn = new System.Windows.Forms.Button();
            this.RejectBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.SubjectLbl = new System.Windows.Forms.Label();
            this.SubjectTxtBx = new System.Windows.Forms.TextBox();
            this.SubstituteTeacherRadioBtn = new System.Windows.Forms.RadioButton();
            this.MainTeacherRadiobtn = new System.Windows.Forms.RadioButton();
            this.GroupNameLbl = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CommentLbl = new System.Windows.Forms.Label();
            this.DiamondPictureBx = new System.Windows.Forms.PictureBox();
            this.DiamondLbl = new System.Windows.Forms.Label();
            this.ClassWorkLbl = new System.Windows.Forms.Label();
            this.Inspectionlbl = new System.Windows.Forms.Label();
            this.NoteLbl = new System.Windows.Forms.Label();
            this.EntryLbl = new System.Windows.Forms.Label();
            this.FullNameLbl = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DiamondPictureBx)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LessonNameLbl);
            this.groupBox1.Controls.Add(this.EditBtn);
            this.groupBox1.Controls.Add(this.RejectBtn);
            this.groupBox1.Controls.Add(this.AddBtn);
            this.groupBox1.Controls.Add(this.SaveBtn);
            this.groupBox1.Controls.Add(this.SubjectLbl);
            this.groupBox1.Controls.Add(this.SubjectTxtBx);
            this.groupBox1.Controls.Add(this.SubstituteTeacherRadioBtn);
            this.groupBox1.Controls.Add(this.MainTeacherRadiobtn);
            this.groupBox1.Controls.Add(this.GroupNameLbl);
            this.groupBox1.Location = new System.Drawing.Point(1, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1260, 163);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // LessonNameLbl
            // 
            this.LessonNameLbl.AutoSize = true;
            this.LessonNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LessonNameLbl.Location = new System.Drawing.Point(696, 49);
            this.LessonNameLbl.Name = "LessonNameLbl";
            this.LessonNameLbl.Size = new System.Drawing.Size(0, 25);
            this.LessonNameLbl.TabIndex = 9;
            this.LessonNameLbl.Visible = false;
            // 
            // EditBtn
            // 
            this.EditBtn.BackgroundImage = global::MyStatWinForms.Properties.Resources.pen1;
            this.EditBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EditBtn.ForeColor = System.Drawing.Color.White;
            this.EditBtn.Location = new System.Drawing.Point(874, 11);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(37, 33);
            this.EditBtn.TabIndex = 8;
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // RejectBtn
            // 
            this.RejectBtn.BackColor = System.Drawing.Color.Blue;
            this.RejectBtn.ForeColor = System.Drawing.Color.White;
            this.RejectBtn.Location = new System.Drawing.Point(1175, 49);
            this.RejectBtn.Name = "RejectBtn";
            this.RejectBtn.Size = new System.Drawing.Size(85, 44);
            this.RejectBtn.TabIndex = 7;
            this.RejectBtn.Text = "Reject";
            this.RejectBtn.UseVisualStyleBackColor = false;
            this.RejectBtn.Click += new System.EventHandler(this.RejectBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AddBtn.ForeColor = System.Drawing.Color.White;
            this.AddBtn.Location = new System.Drawing.Point(1117, 103);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(89, 48);
            this.AddBtn.TabIndex = 6;
            this.AddBtn.Text = "Add Material";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackColor = System.Drawing.Color.Blue;
            this.SaveBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.SaveBtn.Location = new System.Drawing.Point(1060, 49);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(90, 44);
            this.SaveBtn.TabIndex = 5;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // SubjectLbl
            // 
            this.SubjectLbl.AutoSize = true;
            this.SubjectLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubjectLbl.Location = new System.Drawing.Point(687, 16);
            this.SubjectLbl.Name = "SubjectLbl";
            this.SubjectLbl.Size = new System.Drawing.Size(181, 25);
            this.SubjectLbl.TabIndex = 4;
            this.SubjectLbl.Text = "Lesson\'s  Subject";
            // 
            // SubjectTxtBx
            // 
            this.SubjectTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubjectTxtBx.Location = new System.Drawing.Point(692, 49);
            this.SubjectTxtBx.Multiline = true;
            this.SubjectTxtBx.Name = "SubjectTxtBx";
            this.SubjectTxtBx.Size = new System.Drawing.Size(349, 102);
            this.SubjectTxtBx.TabIndex = 3;
            // 
            // SubstituteTeacherRadioBtn
            // 
            this.SubstituteTeacherRadioBtn.AutoSize = true;
            this.SubstituteTeacherRadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubstituteTeacherRadioBtn.ForeColor = System.Drawing.Color.Blue;
            this.SubstituteTeacherRadioBtn.Location = new System.Drawing.Point(135, 45);
            this.SubstituteTeacherRadioBtn.Name = "SubstituteTeacherRadioBtn";
            this.SubstituteTeacherRadioBtn.Size = new System.Drawing.Size(162, 24);
            this.SubstituteTeacherRadioBtn.TabIndex = 2;
            this.SubstituteTeacherRadioBtn.TabStop = true;
            this.SubstituteTeacherRadioBtn.Text = "Substitute Teacher";
            this.SubstituteTeacherRadioBtn.UseVisualStyleBackColor = true;
            // 
            // MainTeacherRadiobtn
            // 
            this.MainTeacherRadiobtn.AutoSize = true;
            this.MainTeacherRadiobtn.BackColor = System.Drawing.Color.White;
            this.MainTeacherRadiobtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainTeacherRadiobtn.ForeColor = System.Drawing.Color.Blue;
            this.MainTeacherRadiobtn.Location = new System.Drawing.Point(6, 45);
            this.MainTeacherRadiobtn.Name = "MainTeacherRadiobtn";
            this.MainTeacherRadiobtn.Size = new System.Drawing.Size(123, 24);
            this.MainTeacherRadiobtn.TabIndex = 1;
            this.MainTeacherRadiobtn.TabStop = true;
            this.MainTeacherRadiobtn.Text = "Main Teacher";
            this.MainTeacherRadiobtn.UseVisualStyleBackColor = false;
            // 
            // GroupNameLbl
            // 
            this.GroupNameLbl.AutoSize = true;
            this.GroupNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupNameLbl.ForeColor = System.Drawing.Color.Blue;
            this.GroupNameLbl.Location = new System.Drawing.Point(6, 16);
            this.GroupNameLbl.Name = "GroupNameLbl";
            this.GroupNameLbl.Size = new System.Drawing.Size(126, 20);
            this.GroupNameLbl.TabIndex = 0;
            this.GroupNameLbl.Text = "FSDM_2201_az";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CommentLbl);
            this.groupBox2.Controls.Add(this.DiamondPictureBx);
            this.groupBox2.Controls.Add(this.DiamondLbl);
            this.groupBox2.Controls.Add(this.ClassWorkLbl);
            this.groupBox2.Controls.Add(this.Inspectionlbl);
            this.groupBox2.Controls.Add(this.NoteLbl);
            this.groupBox2.Controls.Add(this.EntryLbl);
            this.groupBox2.Controls.Add(this.FullNameLbl);
            this.groupBox2.Location = new System.Drawing.Point(1, 159);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1260, 51);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // CommentLbl
            // 
            this.CommentLbl.AutoSize = true;
            this.CommentLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CommentLbl.Location = new System.Drawing.Point(1136, 16);
            this.CommentLbl.Name = "CommentLbl";
            this.CommentLbl.Size = new System.Drawing.Size(92, 24);
            this.CommentLbl.TabIndex = 7;
            this.CommentLbl.Text = "Comment";
            // 
            // DiamondPictureBx
            // 
            this.DiamondPictureBx.Image = global::MyStatWinForms.Properties.Resources.Diamond;
            this.DiamondPictureBx.Location = new System.Drawing.Point(980, 16);
            this.DiamondPictureBx.Name = "DiamondPictureBx";
            this.DiamondPictureBx.Size = new System.Drawing.Size(33, 23);
            this.DiamondPictureBx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DiamondPictureBx.TabIndex = 6;
            this.DiamondPictureBx.TabStop = false;
            // 
            // DiamondLbl
            // 
            this.DiamondLbl.AutoSize = true;
            this.DiamondLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiamondLbl.Location = new System.Drawing.Point(954, 15);
            this.DiamondLbl.Name = "DiamondLbl";
            this.DiamondLbl.Size = new System.Drawing.Size(20, 24);
            this.DiamondLbl.TabIndex = 5;
            this.DiamondLbl.Text = "5";
            // 
            // ClassWorkLbl
            // 
            this.ClassWorkLbl.AutoSize = true;
            this.ClassWorkLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassWorkLbl.Location = new System.Drawing.Point(807, 15);
            this.ClassWorkLbl.Name = "ClassWorkLbl";
            this.ClassWorkLbl.Size = new System.Drawing.Size(104, 24);
            this.ClassWorkLbl.TabIndex = 4;
            this.ClassWorkLbl.Text = "Class Work";
            // 
            // Inspectionlbl
            // 
            this.Inspectionlbl.AutoSize = true;
            this.Inspectionlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inspectionlbl.Location = new System.Drawing.Point(624, 16);
            this.Inspectionlbl.Name = "Inspectionlbl";
            this.Inspectionlbl.Size = new System.Drawing.Size(145, 24);
            this.Inspectionlbl.TabIndex = 3;
            this.Inspectionlbl.Text = "İnspection Work";
            // 
            // NoteLbl
            // 
            this.NoteLbl.AutoSize = true;
            this.NoteLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoteLbl.Location = new System.Drawing.Point(432, 15);
            this.NoteLbl.Name = "NoteLbl";
            this.NoteLbl.Size = new System.Drawing.Size(136, 24);
            this.NoteLbl.TabIndex = 2;
            this.NoteLbl.Text = "Note Everyone";
            // 
            // EntryLbl
            // 
            this.EntryLbl.AutoSize = true;
            this.EntryLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EntryLbl.Location = new System.Drawing.Point(263, 16);
            this.EntryLbl.Name = "EntryLbl";
            this.EntryLbl.Size = new System.Drawing.Size(121, 24);
            this.EntryLbl.TabIndex = 1;
            this.EntryLbl.Text = "Time of Entry";
            // 
            // FullNameLbl
            // 
            this.FullNameLbl.AutoSize = true;
            this.FullNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullNameLbl.Location = new System.Drawing.Point(40, 15);
            this.FullNameLbl.Name = "FullNameLbl";
            this.FullNameLbl.Size = new System.Drawing.Size(92, 24);
            this.FullNameLbl.TabIndex = 0;
            this.FullNameLbl.Text = "FullName";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1308, 617);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DiamondPictureBx)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton SubstituteTeacherRadioBtn;
        private System.Windows.Forms.RadioButton MainTeacherRadiobtn;
        private System.Windows.Forms.Label GroupNameLbl;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button RejectBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Label SubjectLbl;
        private System.Windows.Forms.TextBox SubjectTxtBx;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox DiamondPictureBx;
        private System.Windows.Forms.Label DiamondLbl;
        private System.Windows.Forms.Label ClassWorkLbl;
        private System.Windows.Forms.Label Inspectionlbl;
        private System.Windows.Forms.Label NoteLbl;
        private System.Windows.Forms.Label EntryLbl;
        private System.Windows.Forms.Label FullNameLbl;
        private System.Windows.Forms.Label CommentLbl;
        private System.Windows.Forms.Label LessonNameLbl;
    }
}

