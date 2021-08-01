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
    public partial class CommentUserController : UserControl
    {

        public CommentUserController()
        {
            InitializeComponent();
        }

        private void WriteCommentBtn_Click(object sender, EventArgs e)
        {
            CommentLbl.Text = CommentTxtBx.Text;
            CommentLbl.Visible = true;
            CommentTxtBx.Visible = false;
            WriteCommentBtn.Visible = false;
        }

        private void RejectCommentBtn_Click(object sender, EventArgs e)
        {
            if (CommentTxtBx.Visible == false)
            {
                CommentTxtBx.Text = String.Empty;
                CommentLbl.Text = String.Empty;
                CommentTxtBx.Visible = true;
                WriteCommentBtn.Visible = true;
                CommentLbl.Visible = false;
            } 
            
        }
    }
}
