namespace datingAppAPI.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int ContactInformationId { get; set; }
        public ContactInformation ContactInformation { get; set; }
    }
}
