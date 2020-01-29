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
    public partial class carForm : Form
    {
        Boolean a;
        public ICarInterface car = new myCar();

        public carForm()
        {
            InitializeComponent();
        }

        private void setNameButton_Click(object sender, EventArgs e)
        {
            carSettingsForm open = new carSettingsForm(car);

            open.CN = true;

            open.ShowDialog();
        }

        private void getGasButton_Click(object sender, EventArgs e)
        {
            if (a == true)
            {
                carSettingsForm open = new carSettingsForm(car);

                open.Gas = true;

                open.ShowDialog();
            }
            else
            {
                MessageBox.Show("Unfortunately you have to set a tank capacity before you can get gas!", "Fuel", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void mpgButton_Click(object sender, EventArgs e)
        {
            carSettingsForm open = new carSettingsForm(car);

            open.MPG = true;

            open.ShowDialog();
        }

        private void setFuelButton_Click(object sender, EventArgs e)
        {
            carSettingsForm open = new carSettingsForm(car);

            open.Fuel = true;

            open.ShowDialog();
        }

        private void tankCapacityButton_Click(object sender, EventArgs e)
        {
            a = true;

            carSettingsForm open = new carSettingsForm(car);

            open.TC = true;

            open.ShowDialog();
        }

        private void setSpeedButton_Click(object sender, EventArgs e)
        {
            carSettingsForm open = new carSettingsForm(car);

            open.Speed = true;

            open.ShowDialog();
        }

        private void checkFuelButton_Click(object sender, EventArgs e)
        {
            string answer = car.gasLeft().ToString();

            MessageBox.Show("The car has " + answer + " gallons of fuel left.", "Fuel", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void carNameButton_Click(object sender, EventArgs e)
        {
            string answer = car.getName();

            if (answer == "")
            {
                MessageBox.Show("This car does not have a name yet! Make sure to set one!", "Name", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("The car's name is " + answer + ", congratulations on the new car!", "Name", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void checkSpeedButton_Click(object sender, EventArgs e)
        {
            string answer = car.getSpeed().ToString();

            MessageBox.Show("The car goes " + answer + " miles per hour when driving.", "Speed", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void milesButton_Click(object sender, EventArgs e)
        {
            string answer = car.getMilesDriven().ToString();

            MessageBox.Show("The car has driven " + answer + " miles.", "Miles Driven", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void carForm_Load(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;

            pictureBox1.Image = imageList1.Images[4];
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void driveButton_Click(object sender, EventArgs e)
        {
            if (car.gasLeft() > 0)
            {
                if (car.getSpeed() > 0)
                {
                    if (driveButton.Text == "Drive")
                    {
                        driveButton.Text = "Stop Driving";

                        timer1.Enabled = true;
                        timer2.Enabled = true;
                    }
                    else
                    {
                        driveButton.Text = "Drive";

                        pictureBox1.Image = imageList1.Images[4];

                        timer1.Enabled = false;
                        timer2.Enabled = false;
                    }
                }
                else
                {
                    MessageBox.Show("Before you drive, you need to have some speed! Set it quickly!");
                }
            }
            else
            {
                MessageBox.Show("You have no gas! Get some!");
            }
        }

        int m_index = 0;
        int m_minutes = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Image = imageList1.Images[m_index++];

            if (m_index >= imageList1.Images.Count)
            {
                m_index = 0;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            car.drive(m_minutes++);

            if (car.gasLeft() <= 0)
            {
                driveButton.Text = "Drive";

                timer2.Enabled = false;
                timer1.Enabled = false;

                MessageBox.Show("You are out of gas, get some more!");

            }
        }
    }
}
