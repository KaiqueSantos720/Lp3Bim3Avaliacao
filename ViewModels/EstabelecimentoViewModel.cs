namespace AvaliacaoLp3Bim3.ViewModels;

public class EstabelecimentoViewModel
{
    public int? Id { get; set; }
    public string? Nome { get; set; }
    public string? Piso { get; set; }
    public string? Descricao { get; set; }
    public string? LojaKiosque { get; set; }
    public string? Email { get; set; }

    public EstabelecimentoViewModel(int id, string nome, string piso, string descricao, string lojaKiosque, string email)
    {
        Id = id;
        Nome = nome;
        Piso = piso;
        Descricao = descricao;
        LojaKiosque = lojaKiosque;
        Email = email;
    }

    public EstabelecimentoViewModel()
    {
        
    }

}