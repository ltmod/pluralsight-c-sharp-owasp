using System.Security.Cryptography;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace OWASP.AuthenticationFailure.Web.After.Controllers
{
    public class AuthController : Controller
    {
        private readonly SignInManager<IdentityUser> _signInManager;

        public AuthController(SignInManager<IdentityUser> signInManager)
        {
            _signInManager = signInManager;
        }

        public IActionResult Index()
        {
            var pwdStrength = _signInManager.Options.Password.RequiredLength;
            var lockout = _signInManager.Options.Lockout.DefaultLockoutTimeSpan;


            return View();
        }

        [HttpPost]
        public IActionResult Index(string username, string password)
        {
            var usersDb = new UserData();
            var user = usersDb.Login(username, password);
            if (user != null)
            {
                HttpContext.Session.SetString("Firstname", user.Firstname);
                HttpContext.Session.SetString("Username", user.Username);
                HttpContext.Session.SetString("Role", user.Role);

                if (user.Role.Equals("Admin"))
                {
                    return RedirectToAction("Users");
                }
            }
            else
            {
                if (usersDb.GetUserByUsername(username) != null)
                {
                    ViewBag.Error = $"Incorrect password user for {username}.";
                }
                else
                {
                    ViewBag.Error = "Username was not found.";
                }
            }

            return View();
        }

        public IActionResult Users()
        {
            var usersDb = new UserData();
            ViewBag.Data = usersDb.GetAllUsers();
            return View();
        }


        public class UserData
        {
            private readonly List<User> _users = new();

            public UserData()
            {
                _users.Add(new User
                {
                    Username = "admin@test.com",
                    Password = CreateMD5("Summer2022!"),
                    Firstname = "Alex",
                    Role = "Admin"
                });
                _users.Add(new User
                {
                    Username = "user1@test.com",
                    Password = CreateMD5("password1"),
                    Firstname = "User 1",
                    Role = "User"
                });
                _users.Add(new User
                {
                    Username = "user2@test.com",
                    Password = CreateMD5("jumpman23"),
                    Firstname = "User 2",
                    Role = "User"
                });
            }

            public User? Login(string username, string password)
            {
                var hashedPassword = CreateMD5(password);

                return _users.FirstOrDefault(x => x.Username == username && x.Password == hashedPassword);
            }

            public List<User> GetAllUsers()
            {
                return _users;
            }

            public User? GetUserByUsername(string username)
            {
                return _users.FirstOrDefault(x => x.Username == username);
            }

            public static string CreateMD5(string input)
            {
                // Use input string to calculate MD5 hash
                using var md5 = MD5.Create();
                var inputBytes = Encoding.ASCII.GetBytes(input);
                var hashBytes = md5.ComputeHash(inputBytes);

                return Convert.ToHexString(hashBytes);
            }
        }


        public class User
        {
            public string Username { get; set; }
            public string Password { get; set; }
            public string Firstname { get; set; }
            public string Role { get; set; }
        }
    }
}