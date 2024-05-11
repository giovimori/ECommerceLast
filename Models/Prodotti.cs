using System.ComponentModel.DataAnnotations;

namespace basilico.karol._5h.Ecommerce.Models;

public class Prodotti
{
    public Prodotti()
    {
    
    }

    [Key]
    public int? NomeP { get; set; }
    public string? Descrizione { get; set; }
    public string? Prezzo { get; set; }
    
}