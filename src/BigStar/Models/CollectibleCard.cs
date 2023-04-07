namespace BigStar.Models
{
  public class CollectibleCard 
  {
    public int Id {get; set;}  
    public string CardName {get; set;} = String.Empty;
    public decimal OriginalPrice { get; set; }
    public decimal AskingPrice { get; set; }
    public string ImageUri { get; set; } = String.Empty;
    public string Condition { get; set; } = String.Empty;
    public bool LimitedEdition { get; set; }
  }
}