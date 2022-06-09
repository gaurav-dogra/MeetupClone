namespace MeetupClone.Models;

public class MeetingGroup
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string City { get; set; }
    public string Country { get; set; }

    public Boolean IsPublic { get; set; }

    public string Description { get; set; }

    public List<Member> Members { get; set; }
}
