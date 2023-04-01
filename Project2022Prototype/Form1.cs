using System;
using System.Windows.Forms;
using System.Drawing;
using System.Text.RegularExpressions;
namespace Project2022Prototype
{

    // Casey Hsu - Student Id: 101376814
    // Lukas Canji - Student Id: 101329428
    // Eric Grigor - Student Id: 100668121
    // Ryan Lee - Student Id: 101296633

    public partial class Form1 : Form
    {
        // Declaring that these are global variables
        CustomerManager customerManager = new CustomerManager(100);
        FlightManager flightManager = new FlightManager(100);
        BookingManager bookingManager = new BookingManager(100);
        // We are declaring it as a usable global so this allows access into the functions
        Coordinator coordinator;

        public Form1()
        {
            // This will create the coordinator when the application starts thus bringing the global managers into memory
            coordinator = new Coordinator(customerManager, flightManager, bookingManager);
            InitializeComponent();
        }

        private bool isValidFindBooking()
        {
            string numberPattern = "^[0-9]";
            if (findBookInput.Text == string.Empty)
            {
                // turns textfield red to get users attention, and also uses Focus to bring the users cursor
                findBookInput.BackColor = Color.Red;
                findBookInput.Focus();

                MessageBox.Show("Validation error", "Error");
                return false;
            }
            else if (Regex.IsMatch(findBookInput.Text, numberPattern) == false)
            {
                findBookInput.BackColor = Color.Red;
                findBookInput.Focus();

                MessageBox.Show("should be in Characters only", "Error");
                return false;
            }
            return true;
        }

        private bool isValidAddBooking()
        {
            // lirbary for different patterns of validation 
            string stringPattern = @"^[0-9a-zA-Z]+$";



            if (bookFlightInput.Text == string.Empty)
            {
                // turns textfield red to get users attention, and also uses Focus to bring the users cursor
                bookFlightInput.BackColor = Color.Red;
                bookFlightInput.Focus();

                MessageBox.Show("Validation error", "Error");
                return false;
            }
            else if (Regex.IsMatch(bookFlightInput.Text, stringPattern) == false)
            {
                bookFlightInput.BackColor = Color.Red;
                bookFlightInput.Focus();

                MessageBox.Show("should be in Characters only", "Error");
                return false;
            }
            // 2nd, textfield validation
            if (bookCustInput.Text == string.Empty)
            {
                bookCustInput.BackColor = Color.Red;
                bookCustInput.Focus();

                MessageBox.Show("Validation error", "Error");
                return false;
            }
            else if (Regex.IsMatch(bookCustInput.Text, stringPattern) == false)
            {
                bookCustInput.BackColor = Color.Red;
                bookCustInput.Focus();

                MessageBox.Show("should be in Characters only", "Error");
                return false;
            }
            // 3rd, email textfield validation
            if (bookDestInput.Text == string.Empty)
            {
                bookDestInput.BackColor = Color.Red;
                bookDestInput.Focus();

                MessageBox.Show("Validation error", "Error");
                return false;
            }
            else if (Regex.IsMatch(bookDestInput.Text, stringPattern) == false)
            {
                bookDestInput.BackColor = Color.Red;
                bookDestInput.Focus();

                MessageBox.Show("should be in email format ****@****.com only", "Error");
                return false;
            }
            return true;
        }

        // function for checking input of find flight
        private bool isValidFindFlight()
        {
            string numberPattern = "^[0-9]";
            if (findFlightInput.Text == string.Empty)
            {
                // turns textfield red to get users attention, and also uses Focus to bring the users cursor
                findFlightInput.BackColor = Color.Red;
                findFlightInput.Focus();

                MessageBox.Show("Validation error", "Error");
                return false;
            }
            else if (Regex.IsMatch(findFlightInput.Text, numberPattern) == false)
            {
                findFlightInput.BackColor = Color.Red;
                findFlightInput.Focus();

                MessageBox.Show("should be in Characters only", "Error");
                return false;
            }
            return true;
        }

