using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ManageUsers
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim().Length > 0)
            {
                if (txtName.Text != "")
                {
                    AD.Helper h = new AD.Helper();


                    Console.WriteLine(h.GetUser("addcs01",389,"administrator","REDACTED","dave"));
                }
            }
        }
    }
}
