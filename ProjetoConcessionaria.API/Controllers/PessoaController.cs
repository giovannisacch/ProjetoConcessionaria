using Microsoft.AspNetCore.Mvc;
using ProjetoConcessionaria.Models;
using ProjetoConcessionaria.Console.Exception;
using ProjetoConcessionaria.API.DTOs;


namespace ProjetoConcessionaria.API.Controllers;

[ApiController]
[Route("[controller]")]

public class PessoaController : ControllerBase
{
    public static List<PessoaDto> PessoasDaClasse { get; set; } = new List<PessoaDto>();

    [HttpPost("SetPessoa")]
    public IActionResult SetPessoa(PessoaDto pessoaDto)
    {
        try
        {
            var pessoa = new Pessoa(pessoaDto.Nome, pessoaDto.Cpf, pessoaDto.DataNascimento.ToString("yyyy"));
            PessoasDaClasse.Add(pessoaDto);
            return Ok(PessoasDaClasse);
        }
        catch (ErroDeValidacaoException ex)
        {
            return BadRequest(ex.Message);
        }
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