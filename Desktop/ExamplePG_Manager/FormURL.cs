using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamplePG_Manager
{
    public partial class FormURL : Form
    {
        public string text;
        public FormURL(string h)
        {
            InitializeComponent();
            text = h;
            textBox_urlIzd.Text = h;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            text = textBox_urlIzd.Text;
            Close();
        }

        private void FormURL_Load(object sender, EventArgs e)
        {

        }
    }
}
