﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MeetupClone.Models;

[Index(nameof(Email), IsUnique = true)]
public class Member
{
    public int Id { get; set; }

    [Required]
    [MinLength(2)]
    public string FirstName { get; set; }

    [Required]
    [MinLength(2)]
    public string LastName { get; set; }

    [NotMapped]
    public string FullName
    {
        get
        {
            return FirstName + " " + LastName;
        }
    }

    [Required]
    [EmailAddress]
    public string Email { get; set; }
}
