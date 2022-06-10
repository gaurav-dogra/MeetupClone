using System.ComponentModel.DataAnnotations;

namespace MeetupClone.Models;

public class MeetingGroup
{
    public int Id { get; set; }

    [Required]
    [MinLength(4)]
    public string Name { get; set; }

    [MinLength(2)]
    public string? City { get; set; }

    [MinLength(2)]
    public string? Country { get; set; }

    [Required]
    public Boolean IsPublic { get; set; } = true;

    [MinLength(32)]
    public string Description { get; set; }

    public List<Member> Members { get; set; }
}
