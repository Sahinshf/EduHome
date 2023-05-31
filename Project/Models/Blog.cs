namespace Project.Models;

public class Blog
{
    public int Id { get; set; }
    public string Image { get; set; }
    public string Name { get; set; }    
    public string Description { get; set; }
    public string Author { get; set; }
    public int Comment { get; set; }
    public DateTime Created { get; set; }
    public bool IsDeleted { get; set; }
}
