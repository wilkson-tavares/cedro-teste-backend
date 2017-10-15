﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

[Table("Restaurante")]
public class Restaurante
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ID { get; set; }

    [StringLength(50)]
    [Required(ErrorMessage = "O nome do restaurante é obrigatório")]
    public string Nome { get; set; }
}
