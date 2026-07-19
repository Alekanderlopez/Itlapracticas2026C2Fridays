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