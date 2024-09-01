using ListaDeComprasApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace ListaDeComprasApi.Controllers;

[ApiController]
[Route("[controller]")]
public class ListaDeComprasController : ControllerBase
{
    private List<ListaDeCompras> todasAsListas = new List<ListaDeCompras>();

    [HttpPost]
    public void AdicionarListaDeCompras([FromBody] ListaDeCompras listaDeCompras)
    {
        todasAsListas.Add(listaDeCompras);
        Console.WriteLine(todasAsListas.Count);
        Console.WriteLine(listaDeCompras.Titulo);
        Console.WriteLine(listaDeCompras.Itens);

    }

    [HttpGet]
    public IEnumerable<ListaDeCompras> ObterTodasListaDeCompras()
    {
        return todasAsListas;
    }

}
