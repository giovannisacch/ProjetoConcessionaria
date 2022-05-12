using Microsoft.AspNetCore.Mvc;
using ProjetoConcessionaria.Models;

namespace ProjetoConcessionaria.API.Controllers;

[ApiController]
[Route("[controller]")]

public class PessoaController : ControllerBase
{
    public static List<Pessoa> PessoasDaClasse { get; set; } = new List<Pessoa>();

    [HttpPost("SetPessoa")]
    public IActionResult SetPessoa(Pessoa pessoa)
    {
        PessoasDaClasse.Add(pessoa);
        return Ok(PessoasDaClasse);
    }

    [HttpGet("GetPessoa")]
    public IActionResult GetPessoa()
    {
        return Ok(PessoasDaClasse);
    }

    [HttpDelete("DeletePessoa")]
    public IActionResult DeletePessoa()
    {
        var index = PessoasDaClasse.Count();
        if (index != 0)
        {
            PessoasDaClasse.RemoveAt(index - 1);
            return Ok(PessoasDaClasse);
        }
        return BadRequest("Essa lista está vazia");
    }
}