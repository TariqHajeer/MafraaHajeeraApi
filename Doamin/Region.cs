using System;

namespace MafraaHajeeraApi.Doamin;

public class Region
{
    public int Id {get;set;}
    public string Name{get;set;}
    public int CityId {get;set;}
    public City City{get;set;}
}
