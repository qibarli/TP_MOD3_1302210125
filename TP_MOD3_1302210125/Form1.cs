using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_MOD3_1302210125
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nama = this.textcek1.Text;
            this.labelcek2.Text = "MANTAP SELALU! " + nama + " 🙂🙂🙂🙂🙂";
        }

        private void labelcek1_Click(object sender, EventArgs e)
        {

        }
    }
}
