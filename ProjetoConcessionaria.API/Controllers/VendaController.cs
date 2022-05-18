using Microsoft.AspNetCore.Mvc;
using ProjetoConcessionaria.Models;
using ProjetoConcessionaria.Console.Exception;
using ProjetoConcessionaria.API.DTOs;

namespace ProjetoConcessionaria.API.Controllers;

[ApiController]
[Route("[controller]")]

public class VendaController : ControllerBase
{
    public static List<VendaDto> VendasDaClasse { get; set; } = new List<VendaDto>();

    [HttpPost("SetVenda")]
    public IActionResult SetVenda(VendaDto vendaDto)
    {
        try
        {
            var venda = new Venda(vendaDto.ClienteDto, vendaDto.VendedorDto, vendaDto.VeiculoDto, vendaDto.FormaPagamento, vendaDto.ValorFinal);
            VendasDaClasse.Add(vendaDto);
            return Ok(VendasDaClasse);
        }
        catch (ErroDeValidacaoException ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpGet("GetVenda")]
    public IActionResult GetVenda()
    {
        return Ok(VendasDaClasse);
    }

    [HttpDelete("DeleteVenda")]
    public IActionResult DeleteVenda()
    {
        var index = VendasDaClasse.Count();
        if (index != 0)
        {
            VendasDaClasse.RemoveAt(index - 1);
            return Ok(VendasDaClasse);
        }
        return BadRequest("Essa lista está vazia");
    }
}