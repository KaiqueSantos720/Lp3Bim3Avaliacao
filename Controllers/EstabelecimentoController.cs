using Microsoft.AspNetCore.Mvc;
using AvaliacaoLp3Bim3.ViewModels;

namespace AvaliacaoLp3Bim3.Controllers;

public class EstabelecimentoController : Controller
{
    private static List<EstabelecimentoViewModel> estabelecimentos = new List<EstabelecimentoViewModel>(); 

    public IActionResult Index()
    {
        return View(estabelecimentos);
    }

    public IActionResult Gerenciamento()
    {
        return View(estabelecimentos);
    }

    public IActionResult Show(int id)
    {
        // foreach com intuito de deixar dinâmico, visto que os índices da lista também são dinâmicos
        foreach(var estabelecimento in estabelecimentos)
        {
            if(estabelecimento.Id == id)
            {
                return View(estabelecimento);
            }
        }

        // valor default de retorno
        return View(estabelecimentos[0]);
    }

    public IActionResult CadastrarEstabelecimento()
    {
        return View();
    }

    public IActionResult Adicionar(EstabelecimentoViewModel viewModel)
    {
        foreach(var estabelecimento in estabelecimentos)
        {
            //não permite o cadastro de estabelecimentos com mesmo nome ou id, fazendo com que só haja o redirecionamento, sem a criação de uma nova loja
            if(estabelecimento.Nome == viewModel.Nome || estabelecimento.Id == viewModel.Id)
            {
                return RedirectToAction("Gerenciamento");
            }
        }

        estabelecimentos.Add(viewModel);
        return RedirectToAction("Gerenciamento");
    }

    public IActionResult Excluir(int id)
    {
        foreach(var estabelecimento in estabelecimentos.ToList())
        {
            if(estabelecimento.Id == id)
            {
                estabelecimentos.Remove(estabelecimento);
            }
        }
        return RedirectToAction("Gerenciamento");
    }
}