        //--------------------- Delete Flight ------------------
        private bool isValidDeleteFlight()
        {
            string numberPattern = "^[0-9]";
            if (delFlightInput.Text == string.Empty)
            {
                // turns textfield red to get users attention, and also uses Focus to bring the users cursor
                delFlightInput.BackColor = Color.Red;
                delFlightInput.Focus();

                MessageBox.Show("Validation error", "Error");
                return false;
            }
            else if (Regex.IsMatch(delFlightInput.Text, numberPattern) == false)
            {
                delFlightInput.BackColor = Color.Red;
                delFlightInput.Focus();

                MessageBox.Show("should be in Characters only", "Error");
                return false;
            }
            return true;
        }


        // -------------------- Add Flight----------------------- 
        private bool isValidAddFlight()
        {
            // lirbary for different patterns of validation 
            string stringPattern = @"^[0-9a-zA-Z]+$";
          

            // 1st airport textfield validation
            if (airportInput.Text == string.Empty)
            {
                // turns textfield red to get users attention, and also uses Focus to bring the users cursor
                airportInput.BackColor = Color.Red;
                airportInput.Focus();

                MessageBox.Show("Validation error", "Error");
                return false;
            }
            else if (Regex.IsMatch(airportInput.Text, stringPattern) == false)
            {
                airportInput.BackColor = Color.Red;
                airportInput.Focus();

                MessageBox.Show("should be in Characters only", "Error");
                return false;
            }
            // 2nd, Destination textfield validation
            if (destInput.Text == string.Empty)
            {
                destInput.BackColor = Color.Red;
                destInput.Focus();

                MessageBox.Show("Validation error", "Error");
                return false;
            }
            else if (Regex.IsMatch(destInput.Text, stringPattern) == false)
            {
                destInput.BackColor = Color.Red;
                destInput.Focus();

                MessageBox.Show("should be in Characters only", "Error");
                return false;
            }
            // 3rd, dateInput textfield validation
            if (dateInput.Text == string.Empty)
            {
                dateInput.BackColor = Color.Red;
                dateInput.Focus();

                MessageBox.Show("Validation error", "Error");
                return false;
            }
            // 4th, capcaity textfield validation
            if (capInput.Text == string.Empty)
            {
                capInput.BackColor = Color.Red;
                capInput.Focus();

                MessageBox.Show("Validation error", "Error");
                return false;
            }
            else if (Regex.IsMatch(capInput.Text, stringPattern) == false)
            {
                capInput.BackColor = Color.Red;
                capInput.Focus();

                MessageBox.Show("should be in numbers only", "Error");
                return false;
            }
            return true;
        } 
    


        /// --------------------- Customer Tab -------------------------
        private bool isValidFindCustomer()
        {
            string numberPattern = "^[0-9]";
            if (findCustInput.Text == string.Empty)
            {
                // turns textfield red to get users attention, and also uses Focus to bring the users cursor
                findCustInput.BackColor = Color.Red;
                findCustInput.Focus();

                MessageBox.Show("Validation error", "Error");
                return false;
            }
            else if (Regex.IsMatch(findCustInput.Text, numberPattern) == false)
            {
                findCustInput.BackColor = Color.Red;
                findCustInput.Focus();

                MessageBox.Show("should be in Characters only", "Error");
                return false;
            }
            return true;
        }

        private bool isValidDeleteCustomer()
        {
            string numberPattern = "^[0-9]";
            if (delCustInput.Text == string.Empty)
            {
                // turns textfield red to get users attention, and also uses Focus to bring the users cursor
                delCustInput.BackColor = Color.Red;
                delCustInput.Focus();

                MessageBox.Show("Validation error", "Error");
                return false;
            }
            else if (Regex.IsMatch(delCustInput.Text, numberPattern) == false)
            {
                delCustInput.BackColor = Color.Red;
                delCustInput.Focus();

                MessageBox.Show("should be in Characters only", "Error");
                return false;
            }
            return true;
        }

