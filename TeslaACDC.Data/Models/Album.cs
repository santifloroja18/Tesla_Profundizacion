using System;

namespace TeslaACDC.Data.Models;

public class Album : BaseEntity<int>
{
   public string name{get; set;} = String.Empty;
    public int year{get;set;}
    public Genre genre{get;set;} = Genre.Unknown;
    public Artist Artist{get;set;}
}

public enum Genre
{
    Pop,
    Rock,
    Metal,
    Urban,
    Folklore,
    Indie,
    Electronic,
    Tropipop,
    World,
    Lofi,
    Unknown    
}