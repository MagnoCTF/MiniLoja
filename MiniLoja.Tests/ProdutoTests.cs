public class ProdutoTests
{
    [Fact]
    public void Desconto_de_10_por_cento_em_100_resulta_em_90()
    {
        var p = new Produto { Nome = "Camisa", Preco = 100 };
        Assert.Equal(91, p.PrecoComDesconto(10));
    }

    [Fact]
    public void Desconto_zero_mantem_o_preco()
    {
        var p = new Produto { Nome = "Camisa", Preco = 50 };
        Assert.Equal(50, p.PrecoComDesconto(0));
    }
}