        // function to check if Add Customer is Valid 
        private bool isValidAddCustomer()
        {
            // lirbary for different patterns of validation 
            string stringPattern = @"^[a-zA-Z]+$";
            string mailPattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            string numberPattern = "^[0-9]{10}";


            if (fNameInput.Text == string.Empty)
            {
                // turns textfield red to get users attention, and also uses Focus to bring the users cursor
                fNameInput.BackColor = Color.Red;
                fNameInput.Focus();

                MessageBox.Show("Validation error", "Error");
                return false;
            }
            else if (Regex.IsMatch(fNameInput.Text, stringPattern) == false)
            {
                fNameInput.BackColor = Color.Red;
                fNameInput.Focus();

                MessageBox.Show("should be in Characters only", "Error");
                return false;
            }
            // 2nd, textfield validation
            if (lNameInput.Text == string.Empty)
            {
                lNameInput.BackColor = Color.Red;
                lNameInput.Focus();

                MessageBox.Show("Validation error", "Error");
                return false;
            }
            else if (Regex.IsMatch(lNameInput.Text, stringPattern) == false)
            {
                lNameInput.BackColor = Color.Red;
                lNameInput.Focus();

                MessageBox.Show("should be in Characters only", "Error");
                return false;
            }
            // 3rd, email textfield validation
            if (emailInput.Text == string.Empty)
            {
                emailInput.BackColor = Color.Red;
                emailInput.Focus();

                MessageBox.Show("Validation error", "Error");
                return false;
            }
            else if (Regex.IsMatch(emailInput.Text, mailPattern) == false)
            {
                emailInput.BackColor = Color.Red;
                emailInput.Focus();

                MessageBox.Show("should be in email format ****@****.com only", "Error");
                return false;
            }
            // 4th, phonenumber textfield validation
            if (phoneInput.Text == string.Empty)
            {
                phoneInput.BackColor = Color.Red;
                phoneInput.Focus();

                MessageBox.Show("Validation error", "Error");
                return false;
            }
            else if (Regex.IsMatch(phoneInput.Text, numberPattern) == false)
            {
                phoneInput.BackColor = Color.Red;
                phoneInput.Focus();

                MessageBox.Show("should be in numbers only", "Error");
                return false;
            }
            // 5th, email textfield validation
            if (addInput.Text == string.Empty)
            {
                addInput.BackColor = Color.Red;
                addInput.Focus();

                MessageBox.Show("Validation error", "Error");
                return false;
            }
            else if (Regex.IsMatch(emailInput.Text, mailPattern) == false)
            {
                addInput.BackColor = Color.Red;
                addInput.Focus();

                MessageBox.Show("Should be Email input ****@****.com", "Error");
                return false;
            }

            return true;
        }


        private void label1_Click(object sender, EventArgs e)
        {
            // OOPS
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            // OOPS
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            // OOPS
        }

        // Delete Customer
        private void button3_Click(object sender, EventArgs e)
        {
            //error handling isvalid()
            if (isValidDeleteCustomer())
            {
                int userInput = Convert.ToInt32(delCustInput.Text);

                if (customerManager.deleteCustomer(userInput))
                {
                    MessageBox.Show("Customer was successfully deleted.");
                    delCustInput.Text = "";
                }

                MessageBox.Show("Customer cannot be deleted.");
                delCustInput.Text = "";
            }
        }

        // Booking List
        private void button5_Click(object sender, EventArgs e)
        {
            listBookingOutput.Text = coordinator.listBookings();
        }

        private void findCustBtn_Click(object sender, EventArgs e)
        {
            if (isValidFindCustomer())
            {
                string userInput = findCustInput.Text;

                findCustOuput.Text = coordinator.findCustomer(Convert.ToInt32(userInput));

            }
        }


