using Microsoft.AspNetCore.Mvc;
using AvaliacaoLP3_3BIM.Models;
using System.Diagnostics;
using AvaliacaoLP3_3BIM.Controllers;

namespace AvaliacaoLP3_3BIM.ViewModels;

public class LojasViewModel {

    public int Id { get; set; }
    public string Piso { get; set; }
    public string Nome { get; set; }
    public string Descricao { get; set; }
    public string TipoLoja { get; set; }
    public string Email { get; set; }

    public LojasViewModel(int id, string piso, string nome, string descricao, string tipoLoja, string email)
    {
        Id = id;
        Piso = piso;
        Nome = nome;
        Descricao = descricao;
        TipoLoja = tipoLoja;
        Email = email;
    }

}