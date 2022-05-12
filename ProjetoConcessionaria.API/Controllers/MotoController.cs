using Microsoft.AspNetCore.Mvc;
using ProjetoConcessionaria.Models;

namespace ProjetoConcessionaria.API.Controllers;

[ApiController]
[Route("[controller]")]

public class MotoController : ControllerBase
{
    public static List<Moto> MotosDaClasse { get; set; } = new List<Moto>();

    [HttpPost("SetMoto")]
    public IActionResult SetMoto(Moto moto)
    {
        MotosDaClasse.Add(moto);
        return Ok(MotosDaClasse);
    }

    [HttpGet("GetMoto")]
    public IActionResult GetMoto()
    {
        return Ok(MotosDaClasse);
    }

    [HttpDelete("DeleteMoto")]
    public IActionResult DeleteMoto()
    {
        var index = MotosDaClasse.Count();
        if (index != 0)
        {
            MotosDaClasse.RemoveAt(index - 1);
            return Ok(MotosDaClasse);
        }
        return BadRequest("Essa lista está vazia");
    }
}