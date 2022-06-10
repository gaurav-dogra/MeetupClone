using System.ComponentModel.DataAnnotations;

namespace MeetupClone.Models;

public class Comment
{
    public int Id { get; set; }
    
    [Required]
    public Member Member { get; set; }
    
    [Required]
    public string Text { get; set; }

    public List<Member> LikedBy { get; set; }
}
