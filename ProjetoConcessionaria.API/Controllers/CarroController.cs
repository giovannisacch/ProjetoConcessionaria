using Microsoft.AspNetCore.Mvc;
using ProjetoConcessionaria.Models;
using ProjetoConcessionaria.Console.Exception;
using ProjetoConcessionaria.API.DTOs;

namespace ProjetoConcessionaria.API.Controllers;

[ApiController]
[Route("[controller]")]

public class CarroController : ControllerBase
{
    public static List<CarroDto> CarrosDaClasse { get; set; } = new List<CarroDto>();

    [HttpPost("SetCarro")]
    public IActionResult SetCarro(CarroDto carroDto)
    {
        try
        {
            var carro = new Carro(carroDto.Marca, carroDto.Modelo, carroDto.Ano.ToString("yyyy"), carroDto.Quilometragem, carroDto.Cor, carroDto.Valor, carroDto.TransmissaoAutomatica, carroDto.Combustivel);
            CarrosDaClasse.Add(carroDto);
            return Ok(CarrosDaClasse);
        }
        catch (ErroDeValidacaoException ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpGet("GetCarro")]
    public IActionResult GetCarro()
    {
        return Ok(CarrosDaClasse);
    }

    [HttpDelete("DeleteCarro")]
    public IActionResult DeleteCarro()
    {
        var index = CarrosDaClasse.Count();
        if (index != 0)
        {
            CarrosDaClasse.RemoveAt(index - 1);
            return Ok(CarrosDaClasse);
        }
        return BadRequest("Essa lista está vazia");
    }
}