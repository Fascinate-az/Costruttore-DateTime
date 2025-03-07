class Program
    {
        static void Main()
        {
            Console.WriteLine("Per prenotare inserire il giorno d'arrivo;");
            string input = Console.ReadLine();
            DateTime date = DateTime.Parse(input);

            Console.WriteLine("ora inserire nome e cognome");
            string nomeCognome = Console.ReadLine();

            Console.WriteLine("ora inserire i giorni di soggiorno");
            int diSoggiorno = int.Parse(Console.ReadLine());
            
            HotelBooking reservation = new HotelBooking(nomeCognome,date,diSoggiorno);

            Console.WriteLine($"il giorno d'arrivo {reservation.StartDate},la prenotazione è ha nome di {reservation.GuestName},e il checkout è il gg{reservation.EndDate}");
            Console.WriteLine();
        }
    }
}
