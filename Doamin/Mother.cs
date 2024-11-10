using System.ComponentModel.DataAnnotations;

namespace MafraaHajeeraApi.Doamin;
public class Mother
{
    [Key]
    public string Id { get; set; }
    public string Name { get; set; }
    public string FatherName { get; set; }
    public string MotherName { get; set; }
    public string BirthPalce { get; set; }
    public DateTime BirthDate { get; set; }
    public string RegistrationNumberAndField { get; set; }
    public int NationalityId { get; set; }
    public Nationality Nationality { get; set; }
    public string[] Phones { get; set; }
    public string Work { get; set; }
    public decimal? MonthlyIncome { get; set; }
    public string EducationLevel { get; set; }
    public string WorkThatCanDo { get; set; }
    public string Ambition { get; set; }
    public string HealthStatus { get; set; }
    
}
