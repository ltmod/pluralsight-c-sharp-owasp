using System.Data;
using System.Text;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using OWASP.Injections.Web.After.Entities;

namespace OWASP.Injections.Web.After.Pages
{
    public class DataGridModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public DataGridModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<UserDatum> GridData { get; set; }

        public void OnGet(string search)
        {
            search = string.IsNullOrEmpty(search) ? string.Empty : "%" + search + "%";

            var sql = new StringBuilder();

            sql.AppendLine("SELECT [Id], ");
            sql.AppendLine("       [FirstName], ");
            sql.AppendLine("       [LastName], ");
            sql.AppendLine("       [City], ");
            sql.AppendLine("       [USState] ");
            sql.AppendLine("FROM [dbo].[UserData] ");
            sql.AppendLine(
                "WHERE (FirstName LIKE @search) OR (LastName LIKE @search) OR (City LIKE @search) OR @search = ''");

            var searchParameter = new SqlParameter("search", SqlDbType.VarChar, 100)
            {
                Value = search
            };

            GridData = _context.UserData.FromSqlRaw(sql.ToString(), searchParameter).ToList();
        }
    }
}