using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Coding.Exercise {
    public class HotelBooking {
        public string GuestName;
        public DateTime StartDate;
        public DateTime EndDate;

        public HotelBooking(string guestName, DateTime startDate, int lengthOfStayInDays) {
            GuestName = guestName;
            StartDate = startDate;
            EndDate = StartDate.AddDays(lengthOfStayInDays);
        }
    }

    public class Order {
        public string Item { get; }
        public DateTime Date {
            get { return Date; }
            set {
                if (Date.Year == 2024) {
                    Date = value;
                }
            }
        }


        public Order(string item, DateTime date) {
            Item = item;
            Date = date;
        }

    }


}
