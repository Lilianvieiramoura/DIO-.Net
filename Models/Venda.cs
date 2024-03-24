namespace ExplorandoLinguagem.Models;

public class Venda
{
  public int Id { get; set; }
  public string Produto { get; set; }
  public decimal Preco { get; set; }
  public DateTime DataVenda { get; set; }
}