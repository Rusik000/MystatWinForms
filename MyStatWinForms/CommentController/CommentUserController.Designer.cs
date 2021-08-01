namespace MyStatWinForms
{
    partial class CommentUserController
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CommentTxtBx = new System.Windows.Forms.TextBox();
            this.WriteCommentBtn = new System.Windows.Forms.Button();
            this.RejectCommentBtn = new System.Windows.Forms.Button();
            this.CommentLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CommentTxtBx
            // 
            this.CommentTxtBx.Location = new System.Drawing.Point(0, 0);
            this.CommentTxtBx.Multiline = true;
            this.CommentTxtBx.Name = "CommentTxtBx";
            this.CommentTxtBx.Size = new System.Drawing.Size(182, 23);
            this.CommentTxtBx.TabIndex = 0;
            // 
            // WriteCommentBtn
            // 
            this.WriteCommentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WriteCommentBtn.Location = new System.Drawing.Point(3, 25);
            this.WriteCommentBtn.Name = "WriteCommentBtn";
            this.WriteCommentBtn.Size = new System.Drawing.Size(76, 31);
            this.WriteCommentBtn.TabIndex = 1;
            this.WriteCommentBtn.Text = "Write ";
            this.WriteCommentBtn.UseVisualStyleBackColor = true;
            this.WriteCommentBtn.Click += new System.EventHandler(this.WriteCommentBtn_Click);
            // 
            // RejectCommentBtn
            // 
            this.RejectCommentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RejectCommentBtn.Location = new System.Drawing.Point(103, 25);
            this.RejectCommentBtn.Name = "RejectCommentBtn";
            this.RejectCommentBtn.Size = new System.Drawing.Size(79, 31);
            this.RejectCommentBtn.TabIndex = 2;
            this.RejectCommentBtn.Text = "Cancel";
            this.RejectCommentBtn.UseVisualStyleBackColor = true;
            this.RejectCommentBtn.Click += new System.EventHandler(this.RejectCommentBtn_Click);
            // 
            // CommentLbl
            // 
            this.CommentLbl.AutoSize = true;
            this.CommentLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CommentLbl.Location = new System.Drawing.Point(-2, 0);
            this.CommentLbl.Name = "CommentLbl";
            this.CommentLbl.Size = new System.Drawing.Size(51, 20);
            this.CommentLbl.TabIndex = 3;
            this.CommentLbl.Text = "label1";
            this.CommentLbl.Visible = false;
            // 
            // CommentUserController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CommentLbl);
            this.Controls.Add(this.RejectCommentBtn);
            this.Controls.Add(this.WriteCommentBtn);
            this.Controls.Add(this.CommentTxtBx);
            this.Name = "CommentUserController";
            this.Size = new System.Drawing.Size(225, 63);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CommentTxtBx;
        private System.Windows.Forms.Button WriteCommentBtn;
        private System.Windows.Forms.Button RejectCommentBtn;
        private System.Windows.Forms.Label CommentLbl;
    }
}
