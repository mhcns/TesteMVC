using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Categoria
{
    public int Id { get; set; }
    [Display(Name = "Descrição")]
    [Required(ErrorMessage = "O campo descrição é obrigatório")]
    public string Descricao { get; set; }
}
