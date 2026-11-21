namespace RendezDent.Models;

public class Client
{
public int Id { get; set;}
public int OrganizationId { get; set;}       
 public Organization? Organization { get; set;}
public string Name { get; set; } = string.Empty;
public string Email { get; set; } = string.Empty;
public string? Phone { get; set; }
public string? CompanyName { get; set; }
public string Status { get; set; } = "Prospect"; //"Prospect", "Active", "Churned"
public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
public List<Interaction> Interactions { get; set; } = new();             
       
}

