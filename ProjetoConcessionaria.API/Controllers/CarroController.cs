using Microsoft.AspNetCore.Mvc;
using ProjetoConcessionaria.Models;
using ProjetoConcessionaria.API.DTOs;

namespace ProjetoConcessionaria.API.Controllers;

[ApiController]
[Route("[controller]")]

public class CarroController : ControllerBase
{
    public static List<Carro> CarrosDaClasse { get; set; } = new List<Carro>();

    [HttpPost("SetCarro")]
    public IActionResult SetCarro(Carro carro)
    {
        CarrosDaClasse.Add(carro);
        return Ok(CarrosDaClasse);
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