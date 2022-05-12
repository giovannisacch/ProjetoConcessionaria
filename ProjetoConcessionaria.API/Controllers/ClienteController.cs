using Microsoft.AspNetCore.Mvc;
using ProjetoConcessionaria.Models;

namespace ProjetoConcessionaria.API.Controllers;

[ApiController]
[Route("[controller]")]

public class ClienteController : ControllerBase
{
    public static List<Cliente> ClientesDaClasse { get; set; } = new List<Cliente>();

    [HttpPost("SetCliente")]
    public IActionResult SetCliente(Cliente cliente)
    {
        ClientesDaClasse.Add(cliente);
        return Ok(ClientesDaClasse);
    }

    [HttpGet("GetCliente")]
    public IActionResult GetCliente()
    {
        return Ok(ClientesDaClasse);
    }

    [HttpDelete("DeleteCliente")]
    public IActionResult DeleteCliente()
    {
        var index = ClientesDaClasse.Count();
        if (index != 0)
        {
            ClientesDaClasse.RemoveAt(index - 1);
            return Ok(ClientesDaClasse);
        }
        return BadRequest("Essa lista está vazia");
    }
}