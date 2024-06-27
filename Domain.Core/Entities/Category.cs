namespace Domain.Core.Entities;

public class Category : BaseEntity
{
    public string CategoryName { get; set; }
    
    //nav props
    public List<Assignment> Assignments { get; set; } = new List<Assignment>();
}