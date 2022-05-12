using Microsoft.AspNetCore.Mvc;
using ProjetoConcessionaria.Models;

namespace ProjetoConcessionaria.API.Controllers;

[ApiController]
[Route("[controller]")]

public class VeiculoController : ControllerBase
{
    public static List<Veiculo> VeiculosDaClasse { get; set; } = new List<Veiculo>();

    [HttpPost("SetVeiculo")]
    public IActionResult SetVeiculo(Veiculo veiculo)
    {
        VeiculosDaClasse.Add(veiculo);
        return Ok(VeiculosDaClasse);
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