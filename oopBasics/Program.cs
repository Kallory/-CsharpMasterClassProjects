using System;

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
}
