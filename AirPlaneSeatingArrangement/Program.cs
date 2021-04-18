using System;

namespace AirPlaneSeatingArrangement
{
    public class Passenger
    {
        public string FirstName;
        public string LastName;

        public Passenger(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FullName
        {
            get
            {
                return $"{LastName}, {FirstName}";
            }
        }
    }
    public static class Seats
    {
        public static int row = 3;
        public static int col = 8;
        public static string[,] seats = new string[row, col];

        static Seats()
        {
            for (int i = 0; i < row * col; i++)
            {
                /*Console.WriteLine($"{i}/{row} = {i/row}");
                Console.WriteLine($"{i}%{col} = {i % col}");*/
                seats[i % row, i / row] = "O";
            }
        }

        public static string MapCol(int pos)
        {
            switch (pos)
            {
                case 0:
                    return $"A";
                case 1:
                    return $"B";
                case 2:
                    return $"C";
                case 3:
                    return $"D";
                case 4:
                    return $"E";
                case 5:
                    return $"F";
                case 6:
                    return $"G";
                case 7:
                    return $"H";
            }
            return "Invalid";
        }
    }
    public class SeatBooking
    {
        public Passenger _passenger;
        public int _withPassenger;

        public SeatBooking(Passenger passenger, int withPassenger)
        {
            _passenger = passenger;
            _withPassenger = withPassenger;
        }

        public void PrintSeats()
        {
            if(_withPassenger==1)
            Console.WriteLine(SeatFor1());
            else if(_withPassenger==2)
                Console.WriteLine(SeatsFor2());
            else if(_withPassenger==3)
                Console.WriteLine(SeatsFor3());
            else if(_withPassenger==4)
                Console.WriteLine(SeatsFor4());
            else
                Console.WriteLine("Invalid group");
        }
        public string SeatFor1()
        {
            string seat="";
            for(int i = 0; i < Seats.row; i++)
            {
                for(int j = 0; j < Seats.col; j++)
                {
                    if (Seats.seats[i, j] == "O")
                    {
                        Seats.seats[i, j] = "X";
                        seat = $"{i + 1}{Seats.MapCol(j)}";
                        break;
                    }
                }
                if (seat != "")
                {
                    break;
                }
            }
            return seat;
        }
        public string SeatsFor3()
        {
            string seat = "";
            for (int i = 0; i < 3; i++)
            {
                if ((Seats.seats[i, 2] == "O" && Seats.seats[i, 3] == "O" &&
                    Seats.seats[i, 4] == "O"))
                {
                    seat = $"{i + 1}C, {i + 1}D, {i + 1}E";
                    Seats.seats[i, 2] = "X";
                    Seats.seats[i, 3] = "X";
                    Seats.seats[i, 4] = "X";
                    break;
                }
                if((Seats.seats[i, 3] == "O" && Seats.seats[i, 4] == "O" &&
                    Seats.seats[i, 5] == "O"))
                {
                    seat = $"{i + 1}D, {i + 1}E, {i + 1}F";
                    Seats.seats[i, 3] = "X";
                    Seats.seats[i, 4] = "X";
                    Seats.seats[i, 5] = "X";
                    break;
                }
            }            
            return seat;
        }
        public string SeatsFor4()
        {
            string seat = "";
            for (int i = 0; i < 3; i++) {
                if (Seats.seats[i,2]=="O" && Seats.seats[i, 3] == "O" && 
                    Seats.seats[i, 4] == "O" && Seats.seats[i, 5] == "O")
                {
                    seat = $"{i + 1}C, {i + 1}D, {i + 1}E, {i + 1}F";
                    Seats.seats[i, 2] = "X";
                    Seats.seats[i, 3] = "X";
                    Seats.seats[i, 4] = "X";
                    Seats.seats[i, 5] = "X";
                    break;
                }
            }
            if (seat == "")
            {
                seat = SeatsFor2()+", "+SeatsFor2();
            }
            return seat;
        }
        public string SeatsFor2()
        {
            string seat = "";
            for (int i = 0; i < Seats.row; i++)
            {
                for (int j = 0; j < Seats.col; j++)
                {
                    if (Seats.seats[i, 0] == "O" && Seats.seats[i, 1] == "O")
                    {
                        seat = $"{i+1}A, {i+1}B";
                        Seats.seats[i, 0] = "X";
                        Seats.seats[i, 1] = "X";
                        break;
                    }
                    else if (Seats.seats[i, 6] == "O" && Seats.seats[i, 7] == "O")
                    {
                        seat = $"{i+1}G, {i+1}H";
                        Seats.seats[i, 6] = "X";
                        Seats.seats[i, 7] = "X";
                        break;
                    }
                    else
                    {
                        if (Seats.seats[i, j] == "O" && Seats.seats[i, j + 1] == "O" && i > 1 && j < 6)
                        {
                            seat =$"{ i+1} {Seats.MapCol(j)}, {i+1}{Seats.MapCol(j+1)}";
                            Seats.seats[i, j] = "X";
                            Seats.seats[i, j+1] = "X";
                            break;
                        }
                    }
                }
                if (seat != "")
                {
                    break;
                }
            }
            return seat;
        }

        public class Program
        {
            static void Main(string[] args)
            {
                // Seats s = new Seats();
                string val = "y";
                do
                {
                    Console.WriteLine("Passenger First Name: ");
                    string fname = Console.ReadLine();
                    Console.WriteLine("Passenger Last Name: ");
                    string lname = Console.ReadLine();
                    Console.WriteLine($"No of passengers ");
                    int n = (Int32.Parse(Console.ReadLine()));
                    SeatBooking sb = new SeatBooking(new Passenger(fname, lname), n);
                    Console.WriteLine($"Printing tickets for Mr/Ms {sb._passenger.FullName}");
                    sb.PrintSeats();
                    Console.WriteLine("Wanna book more tickets?say y or n");
                    val = Console.ReadLine();
                }
                while (val == "y");
            }
        }
    }
}
