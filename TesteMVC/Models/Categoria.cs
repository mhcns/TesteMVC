using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Categoria
{
    public int Id { get; set; }
    [Display(Name = "Descri��o")]
    [Required(ErrorMessage = "O campo descri��o � obrigat�rio")]
    public string Descricao { get; set; }
}
