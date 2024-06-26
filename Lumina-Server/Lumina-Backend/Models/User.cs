﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lumina_Backend.Models;

public class User : BaseEntity
{
    public string? UserName { get; set; }

    public string? Password { get; set; }

    public string? Email { get; set; }

    public string? SessionToken { get; set; }

    public string? FullName { get; set; }

    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
    [Column(TypeName = "Date")]
    public DateTime? DateOfBirth { get; set; }

    public string? Address { get; set; }

    public string? DNI { get; set; }

    public string? ProfileImage { get; set; }

    public ICollection<Account>? Accounts { get; set; }
    public ICollection<Security>? Securities { get; set; }
    public ICollection<Log>? Logs { get; set; }
}