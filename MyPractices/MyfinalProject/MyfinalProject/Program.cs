
//Alexander José López Almonte
//Proyecto: Control de Vehículos de una Empresa
//Descripción: Aplicación en consola para registrar vehículos, conductores y mantenimientos. Permite CRUD de vehículos y seguimiento de revisiones. Clases sugeridas: Vehiculo, Conductor, Mantenimiento.



//Modelos
class Vehiculo
{
    public string Placa { get; set; }
    public string Marca { get; set; }
    public string Modelo { get; set; }

    public Vehiculo(string placa, string marca, string modelo)
    {
        Placa = placa;
        Marca = marca;
        Modelo = modelo;
    }
