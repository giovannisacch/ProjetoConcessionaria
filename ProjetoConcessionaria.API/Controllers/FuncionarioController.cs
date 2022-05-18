using Microsoft.AspNetCore.Mvc;
using ProjetoConcessionaria.Models;
using ProjetoConcessionaria.Console.Exception;
using ProjetoConcessionaria.API.DTOs;

namespace ProjetoConcessionaria.API.Controllers;

[ApiController]
[Route("[controller]")]

public class FuncionarioController : ControllerBase
{
    public static List<FuncionarioDto> FuncionariosDaClasse { get; set; } = new List<FuncionarioDto>();

    [HttpPost("SetFuncionario")]
    public IActionResult SetFuncionario(FuncionarioDto funcionarioDto)
    {
        try{
        var funcionario = new Funcionario(funcionarioDto.Nome, funcionarioDto.Cpf, funcionarioDto.DataNascimento.ToString("yyyy"), funcionarioDto.Cargo);
        FuncionariosDaClasse.Add(funcionarioDto);
        return Ok(FuncionariosDaClasse);
        }
        catch(ErroDeValidacaoException ex)
        {
            return BadRequest(ex.Message);
        }
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