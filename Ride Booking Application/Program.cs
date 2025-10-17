abstract class Ride
{
    public abstract string RideType();
    public abstract void DisplayInfo();
}
class BikeRide : Ride
{
    public override string RideType() => "Bike RIDe";
    public override void DisplayInfo()
    {
        Console.WriteLine("Bike Ride Successfully! Estimated arrival: 5 minutes. ");
    }
}
class CarRide : Ride
{
    public override string RideType() => "Car Ride";
    public override void DisplayInfo()
    {
        Console.WriteLine("Car Ride booked successfully! Estimated arrival: 10 minutes.");
    }
}
class LuxuryRide : Ride
{
    public override string RideType() => "Luxury Ride";
    public override void DisplayInfo()
    {
        Console.WriteLine("Luxury Ride booked successfully! Estimated arrival: 15 minutes.");
    }
}
abstract class RideFactory
{
    public abstract Ride CreateRide();
}

class BikeRideFactory : RideFactory
{
    public override Ride CreateRide()
    {
               return new BikeRide();
    }
}
class CarRideFactory : RideFactory
{
    public override Ride CreateRide()
    {
        return new CarRide();
    }
}
class LuxuryRideFactory : RideFactory
{
    public override Ride CreateRide()
    {
        return new LuxuryRide();
    }
}
class Program
{ static void Main()
    {
        Console.WriteLine("=== Ride Booking Application ===");
        Console.WriteLine("Choose Ride Type: \n 1. Bike \n 2. Car \n 3. Luxury");
        string choice = Console.ReadLine();

        RideFactory factory = choice switch
        {
            "1" => new BikeRideFactory(),
            "2" => new CarRideFactory(),
            "3" => new LuxuryRideFactory(),
            _ => throw new ArgumentException("Invalid choice")
        };
        Ride ride = factory.CreateRide();
        Console.WriteLine($"You selected: {ride.RideType()}");
        ride.DisplayInfo();

    }
        }