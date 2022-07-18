using System.ComponentModel;

public class Moves
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Type { get; set; }
    public int Power { get; set; }
    [DisplayName("Starting PP")]
    public int StartPP { get; set; }
    public int Accuracy { get; set; }
    public string? Effect { get; set; }
}
