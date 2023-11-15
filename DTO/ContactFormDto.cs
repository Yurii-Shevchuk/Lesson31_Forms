namespace DTO;

public class ContactFormDto
{
    public string first_name { get; set; }
    public string last_name { get; set; }
    public string phone { get; set; }
    public DateTime? birthdate {get; set;}
    public string? email {get; set;}
    public string? imageBytes64 {get;set;}
}