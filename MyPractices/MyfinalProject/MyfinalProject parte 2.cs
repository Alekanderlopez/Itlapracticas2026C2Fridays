// Alexander Jose Lopez Almonte
// Project: Company Vehicle Control
// Description: Console application to register vehicles, drivers,
// and maintenance records.

using Microsoft.Data.SqlClient;
using System.Collections.Generic;

try
{
    string connectionString =
        @"Server=localhost;Database=VehicleManagement;Trusted_Connection=True;TrustServerCertificate=True;";

    SqlConnection connection = new SqlConnection(connectionString);

    connection.Open();

    Console.WriteLine("Connected successfully!");

    connection.Close();
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

// Lists
List<Vehicle> vehicles = new();
List<Maintenance> maintenances = new();

int option;

do
{
    Console.Clear();

    Console.WriteLine("=== VEHICLE CONTROL SYSTEM ===");
    Console.WriteLine("1. Register Vehicle");
    Console.WriteLine("2. Show Vehicles");
    Console.WriteLine("3. Register Maintenance");
    Console.WriteLine("4. Exit");

    Console.Write("\nSelect an option: ");
    option = Convert.ToInt32(Console.ReadLine());

    switch (option)
    {
        case 1:

            Console.Write("License Plate: ");
            string plate = Console.ReadLine();

            Console.Write("Brand: ");
            string brand = Console.ReadLine();

            Console.Write("Model: ");
            string model = Console.ReadLine();

            Vehicle vehicle = new Vehicle(plate, brand, model);

            vehicles.Add(vehicle);

            Console.WriteLine("\nVehicle registered successfully!");
            Console.ReadKey();

            break;

        case 2:

            Console.WriteLine("\n=== VEHICLE LIST ===");

            if (vehicles.Count == 0)
            {
                Console.WriteLine("No vehicles registered.");
            }
            else
            {
                foreach (Vehicle v in vehicles)
                {
                    Console.WriteLine($"License Plate: {v.LicensePlate}");
                    Console.WriteLine($"Brand: {v.Brand}");
                    Console.WriteLine($"Model: {v.Model}");
                }
            }

            Console.ReadKey();

            break;

        case 3:

            Console.Write("Maintenance ID: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Vehicle License Plate: ");
            string vehiclePlate = Console.ReadLine();

            Console.Write("Description: ");
            string description = Console.ReadLine();

            Maintenance maintenance =
                new Maintenance(
                    id,
                    vehiclePlate,
                    DateTime.Now,
                    description);

            maintenances.Add(maintenance);

            Console.WriteLine("\nMaintenance registered successfully!");
            Console.ReadKey();

            break;

        case 4:

            Console.WriteLine("Goodbye!");
            break;

        default:

            Console.WriteLine("Invalid option.");
            Console.ReadKey();

            break;
    }

} while (option != 4);

// Vehicle Class
class Vehicle
{
    public string LicensePlate { get; set; }
    public string Brand { get; set; }
    public string Model { get; set; }
    public Vehicle(string licensePlate, string brand, string model)
    {
        LicensePlate = licensePlate;
        Brand = brand;
        Model = model;
    }
}

// Driver Class
class Driver
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string LicenseNumber { get; set; }

    public Driver(int id, string name, string licenseNumber)
    {
        Id = id;
        Name = name;
        LicenseNumber = licenseNumber;
    }
}

class Maintenance
{
    public int Id { get; set; }
    public string VehicleLicensePlate { get; set; }
    public DateTime Date { get; set; }
    public string Description { get; set; }

    public Maintenance(int id, string vehicleLicensePlate,
        DateTime date, string description)
    {
        Id = id;
        VehicleLicensePlate = vehicleLicensePlate;
        Date = date;
        Description = description;
    }
}

public class DatabaseConnection
{
    private string connectionString =
        @"Server=localhost;Database=VehicleManagement;Trusted_Connection=True;TrustServerCertificate=True;";

    public SqlConnection GetConnection()
    {
        return new SqlConnection(connectionString);
    }
}