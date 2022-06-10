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
    
    [Required]
    public Boolean IsLimitedAttendees { get; set; }

    public int Limit { get; set; }
    public List<Member> Hosting { get; set; }
    public List<Member> Attendees { get; set; }
    public List<Member> NotAttendees { get; set; }
    public List<Member> Waiting { get; set; }

    public List<Comment> Comments { get; set; }

}
