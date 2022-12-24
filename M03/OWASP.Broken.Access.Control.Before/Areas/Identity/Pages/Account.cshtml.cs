using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace OWASP.Broken.Access.Control.Before.Areas.Identity.Pages
{
    [Authorize]
    public class AccountModel : PageModel
    {
        [BindProperty] public Account Input { get; set; } = new();

        public void OnGet(int id)
        {
            var ds = new AccountDataSource();

            Input = ds.GetUserById(id);
        }
    }

    public class Account
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string Organization { get; set; }
        public string Location { get; set; }
        public string PhoneNumber { get; set; }
        public DateOnly BirthDate { get; set; }
    }

    public class AccountDataSource
    {
        private readonly List<Account> ds;

        public AccountDataSource()
        {
            ds = new List<Account>
            {
                new Account
                {
                    Id = 1,
                    Username = "admin@test.com",
                    FirstName = "Admin",
                    LastName = "Account",
                    EmailAddress = "admin@test.com",
                    Location = "San Francisco, CA",
                    Organization = "The Wired Brain Coffee Co",
                    PhoneNumber = "222-555-1212",
                    BirthDate = new DateOnly(1990, 01, 10)
                },
                new Account
                {
                    Id = 2,
                    Username = "user@test.com",
                    FirstName = "User",
                    LastName = "Test",
                    EmailAddress = "user@test.com",
                    Location = "San Francisco, CA",
                    Organization = "The Company Inc",
                    PhoneNumber = "111-555-1212",
                    BirthDate = new DateOnly(1985, 10, 11)
                },
                new Account
                {
                    Id = 3,
                    Username = "anotheruser@test.com",
                    FirstName = "Another",
                    LastName = "User",
                    EmailAddress = "anotheruser@test.com",
                    Location = "New York, NY",
                    Organization = "The Company Inc",
                    PhoneNumber = "444-555-1212",
                    BirthDate = new DateOnly(1989, 6, 22)
                }
            };
        }

        public Account GetUserById(int id)
        {
            return ds.FirstOrDefault(x => x.Id == id) ?? new Account();
        }
    }
}