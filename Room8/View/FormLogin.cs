using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Room8
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonAccedi_Click(object sender, EventArgs e)
        {
            FormMain formMain = new FormMain();
            formMain.Show();
        }

        private void buttonRegistrati_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
