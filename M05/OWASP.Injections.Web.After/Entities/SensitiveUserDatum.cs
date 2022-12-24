namespace OWASP.Injections.Web.After.Entities
{
    public class SensitiveUserDatum
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Ssn { get; set; } = null!;
        public DateTime Dob { get; set; }
    }
}