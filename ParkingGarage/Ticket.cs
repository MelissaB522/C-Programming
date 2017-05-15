using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingGarage
{
    public class Ticket
    {
        // declare variables
        private int ticketNo = 0;
        private DateTime timeIn;
        private DateTime timeOut;
        private TimeSpan timeElapsed;

        // getter and setter for ticket number
        public int TicketNo
        {
            get
            {
                return ticketNo;
            }

            set
            {
                ticketNo = value;
            }
        }

        // getter and setter for the time in
        public DateTime TimeIn
        {
            get
            {
                return timeIn;
            }

            set
            {
                timeIn = value;
            }
        }

        // getter and setter for the time out
        public DateTime TimeOut
        {
            get
            {
                return timeOut;
            }

            set
            {
                timeOut = value;
            }
        }
        
        // constructor
        public Ticket (int ticketno, DateTime timein)
        {
            ticketNo = ticketno;
            timeIn = timein;
        }

        // calculate charge method
        public double CalculateCharge()
        {
            // sets timeElapsed to the difference between timeIn and timeOut
            timeElapsed = timeOut.Subtract(timeIn);
            // anything up to 3 hours is $2
            if (timeElapsed.Hours <= 3.00)
            {
                return 2.00;
            }
            else 
            {
                // the time the car was parked minus the first 3 hours gets the addition amount, plus the $2 from the first 3 hours
                double chargeAmount = ((timeElapsed.Hours - 3) * .50) + 2.00;
                // $10 is the max
                if (chargeAmount >= 10.00)
                {
                    return 10.00;
                }
                else
                {
                    return chargeAmount;
                }
            }
        } // end CalculateCharge method

        public override string ToString()
        {
            string TimeOutString = TimeOut.ToString("hh:mm tt"); // formats to show only hours, minutes, and am/pm
            string ChargeString = "$" + CalculateCharge();
            // formats the string to be empty if the ticket hasn't been "exited"
            if (TimeOut == DateTime.MinValue)
            {
                TimeOutString = "";
                ChargeString = "";
            }
            return "Ticket #" + ticketNo +
                "\r\nTime In: " + TimeIn.ToString("hh:mm tt") +
                "\r\nTime Out: " + TimeOutString +
                "\r\nCharge: " + ChargeString;
        }
    } // end class
}
