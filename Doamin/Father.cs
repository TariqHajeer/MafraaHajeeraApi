using MafraaHajeeraApi.Doamin;
using Microsoft.AspNetCore.SignalR.Protocol;
public class Father
{
    public int Id { get; set; }
    public string PersonalId{ get;set;}
    public string Name { get; set; }
    public string FatherName { get; set; }
    public string MotherName { get; set; }
    public string BirthPalce { get; set; }
    public DateTime BirthDate { get; set; }
    public string HealthStatus { get; set; }
    public string RegistrationNumberAndField { get; set; }
    public string PrevousWork { get; set; }
    public decimal? MonthlyIncome { get; set; }
    public string EducationLevel { get; set; }
    public DateTime? DeathDate { get; set; }
}