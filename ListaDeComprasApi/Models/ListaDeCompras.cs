using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace ListaDeComprasApi.Models;

public class ListaDeCompras
{
    [Required(ErrorMessage = "O campo Título é obrigatório")]
    public string Titulo {  get; set; }
    [Required(ErrorMessage = "O campo Data é obrigatório")]
    public DateTime Data {  get; set; }
    [Required(ErrorMessage = "O campo Itens é obrigatório")]
    [MinLength(1, ErrorMessage = "O campo Itens deve conter pelo menos um item")]
    public List<string> Itens { get; set; }
}
