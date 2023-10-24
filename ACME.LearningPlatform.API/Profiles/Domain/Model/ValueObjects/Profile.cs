namespace ACME.LearningPlatform.API.Profiles.Domain.Model.ValueObjects;

public class Profile
{
    public int Id { get; }
    public PersonName Name { get; private set; }
    public EmailAddress Email { get; private set; }
    public StreetAddress Address { get; private set; }
    
    public Profile(string firstName, string lastName, string email, string street, string city, string state, string zipCode)
    {
        Name = new PersonName(firstName, lastName);
        Email = new EmailAddress(email);
        Address = new StreetAddress(street, city, state, zipCode);
    }
}