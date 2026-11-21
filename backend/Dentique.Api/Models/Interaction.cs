namespace RendezDent.Models;

public class Interaction
{
public int Id { get; set;}
public int ClientId { get; set; }
public int? UserId { get; set; } //null if the system sends an automatic message to the client. The user is not implied. 
public Client? Client { get; set; }
public User? User { get; set; }

public string Type { get; set; } = "Call";
public string Notes { get; set; } = string.Empty;
public DateTime CreatedAt { get; set; } = DateTime.UtcNow;



}