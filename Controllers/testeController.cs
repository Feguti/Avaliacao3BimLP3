using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AvaliacaoLP3_3BIM.ViewModels;
using AvaliacaoLP3_3BIM.Models;

namespace AvaliacaoLP3_3BIM.Controllers;

public class testeController : Controller
{
    private static List<LojasViewModel> lojas = new List<LojasViewModel>{
        new LojasViewModel(32, "Piso 3", "Tênis Brasil", "Aqui tem tênis", "Loja", "tenis@email.com"),
        new LojasViewModel(33, "Piso 3", "Lembranças já", "Lembranças uhul", "Kiosque", "lemb@email.com"),
        new LojasViewModel(12, "Piso 1", "Sorvetinho Gelado", "Sorvetes não quentes", "Kiosque", "sorvet@email.com"),
        new LojasViewModel(24, "Piso 2", "Saraivada", "Uma tempestade de livros", "Loja", "livros@email.com"),
        new LojasViewModel(29, "Piso 2", "Mitsue lanches", "Cantina do IFSP no shopping!!!", "Kiosque", "lanche@email.com"),
    };

    public IActionResult Loja()
    {
        return View();
    }

    public IActionResult Administracao()
    {
        return View();
    }

    public IActionResult CadastrarLoja([FromForm] int id, [FromForm] string piso, [FromForm] string nome, [FromForm] string descricao, [FromForm] string tipoLoja, [FromForm] string email )
    {
        lojas.Add(new LojasViewModel(id, piso, nome, descricao, tipoLoja, email));
        return View("Administracao");
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }


}