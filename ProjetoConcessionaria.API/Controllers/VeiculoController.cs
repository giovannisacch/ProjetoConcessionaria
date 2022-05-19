using Microsoft.AspNetCore.Mvc;
using ProjetoConcessionaria.Lib.Models;
using ProjetoConcessionaria.Lib.Exceptions;
using ProjetoConcessionaria.API.DTOs;

namespace ProjetoConcessionaria.API.Controllers;

[ApiController]
[Route("[controller]")]

public class VeiculoController : ControllerBase
{
    public static List<VeiculoDto> VeiculosDaClasse { get; set; } = new List<VeiculoDto>();

    [HttpPost("SetVeiculo")]
    public IActionResult SetVeiculo(VeiculoDto veiculoDto)
    {
        try
        {
            var veiculo = new Veiculo(veiculoDto.Marca, veiculoDto.Modelo, veiculoDto.Ano.ToString("yyyy"), veiculoDto.Quilometragem, veiculoDto.Cor, veiculoDto.Valor);
            VeiculosDaClasse.Add(veiculoDto);
            return Ok(VeiculosDaClasse);
        }
        catch (ErroDeValidacaoException ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpGet("GetVeiculo")]
    public IActionResult GetVeiculo()
    {
        return Ok(VeiculosDaClasse);
    }

    [HttpDelete("DeleteVeiculo")]
    public IActionResult DeleteVeiculo()
    {
        var index = VeiculosDaClasse.Count();
        if (index != 0)
        {
            VeiculosDaClasse.RemoveAt(index - 1);
            return Ok(VeiculosDaClasse);
        }
        return BadRequest("Essa lista está vazia");
    }
}