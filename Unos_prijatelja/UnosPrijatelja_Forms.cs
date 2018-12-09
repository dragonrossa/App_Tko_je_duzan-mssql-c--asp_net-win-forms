using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unos_prijatelja
{
    public partial class UnosPrijatelja_Forms : Form
    {
        public UnosPrijatelja_Forms()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProgramOne.One();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProgramTwo.Two();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ProgramThree.Three();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ProgramFour.Four();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ProgramFive.Five();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ProgramSix.Six();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ProgramSeven.Seven();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ProgramEight.Eight();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Console.ReadKey();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ProgramTen.Ten();
        }
    }
}
