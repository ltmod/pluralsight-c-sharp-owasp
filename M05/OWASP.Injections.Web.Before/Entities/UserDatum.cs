namespace OWASP.Injections.Web.Before.Entities
{
    public class UserDatum
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string City { get; set; } = null!;
        public string Usstate { get; set; } = null!;
    }
}