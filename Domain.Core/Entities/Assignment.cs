namespace Domain.Core.Entities;

public class Assignment : BaseEntity
{
    public string? TopicName { get; set; } = string.Empty;
    public string? Description { get; set; } = string.Empty;
    public double Price { get; set; }
    public int CategoryId { get; set; }
    public Category Category { get; set; }
}