using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Entity;

public class Filme
{
    [Key]
    [Required]
    public int Id { get; set; }
    [Required(ErrorMessage = "Titulo do filme é obrigatorio")] 
    public string Titulo { get; set; }
    [Required(ErrorMessage ="O genero do filme é obrigatorio")]
    [MaxLength(50)]
    public string Genero { get; set; }
    [Required]
    [Range(70, 300 , ErrorMessage ="A duração deve ter entre 70 e 300 minutos")]
    public int Duracao { get; set; }
}
