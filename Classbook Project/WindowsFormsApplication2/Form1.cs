using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f = new Form2();
            f.Show();
            f.Closed += (s, args) => this.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Изработено от : Ангел Младенов, Валентин Илиев, Костадин Добрев, Павлин Минков ");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f = new Form3();
            f.Show();
            f.Closed += (s, args) => this.Show();
        }
    }
}
