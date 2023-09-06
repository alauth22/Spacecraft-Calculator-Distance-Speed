using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week_3_A
{
    public partial class frmExploreTheGalaxy : Form
    {
        public frmExploreTheGalaxy()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        { 
            //Declare and Initialize a variable to hold the user input value for number of days. 
            int days;  

            //Obtain and validate if the variable days is of int type. 
            if (int.TryParse(txtActualDays.Text, out days))
            { 
                //If days is of int type, need to validate if days is a non-zero, positive int value.
                //Doing this to ensure user does not use "negative" days. 
                if (days > 0)
                {
                    //Declare and Initialize variables for speed (MPD) and distance and our counter variable. 
                    int DAY; //Counter variable to keep track of how many days through which we are looping. 
                    int previous_speed = 1000; //Gave this value to help begin the for loop with correct value. 
                    int current_speed;
                    int current_distance;
                    int total_distance;

                    //Decided to hardcode just the first iteration before beginning the for loop. 
                    //Decided this because you need specific values first before the iterations can begin. 
                    current_speed = 1000; //Both values obtained from same formulae as in for loop. 
                    total_distance = 500;
                    
                    //For loop now begins on day 2 since day 1 was done in lines 41 and 42.  
                    for (DAY = 2; DAY <= days; DAY++)
                    {
                        //Calculate speed. 
                        current_speed = previous_speed * 2; 

                        //Calculate distance. 
                        current_distance = (previous_speed + current_speed) / 2;

                        //Calculate total distance. Need to continue to add to the total distance after each iteration.  
                        total_distance += current_distance;

                        //Update our previous speed to equal the current speed BEFORE next iteration.  
                        previous_speed = current_speed;

                    }

                    //Display current_speed and total_distance values. 
                    lblActualSpeed.Text = current_speed + " MPD";
                    lblActualDistance.Text = total_distance + " Miles";
                }

                else
                {
                    //Error message to User if User types a zero or a negative integer. 
                    MessageBox.Show("Invalid input. Please type only positive, non-zero integer values.");

                    //I found this new method and decided to use it to clear the textbox!
                    txtActualDays.Clear(); 

                    //Puts Focus back on the textbox. 
                    txtActualDays.Focus();
                }

            }

            else
            {
                //Error Message to User if User types a non-integer value. 
                MessageBox.Show("Invalid Input. Please type only an integer value.");
                
                //Clears the text from textbox. 
                txtActualDays.Clear();

                //Puts Focus back on the textbox. 
                txtActualDays.Focus();
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //Clear all textboxes and puts Focus on the user input box. 
            txtActualDays.Clear();
            lblActualSpeed.Text = "";
            lblActualDistance.Text = "";
            txtActualDays.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //Closes the form entirely. 
            this.Close();
        }
    }
}
