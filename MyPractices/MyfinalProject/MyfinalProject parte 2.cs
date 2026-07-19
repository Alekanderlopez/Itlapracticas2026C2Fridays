/*Alexander José López Almonte
Proyecto: Control de Vehículos de una Empresa
Descripción: Aplicación en consola para registrar vehículos, conductores y mantenimientos. Permite CRUD de vehículos y seguimiento de revisiones. Clases sugeridas: Vehiculo, Conductor, Mantenimiento*/




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
