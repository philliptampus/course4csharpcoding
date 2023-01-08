// See https://aka.ms/new-console-template for more information
using DevTrainingApp;

List<Cinema> kccCinemas;
var cinema1 = new Cinema(1, "Cinema 1");

cinema1.CinemaSeats = new List<CinemaSeat>()
{
    new CinemaSeat() { Id = 1, SeatNumber = "A1", IsTaken = false },
    new CinemaSeat() { Id = 2, SeatNumber = "A2", IsTaken = false },
    new CinemaSeat() { Id = 3, SeatNumber = "A3", IsTaken = false },
    new CinemaSeat() { Id = 4, SeatNumber = "A4", IsTaken = false },
    new CinemaSeat() { Id = 5, SeatNumber = "A5", IsTaken = false },
    new CinemaSeat() { Id = 6, SeatNumber = "B1", IsTaken = false },
    new CinemaSeat() { Id = 7, SeatNumber = "B2", IsTaken = false },
    new CinemaSeat() { Id = 8, SeatNumber = "B3", IsTaken = false },
    new CinemaSeat() { Id = 9, SeatNumber = "B4", IsTaken = false },
    new CinemaSeat() { Id = 10, SeatNumber = "B5", IsTaken = false },
    new CinemaSeat() { Id = 11, SeatNumber = "C1", IsTaken = false },
    new CinemaSeat() { Id = 12, SeatNumber = "C2", IsTaken = false },
    new CinemaSeat() { Id = 13, SeatNumber = "C3", IsTaken = false },
    new CinemaSeat() { Id = 14, SeatNumber = "C4", IsTaken = false },
    new CinemaSeat() { Id = 15, SeatNumber = "C5", IsTaken = false },
    new CinemaSeat() { Id = 16, SeatNumber = "D1", IsTaken = false },
    new CinemaSeat() { Id = 17, SeatNumber = "D2", IsTaken = false },
    new CinemaSeat() { Id = 18, SeatNumber = "D3", IsTaken = false },
    new CinemaSeat() { Id = 19, SeatNumber = "D4", IsTaken = false },
    new CinemaSeat() { Id = 20, SeatNumber = "D5", IsTaken = false }
};

var cinema2 = new Cinema(2, "Cinema 2");

cinema2.CinemaSeats = new List<CinemaSeat>()
{
    new CinemaSeat() { Id = 1, SeatNumber = "A1", IsTaken = false },
    new CinemaSeat() { Id = 2, SeatNumber = "A2", IsTaken = false },
    new CinemaSeat() { Id = 3, SeatNumber = "A3", IsTaken = false },
    new CinemaSeat() { Id = 4, SeatNumber = "A4", IsTaken = false },
    new CinemaSeat() { Id = 5, SeatNumber = "A5", IsTaken = false },
    new CinemaSeat() { Id = 6, SeatNumber = "B1", IsTaken = false },
    new CinemaSeat() { Id = 7, SeatNumber = "B2", IsTaken = false },
    new CinemaSeat() { Id = 8, SeatNumber = "B3", IsTaken = false },
    new CinemaSeat() { Id = 9, SeatNumber = "B4", IsTaken = false },
    new CinemaSeat() { Id = 10, SeatNumber = "B5", IsTaken = false },
    new CinemaSeat() { Id = 11, SeatNumber = "C1", IsTaken = false },
    new CinemaSeat() { Id = 12, SeatNumber = "C2", IsTaken = false },
    new CinemaSeat() { Id = 13, SeatNumber = "C3", IsTaken = false },
    new CinemaSeat() { Id = 14, SeatNumber = "C4", IsTaken = false },
    new CinemaSeat() { Id = 15, SeatNumber = "C5", IsTaken = false },
    new CinemaSeat() { Id = 16, SeatNumber = "D1", IsTaken = false },
    new CinemaSeat() { Id = 17, SeatNumber = "D2", IsTaken = false },
    new CinemaSeat() { Id = 18, SeatNumber = "D3", IsTaken = false },
    new CinemaSeat() { Id = 19, SeatNumber = "D4", IsTaken = false },
    new CinemaSeat() { Id = 20, SeatNumber = "D5", IsTaken = false }
};

