namespace MafraaHajeeraApi.Doamin;
public class Child
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string FatherName { get; set; }
    public string MotherName { get; set; }
    public PersonalStatEnum PersonalStatEnum { get; set; }
    public string Work { get; set; }
    public decimal? MonthlyIncom { get; set; }
    public string HealthStatus { get; set; }

}