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

    public class DailyAccountState {
        public int InitialState { get; }

        public int SumOfOperations { get; }

        public DailyAccountState(
            int initialState,
            int sumOfOperations) {
            InitialState = initialState;
            SumOfOperations = sumOfOperations;
        }

        public int EndOfDayState() => InitialState + SumOfOperations;
        public string Report() => $"Day: {DateTime.Now.Day}, month: {DateTime.Now.Month}, year: {DateTime.Now.Year}, end of day state: {EndOfDayState()}";

    }

}