kccCinemas = new List<Cinema>();
kccCinemas.Add(cinema1);
kccCinemas.Add(cinema2);

Console.WriteLine("Welcome to KCC Cinema Booking System!");
Console.WriteLine("\n\n*****Press Y to begin.*****\n\n");

var inputBegin = Console.ReadLine();

if (inputBegin.ToLower() == "y")
{
    Console.WriteLine("\n\nWhich cinema would you like to book a seat on?\n");
    Console.WriteLine("\nThese are the following options:\n\n");
    foreach(var cinema in kccCinemas)
    {
        Console.WriteLine($"{cinema.Id}. {cinema.Name}");
    }

    var inputCinema = Console.ReadLine();

    var selectedCinema = kccCinemas.FirstOrDefault(cinema => cinema.Id.ToString() == inputCinema);

    if (selectedCinema == null)
    {
        Console.WriteLine("\n\n***Invalid Cinema Input***\n");
    }
    else
    {
        Console.WriteLine($"\n\n****Welcome to {selectedCinema.Name}!*****\n");
        SelectCinemaSeat(selectedCinema);
    }


    //switch (inputCinema)
    //{
    //    case "1":
    //        Console.WriteLine("\n\n****Welcome to Cinema 1!*****\n");
    //        break;
    //    case "2":
    //        Console.WriteLine("\n\n****Welcome to Cinema 2!*****\n");
    //        break;
    //    default:
    //        Console.WriteLine("\n\n***Invalid Cinema Input***\n");
    //        break;
    //}


    //if (inputCinema == "1")
    //{
    //    Console.WriteLine("\n\n****Welcome to Cinema 1!*****\n");
    //}
    //else if (inputCinema == "2")
    //{
    //    Console.WriteLine("\n\n****Welcome to Cinema 2!*****\n");
    //}
    //else
    //{
    //    Console.WriteLine("\n\n***Invalid Cinema Input***\n");
    //}

}

void SelectCinemaSeat(Cinema selectedCinema)
{
    Console.WriteLine($"\nHere are the seats availability in {selectedCinema.Name}:\n");

    foreach (var seat in selectedCinema.CinemaSeats)
    {
        Console.WriteLine($"{seat.SeatNumber} - {(seat.IsTaken ? "This seat is already taken." : "Vacant")}");
    }

    Console.Write($"\nPlease select the seat: \n");
    var inputCinemaSeat = Console.ReadLine();

    var selectedSeat = selectedCinema.CinemaSeats.FirstOrDefault(seat => seat.SeatNumber == inputCinemaSeat);

    if (selectedSeat == null)
    {
        Console.Write($"\nYou have entered an invalid seat. Press any  key to select another seat or N to exit.\n");
        SelectAnotherSeat(selectedCinema);
    }
    else
    {
        if (selectedSeat.IsTaken)
        {
            Console.WriteLine("\nSorry, this seat is already taken. Press any key to select another seat or N to exit.");
            SelectAnotherSeat(selectedCinema);
        }
        else
        {
            Console.WriteLine($"\nCongratulations! You have booked the seat number {selectedSeat.SeatNumber} on {selectedCinema.Name}. Enjoy the movie! Press any key to book another seat or N to exit.");
            selectedSeat.IsTaken = true;
            SelectAnotherSeat(selectedCinema);
        }

    }
}

void SelectAnotherSeat(Cinema selectedCinema)
{
    var anotherSeat = Console.ReadLine();

    if (anotherSeat.ToLower() == "n")
    {
        return;
    }

    SelectCinemaSeat(selectedCinema);
}

return;