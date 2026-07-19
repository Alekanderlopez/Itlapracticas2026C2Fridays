
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