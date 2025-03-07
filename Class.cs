using System;
using System.Runtime.InteropServices.JavaScript;

namespace Eser1;

 class HotelBooking
 {
     public string GuestName;
     public DateTime StartDate;
     public DateTime EndDate;

     public HotelBooking(string guestName, DateTime startDate, int lengthOfStayInDays)
     {
         this.GuestName = guestName;
         this.StartDate = startDate;
         this.EndDate = startDate.AddDays(lengthOfStayInDays);

     }

 }
