namespace EFGetStarted.Models
{
  public class Customer
  {
    private string lastName;
    private string firstname;

    public int Id { get; set; }
    public string Firstname { get => firstname; set => firstname = value; }
    public string LastName { get => lastName; set => lastName = value; }
    public string? Address { get; set; }
    public string? Phone { get; set; }
    public string? Email { get; set; }
  }
}