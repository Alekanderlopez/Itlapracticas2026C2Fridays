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