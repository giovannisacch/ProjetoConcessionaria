using Microsoft.AspNetCore.Mvc;
using ProjetoConcessionaria.Models;

namespace ProjetoConcessionaria.API.Controllers;

[ApiController]
[Route("[controller]")]

public class VendaController : ControllerBase
{
    public static List<Venda> VendasDaClasse { get; set; } = new List<Venda>();

    [HttpPost("SetVenda")]
    public IActionResult SetVenda(Venda venda)
    {
        VendasDaClasse.Add(venda);
        return Ok(VendasDaClasse);
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