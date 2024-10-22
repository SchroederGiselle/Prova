using System;
using System.ComponentModel.DataAnnotations;

namespace GiselleSchroeder.Models;

public class Folha
{
    [Key]
    public string? valor { get; set; }
    public string? quantidade { get; set; }
    public string? mes { get; set; }
    public string? ano { get; set; }
    public string? funcionarioId { get; set; }

    
}
