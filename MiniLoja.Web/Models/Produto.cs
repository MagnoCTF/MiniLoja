public class Produto
{
    public int Id { get; set; }
    public string Nome { get; set; } = "";
    public decimal Preco { get; set; }

    public decimal PrecoComDesconto(decimal percentual)
        => Preco - (Preco * percentual / 100);
}