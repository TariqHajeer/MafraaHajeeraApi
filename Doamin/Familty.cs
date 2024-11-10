using MafraaHajeeraApi.Doamin;

public class Family
{
    public string Id { get; set; }
    public int CurrentRegionId { get; set; }
    public Region CurrentRegion { get; set; }
    public string CurrentRegionDetails { get; set; }
    public int OldRegionId { get; set; }
    public Region OldRegion { get; set; }
    public string OldRegionDetails { get; set; }
    public HosunigTypeEnum HosunigType { get; set; }
    public decimal? RentCost { get; set; }
    public string Sponser { get; set; }
    public string OtherAssistance { get; set; }
    public string WhoSpend { get; set; }
    public string Dept { get; set; }
    public string[] Priorities { get; set; }
    public string Note { get; set; }
    public string[] Committee { get; set; }
    public DateTime CreatedDate { get; set; }
    public int? MotherId { get; set; }
    public Mother Mother { get; set; }
    public int FatherId { get; set; }
    public Father Father { get; set; }
    public List<Child> children { get; set; }

}