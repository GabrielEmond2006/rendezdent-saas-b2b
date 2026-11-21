namespace RendezDent.Models;

    public class User
    {
        public int Id { get; set; }   //Primary Key 
        public int OrganizationId { get; set; } //Foreign Key
        public Organization? Organization { get; set; } //This variable can be empty.    
        public string FullName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty; //PasswordHash must be stored in the DB.  
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public List<Interaction> Interactions { get; set; } = new();



    }