        private void addCustBtn_Click(object sender, EventArgs e)
        {
            // checking is the inputs for Add Customer click event are valid 
            if (isValidAddCustomer())
            {
                MessageBox.Show("Success");
                string fname = fNameInput.Text;
                string lname = lNameInput.Text;
                string email = emailInput.Text;
                string phone = phoneInput.Text;
                string address = addInput.Text;

                // This now allows us to call all the coordinator functions per call to action
                coordinator.addCustomer(fname, lname, phone, email, address, 0, true);

                // Need error handling for if adding was unsuccessful etc
                // MessageBox.Show("Customer was succesfully Added");

                fNameInput.Text = "";
                lNameInput.Text = "";
                emailInput.Text = "";
                phoneInput.Text = "";
                addInput.Text = "";
            }
        }


        private void listCustBtn_Click(object sender, EventArgs e)
        {
            // Need error handling for if adding was unsuccessful etc
            listOutput.Text = coordinator.listCustomers();
        }

        private void listFlights_Click(object sender, EventArgs e)
        {
            // Need error handling for if adding was unsuccessful etc
            listFlightOutput.Text = "Current Flights List:\n" + coordinator.listFlights();
        }

        private void addFlightBtn_Click(object sender, EventArgs e)
        {
            // checking is the inputs for Add Customer click event are valid 
            if (isValidAddFlight())
            {
                string airport = airportInput.Text;
                string destination = destInput.Text;
                string date = dateInput.Text;
                string capacity = capInput.Text;

                // This now allows us to call all the coordinator functions per call to action
                coordinator.addFlight(airport, destination, date, int.Parse(capacity));

                // Need error handling for if adding was unsuccessful etc
                MessageBox.Show("Flight was succesfully Added");

                airportInput.Text = "";
                destInput.Text = "";
                dateInput.Text = "";
                capInput.Text = "";
            }
            else
            {
                MessageBox.Show("Adding was unsuccesfully");
            }
        }

        // delete flight button action
        private void delFlightBtn_Click(object sender, EventArgs e)
        {
            // validing input of delete button
            if (isValidDeleteFlight())
            {
                int flightNumber = Convert.ToInt32(delFlightInput.Text);
                coordinator.deleteFlight(flightNumber);
                MessageBox.Show("Flight was deleted.");

            }
        }

        // find Flight button click
        private void findFlightBtn_Click(object sender, EventArgs e)
        {
            if (isValidFindFlight())
            {
                string flightNumber = findFlightInput.Text;
                findFlightOutput.Text = coordinator.findFlight(Convert.ToInt32(flightNumber));
            }
        }

        // List Flights Button
        private void button1_Click(object sender, EventArgs e)
        {
            findFlightOutput.Text = "Current Flights List:\n" + coordinator.listFlights();
        }

        // Add Booking Button Click
        private void addBookingBtn_Click(object sender, EventArgs e)
        {
            if (isValidAddBooking())
            {
                if (bookFlightInput.Text != "" && bookCustInput.Text != "" && bookDestInput.Text != "")
                {
                    string flightNumber = bookFlightInput.Text;
                    string customerNumber = bookCustInput.Text;
                    string destination = bookDestInput.Text;
                    coordinator.addBooking(Convert.ToInt32(flightNumber), Convert.ToInt32(customerNumber), destination);
                    MessageBox.Show("Booking was successful.");
                }
            }
        }

        private void findBookBtn_Click(object sender, EventArgs e)
        {
            if (isValidFindBooking())
            {
                if (findBookInput.Text != "")
                {
                    int bookingNumber = Convert.ToInt32(findBookInput.Text);
                    findBookingOutput.Text = coordinator.findBooking(bookingNumber);
                }
            }
        }

        private void listInfoBooking_Click(object sender, EventArgs e)
        {
            customerListBook.Text = coordinator.listCustomers();
            flightListBook.Text = coordinator.listFlights();
        }
    }
}    