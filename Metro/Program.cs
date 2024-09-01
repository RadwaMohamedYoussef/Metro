using Metro.Context;
using Metro.Enums;
using Metro.Models;
using Microsoft.EntityFrameworkCore;

namespace Metro
{
    internal class Program
    {
        //before Database Requirement

        //  static void Main(string[] args)
        //  {
        //      var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
        //      optionsBuilder.UseSqlite(@"Data Source=C:\Users\DELL\Desktop\Metro\Metro\DbFile\metro.db");


        //      Console.WriteLine("Welcome to Cairo Metro Ticketing System!");

        //      Console.WriteLine("Line 1 Stations:");

        //      foreach (int i in Enum.GetValues(typeof(Line1Stations)))
        //      {
        //          Console.WriteLine($"{i}- {Enum.GetName(typeof(Line1Stations), i)}");
        //      }
        //      int StartStationNumber, DestinationStationNumber;

        //      while (true)
        //      {
        //           StartStationNumber = GetValidStationNumber("Please Enter the Number of the Station You are Starting From:");

        //           DestinationStationNumber = GetValidStationNumber("Please Enter the Number of the Station You are Going to:");

        //          if (StartStationNumber == DestinationStationNumber)
        //          {
        //              Console.WriteLine("The Starting and Destination Stations Cannot be the Same. Please Re-enter the Stations.");
        //          }
        //          else
        //          {
        //              break;
        //          }
        //      }
        //      int numberOfStations = Math.Abs(DestinationStationNumber - StartStationNumber);
        //      int ticketPrice = CalculateTicketPrice(numberOfStations);

        //      Console.WriteLine($"The Price of the Ticket from {(Line1Stations)StartStationNumber}" +
        //          $" to {(Line1Stations)DestinationStationNumber} is {ticketPrice} EGP.");

        //      Console.WriteLine("Thank you for Using Cairo Metro Ticketing System!");
        //  }
        //public static int GetValidStationNumber(string EnterdFromUser)
        //  {
        //      int StationNumber;
        //      while (true)
        //      {
        //          Console.WriteLine(EnterdFromUser);
        //          if (int.TryParse(Console.ReadLine(), out StationNumber) && Enum.IsDefined(typeof(Line1Stations), StationNumber))
        //          {
        //              break;
        //          }
        //          Console.WriteLine("Invalid Station Number Entered. Please Enter a Valid Number From the List.");
        //      }
        //      return StationNumber;
        //  }
        //  public static int CalculateTicketPrice(int NumberOfStations)
        //  {

        //      if (NumberOfStations <= 9)
        //      {
        //          return 8; 
        //      }
        //      else if (NumberOfStations <= 16)
        //      {
        //          return 10;
        //      }

        //      else
        //      {
        //          return 15;
        //      }
        //  }

        static void Main(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseSqlite(@"Data Source=C:\Users\DELL\Desktop\Metro\Metro\DbFile\metro.db");
            ApplicationDbContext context = new ApplicationDbContext();

            Console.WriteLine("Welcome to Cairo Metro Ticketing System!");

                while (true)
                {
                    var stations = context.Line1Stations.ToList();

                    Console.WriteLine("Line 1 Stations:");

                    foreach (var station in stations)
                    {
                        Console.WriteLine($"{station.Id}- {station.StationName}");
                    }

                    int StartStationNumber, DestinationStationNumber;

                    while (true)
                    {
                        StartStationNumber = GetValidStationNumber("Please Enter the Number of the Station You are Starting From:", stations);
                        DestinationStationNumber = GetValidStationNumber("Please Enter the Number of the Station You are Going to:", stations);

                        if (StartStationNumber == DestinationStationNumber)
                        {
                            Console.WriteLine("The Starting and Destination Stations Cannot be the Same. Please Re-enter the Stations.");
                        }
                        else
                        {
                            break;
                        }
                    }

                    int numberOfStations = Math.Abs(DestinationStationNumber - StartStationNumber);
                    int ticketPrice = CalculateTicketPrice(numberOfStations);

                    Console.WriteLine($"The Price of the Ticket from {stations.First(s => s.Id == StartStationNumber).StationName}" +
                                      $" to {stations.First(s => s.Id == DestinationStationNumber).StationName} is {ticketPrice} EGP.");

                if (!GetValidResponse("Would you like to purchase another ticket? (yes/no)"))
                {
                    break;
                }
            }

                Console.WriteLine("Thank you for Using Cairo Metro Ticketing System!");
            
        }


        public static int GetValidStationNumber(string message, List<Line1Station> stations)
        {
            int stationNumber;
            while (true)
            {
                Console.WriteLine(message);
                if (int.TryParse(Console.ReadLine(), out stationNumber) && stations.Any(s => s.Id == stationNumber))
                {
                    break;
                }
                Console.WriteLine("Invalid Station Number Entered. Please Enter a Valid Number From the List.");
            }
            return stationNumber;
        }

        public static int CalculateTicketPrice(int NumberOfStations)
        {
            if (NumberOfStations <= 9)
            {
                return 8;
            }
            else if (NumberOfStations <= 16)
            {
                return 10;
            }
            else
            {
                return 15;
            }
        }

        public static bool GetValidResponse(string respose)
        {
            while (true)
            {
                Console.WriteLine(respose);
                string response = Console.ReadLine().Trim().ToLower();

                if (response == "yes")
                {
                    return true;
                }
                else if (response == "no")
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("Invalid response. Please enter 'yes' or 'no'.");
                }
            }
        }

    }
}
