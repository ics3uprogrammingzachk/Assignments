/*
 * Created by: Zachary Kranabetter
 * Created on: Febuary 15th 2019
 * Created for: ICS3U Programming
 * Assignment 2 Falling Objects
 * This program lets the user enter an ammount of time for how long the ball will be in the air for and displays the height of the ball after that amount of time.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FallingObjects
{
    public partial class frmFallingObjects : Form
    {
        //delcare my constants
        const double GRAVITY_EARTH = 9.81;
        const double GRAVITY_MOON = 1.62;

        public frmFallingObjects()
        {
            InitializeComponent();
        }

        //declare my variables

        double gravity;
        double dropHeight;


        //set gravity

        private void radEarthGravity_CheckedChanged(object sender, EventArgs e)
        {
            gravity = GRAVITY_EARTH;
        }

        private void radMoonGravity_CheckedChanged(object sender, EventArgs e)
        {
            gravity = GRAVITY_MOON;
        }


        //set height

        private void radHeight100_CheckedChanged(object sender, EventArgs e)
        {
            dropHeight = 100;
        }

        private void radHeight200_CheckedChanged(object sender, EventArgs e)
        {
            dropHeight = 200;
        }


        //take the users input

        private void txtTime_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //check if they put something

            if (txtTime.Text == "")
            {
                lblHeight.Text = "?";
            }

            else

            {
                //calculate the height

                double time = Convert.ToDouble(txtTime.Text);

                double height = dropHeight - (0.5 * gravity * Math.Pow(time, 2));

                height = Math.Round(height * 100) / 100;

                //if the height would be negitive make it zero

                if (height < 0)
                {
                    lblHeight.Text = "0";
                }
                else

                    //display the height

                    lblHeight.Text = Convert.ToString(height);

            }
        }

        private void lblHeight_Click(object sender, EventArgs e)
        {

        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            //close the program

            this.Close();
        }

        private void lblQuestion_Click(object sender, EventArgs e)
        {

        }

        private void lblQuestion2_Click(object sender, EventArgs e)
        {

        }

        private void frmFallingObjects_Load(object sender, EventArgs e)
        {

        }

    }
}
