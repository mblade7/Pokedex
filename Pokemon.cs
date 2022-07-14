using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

public enum Type
{
    Normal, Fire, Water, Grass, Electric, Ice, Fighting, Poison, Ground, Flying, Psychic, Bug, Rock, Ghost, Dragon
}
public class Pokemon
{
    [Key]
    public int DexNum { get; set; }
    public string Name { get; set; }
    [DisplayName("Japanese Name")]
    public string Japanese_Name { get; set; }
    
    public string Type1 { get; set; }
    public string? Type2 { get; set; }
    [DisplayName("Base HP")]
    public int Base_HP { get; set; }
    [DisplayName("Base Attack")]
    public int Base_ATK { get; set; }
    [DisplayName("Base Defense")]
    public int Base_DEF { get; set; }
    [DisplayName("Base Special")]
    public int Base_SPC { get; set; }
    [DisplayName("Base Speed")]
    public int Base_SPD { get; set; }
    [DisplayName("Catch Rate")]
    public int Catch_Rate { get; set; }
    [DisplayName("Dex Entry (Red&Blue)")]
    public string RedBlueDex { get; set; }
    [DisplayName("Dex Entry (Yellow)")]
    public string YellowDex { get; set; }
}
