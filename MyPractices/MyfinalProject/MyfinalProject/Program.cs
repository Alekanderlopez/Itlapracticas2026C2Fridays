
//Alexander José López Almonte
//Proyecto: Control de Vehículos de una Empresa
//Descripción: Aplicación en consola para registrar vehículos, conductores y mantenimientos. Permite CRUD de vehículos y seguimiento de revisiones. Clases sugeridas: Vehiculo, Conductor, Mantenimiento.
using Microsoft.Data.SqlClient;



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



int option;
{
    do
    {
        Console.WriteLine("\n VEHICLE CONTROL SYSTEM");
        Console.WriteLine("1. Register Vehicle");
        Console.WriteLine("2. Show Vehicles");
        Console.WriteLine("3. Register Maintenance");
        Console.WriteLine("4. Exit");

        option = Convert.ToInt32(Console.ReadLine());

        switch (option)
        {
            case 1:
                Console.WriteLine("Register Vehicle");
                break;

            case 2:
                Console.WriteLine("Show Vehicles");
                break;

            case 3:
                Console.WriteLine("Register Maintenance");
                break;
        }

    } while (option != 4);
}



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

    public Maintenance(int id, string vehicleLicensePlate, DateTime date, string description)
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
        @"Server=.\SQLEXPRESS;Database=VehicleManagement;Trusted_Connection=True;TrustServerCertificate=True;";

    public SqlConnection GetConnection()
    {
        return new SqlConnection(connectionString);
    }
}

