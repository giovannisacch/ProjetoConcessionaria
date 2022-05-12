using Microsoft.AspNetCore.Mvc;
using ProjetoConcessionaria.Models;

namespace ProjetoConcessionaria.API.Controllers;

[ApiController]
[Route("[controller]")]

public class FuncionarioController : ControllerBase
{
    public static List<Funcionario> FuncionariosDaClasse { get; set; } = new List<Funcionario>();

    [HttpPost("SetFuncionario")]
    public IActionResult SetFuncionario(Funcionario funcionario)
    {
        FuncionariosDaClasse.Add(funcionario);
        return Ok(FuncionariosDaClasse);
    }

    [HttpGet("GetFuncionario")]
    public IActionResult GetFuncionario()
    {
        return Ok(FuncionariosDaClasse);
    }

    [HttpDelete("DeleteFuncionario")]
    public IActionResult DeleteFuncionario()
    {
        var index = FuncionariosDaClasse.Count();
        if (index != 0)
        {
            FuncionariosDaClasse.RemoveAt(index - 1);
            return Ok(FuncionariosDaClasse);
        }
        return BadRequest("Essa lista está vazia");
    }
}