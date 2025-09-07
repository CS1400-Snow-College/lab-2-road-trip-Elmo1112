// See https://aka.ms/new-console-template for more information

Console.WriteLine("We are going to map out a road trip for Fall Break.");
Console.Write("Who will be driving? ");
string driver = Console.ReadLine();

Console.Write("Where will you be driving? ");
string destination = Console.ReadLine();

Console.Write("How many miles to get to " + destination + "? ");
int miles = Convert.ToInt32(Console.ReadLine());

Console.Write("What average speed (MPH) will " + driver + " be travelling? ");
int speed = Convert.ToInt32(Console.ReadLine());

Console.Write("How many MPG does your car get? ");
int mpg = Convert.ToInt32(Console.ReadLine());

Console.Write("How many gallons of gas does your car hold? ");
int tank = Convert.ToInt32(Console.ReadLine());

Console.Write("Excluding the driver, how many riders in the car? ");
int riders = Convert.ToInt32(Console.ReadLine());

Console.Write("What is the fuel price per gallon? ");
double pricePerGallon = Convert.ToDouble(Console.ReadLine());
int roundTripMiles = miles * 2;
double timeHours = (double)miles / speed;
int hours = (int)timeHours;
int minutes = (int)((timeHours - hours) * 60);

double fuelNeeded = (double)roundTripMiles / mpg;
double range = tank * mpg;
int fuelStops = (int)Math.Ceiling(fuelNeeded / tank) - 1;

double fuelCost = fuelNeeded * pricePerGallon;
double costPerPerson = fuelCost / (riders + 1);

Console.WriteLine("\nDriver: " + driver);
Console.WriteLine("Distance (miles): " + miles);
Console.WriteLine("Average Speed (mph): " + speed);
Console.WriteLine("Time Driving: " + hours + "H " + minutes + "M");
Console.WriteLine("\nVehicle Miles per Gallon: " + mpg);
Console.WriteLine("Fuel Needed (round trip): " + fuelNeeded.ToString("F2") + " gallons");
Console.WriteLine("Range per tank: " + range.ToString("F2"));
Console.WriteLine("Estimated Fuel Stops: " + fuelStops);
Console.WriteLine("\nGas Price per gallon: " + pricePerGallon.ToString("F2"));
Console.WriteLine("Fuel Cost: " + fuelCost.ToString("F2"));
Console.WriteLine("Riders (split): " + riders);
Console.WriteLine("Cost per person: " + costPerPerson.ToString("F2"));

