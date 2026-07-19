
//Alexander José López Almonte
//Proyecto: Control de Vehículos de una Empresa
//Descripción: Aplicación en consola para registrar vehículos, conductores y mantenimientos. Permite CRUD de vehículos y seguimiento de revisiones. Clases sugeridas: Vehiculo, Conductor, Mantenimiento.
using Microsoft.Data.SqlClient;


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