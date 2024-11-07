using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIConBD.Entities;

[Table("Todos")]
public partial class Todo
{
    [Key]
    public int Id { get; set; }
    
    public string? Name { get; set; }
    
    public int? IsCompleted { get; set; }
}