using System.ComponentModel.DataAnnotations;

public class Pokemon
{
    [Key]
    public int DexNum { get; set; }
    public string Name { get; set; }
    public string Japanese_Name { get; set; }
    public string Type1 { get; set; }
    public string? Type2 { get; set; }
    public int Base_HP { get; set; }
    public int Base_ATK { get; set; }
    public int Base_DEF { get; set; }
    public int Base_SPC { get; set; }
    public int Base_SPD { get; set; }

}
