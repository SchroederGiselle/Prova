using System;
using System.ComponentModel.DataAnnotations;

namespace GiselleSchroeder.Models;

public class Funcionario
{
    [Key]
    public string? cpf { get; set; }
    public string? nome { get; set; }
}
