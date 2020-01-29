using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarProject
{
    public partial class carSettingsForm : Form
    {
        public Boolean TC;
        public Boolean Speed;
        public Boolean Gas;
        public Boolean MPG;
        public Boolean Fuel;
        public Boolean CN;

        public ICarInterface m_c;

        public carSettingsForm(ICarInterface c)
        {
            m_c = c;

            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Speed = false;
            TC = false;
            CN = false;
            Fuel = false;
            Gas = false;
            MPG = false;

            Close();
        }

        private void carSettingsForm_Load(object sender, EventArgs e)
        {
            if (CN == true)
            {
                label6.Visible = true;
                textBox6.Visible = true;
                textBox1.Text = "0";
                textBox2.Text = "0";
                textBox3.Text = "0";
                textBox4.Text = "0";
                textBox5.Text = "0";
            }
            if (TC == true)
            {
                label1.Visible = true;
                textBox1.Visible = true;
                textBox2.Text = "0";
                textBox3.Text = "0";
                textBox4.Text = "0";
                textBox5.Text = "0";

            }
            if (Speed == true)
            {
                label2.Visible = true;
                textBox2.Visible = true;
                textBox1.Text = "0";
                textBox3.Text = "0";
                textBox4.Text = "0";
                textBox5.Text = "0";
            }
            if (Gas == true)
            {
                label3.Visible = true;
                textBox3.Visible = true;
                textBox1.Text = "0";
                textBox2.Text = "0";
                textBox4.Text = "0";
                textBox5.Text = "0";
            }
            if (MPG == true)
            {
                label4.Visible = true;
                textBox4.Visible = true;
                textBox1.Text = "0";
                textBox2.Text = "0";
                textBox3.Text = "0";
                textBox5.Text = "0";
            }
            if (Fuel == true)
            {
                label5.Visible = true;
                textBox5.Visible = true;
                textBox1.Text = "0";
                textBox2.Text = "0";
                textBox3.Text = "0";
                textBox4.Text = "0";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CN == true)
            {
                m_c.setName(textBox6.Text);
            }

            if (TC == true)
            {
                m_c.setTankCapacity(int.Parse(textBox1.Text));
            }

            if (Speed == true)
            {
                m_c.setSpeed(int.Parse(textBox2.Text));
            }

            if (Gas)
            {
                if (int.Parse(textBox1.Text) >= int.Parse(textBox3.Text))
                {
                    m_c.fill(int.Parse(textBox3.Text));
                }
                else
                {
                    MessageBox.Show("That is over the tank capacity, so we have just filled it up to the max level!");

                    m_c.fill(int.Parse(textBox1.Text));
                }
            }

            if (MPG)
            {
                m_c.setMPG(int.Parse(textBox4.Text));
            }

            if (Fuel)
            {
                //Discontinued
            }

            Close();
        }
    }
}
