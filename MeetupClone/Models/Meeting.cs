using System.ComponentModel.DataAnnotations;

namespace MeetupClone.Models;

public class Meeting
{
    public int Id { get; set; }
    
    [Required]
    [MinLength(2)]
    public string Name { get; set; }

    [Required]
    [MinLength(32)]
    public string About { get; set; }

    [Required]
    public Boolean IsOnline { get; set; }

    [Required]
    public DateTime DateTime { get; set; }

    public List<Member> Hosting { get; set; }
    public List<Member> Going { get; set; }
}
