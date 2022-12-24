using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using OWASP.Broken.Access.Control.After.Data;

namespace OWASP.Broken.Access.Control.After;

public static class IdentitySeeds
{
    private const string Password = "Plural51ght!";

    public static void SeedData(UserManager<IdentityUser> userManager, ApplicationDbContext db)
    {
        db.Database.Migrate();

        var sql = new StringBuilder();

        sql.AppendLine("IF (NOT EXISTS (SELECT 1 FROM dbo.AspNetRoles WHERE [Name] = 'User')) ");
        sql.AppendLine("BEGIN ");
        sql.AppendLine("    INSERT INTO [dbo].[AspNetRoles] ");
        sql.AppendLine("    ( ");
        sql.AppendLine("        [Id], ");
        sql.AppendLine("        [Name], ");
        sql.AppendLine("        [NormalizedName], ");
        sql.AppendLine("        [ConcurrencyStamp] ");
        sql.AppendLine("    ) ");
        sql.AppendLine("    VALUES ");
        sql.AppendLine(
            "    ('1E809E28-211D-44E7-89F2-C5C9A6502072', 'User', 'USER', '7C01DC2B-3576-4A6A-B8C2-716B235A18C3'); ");
        sql.AppendLine(" ");
        sql.AppendLine("END; ");
        sql.AppendLine(" ");
        sql.AppendLine("IF (NOT EXISTS (SELECT 1 FROM dbo.AspNetRoles WHERE [Name] = 'Admin')) ");
        sql.AppendLine("BEGIN ");
        sql.AppendLine("    INSERT INTO [dbo].[AspNetRoles] ");
        sql.AppendLine("    ( ");
        sql.AppendLine("        [Id], ");
        sql.AppendLine("        [Name], ");
        sql.AppendLine("        [NormalizedName], ");
        sql.AppendLine("        [ConcurrencyStamp] ");
        sql.AppendLine("    ) ");
        sql.AppendLine("    VALUES ");
        sql.AppendLine(
            "    ('6AA4F022-EA06-420F-9169-86E275665AB1', 'Admin', 'ADMIN', '3FD8B7BF-7FE2-4599-AD32-410A26991C72'); ");
        sql.AppendLine(" ");
        sql.AppendLine("END; ");

        db.Database.ExecuteSqlRaw(sql.ToString());

        if (userManager.FindByEmailAsync("admin@test.com").Result == null)
        {
            var user = new IdentityUser
            {
                Id = "0aa439d4-f89e-4035-a913-fd7e97aa3cde",
                UserName = "admin@test.com",
                NormalizedUserName = "ADMIN@TEST.COM",
                Email = "admin@test.com",
                NormalizedEmail = "ADMIN@TEST.COM",
                EmailConfirmed = true,
                LockoutEnabled = false,
                PhoneNumber = "7025551212",
                PhoneNumberConfirmed = false,
                TwoFactorEnabled = false,
                AccessFailedCount = 0
            };
            var result = userManager.CreateAsync(user, Password).Result;

            if (result.Succeeded)
            {
                sql = new StringBuilder();

                sql.AppendLine("IF (NOT EXISTS ");
                sql.AppendLine("( ");
                sql.AppendLine("    SELECT 1 ");
                sql.AppendLine("    FROM dbo.AspNetUserRoles ");
                sql.AppendLine("    WHERE UserId = '0aa439d4-f89e-4035-a913-fd7e97aa3cde' ");
                sql.AppendLine("          AND RoleId = '6AA4F022-EA06-420F-9169-86E275665AB1' ");
                sql.AppendLine(") ");
                sql.AppendLine("   ) ");
                sql.AppendLine("BEGIN ");
                sql.AppendLine(" ");
                sql.AppendLine("    INSERT INTO [dbo].[AspNetUserRoles] ");
                sql.AppendLine("    ( ");
                sql.AppendLine("        [UserId], ");
                sql.AppendLine("        [RoleId] ");
                sql.AppendLine("    ) ");
                sql.AppendLine("    VALUES ");
                sql.AppendLine("    ('0aa439d4-f89e-4035-a913-fd7e97aa3cde', " +
                               "'6AA4F022-EA06-420F-9169-86E275665AB1'); ");
                sql.AppendLine("END; ");

                db.Database.ExecuteSqlRaw(sql.ToString());
            }
        }

        if (userManager.FindByEmailAsync("user@test.com").Result == null)
        {
            var user = new IdentityUser
            {
                Id = "53bd59d2-fd82-49aa-ac92-18c50b225c26",
                UserName = "user@test.com",
                NormalizedUserName = "USER@TEST.COM",
                Email = "user@test.com",
                NormalizedEmail = "USER@TEST.COM",
                EmailConfirmed = true,
                LockoutEnabled = false,
                PhoneNumber = "7025551212",
                PhoneNumberConfirmed = false,
                TwoFactorEnabled = false,
                AccessFailedCount = 0
            };
            var result = userManager.CreateAsync(user, Password).Result;

            if (result.Succeeded)
            {
                sql = new StringBuilder();

                sql.AppendLine("IF (NOT EXISTS ");
                sql.AppendLine("( ");
                sql.AppendLine("    SELECT 1 ");
                sql.AppendLine("    FROM dbo.AspNetUserRoles ");
                sql.AppendLine("    WHERE UserId = '53bd59d2-fd82-49aa-ac92-18c50b225c26' ");
                sql.AppendLine("          AND RoleId = '1E809E28-211D-44E7-89F2-C5C9A6502072' ");
                sql.AppendLine(") ");
                sql.AppendLine("   ) ");
                sql.AppendLine("BEGIN ");
                sql.AppendLine(" ");
                sql.AppendLine("    INSERT INTO [dbo].[AspNetUserRoles] ");
                sql.AppendLine("    ( ");
                sql.AppendLine("        [UserId], ");
                sql.AppendLine("        [RoleId] ");
                sql.AppendLine("    ) ");
                sql.AppendLine("    VALUES ");
                sql.AppendLine(
                    "    ('53bd59d2-fd82-49aa-ac92-18c50b225c26', '1E809E28-211D-44E7-89F2-C5C9A6502072'); ");
                sql.AppendLine("END; ");

                db.Database.ExecuteSqlRaw(sql.ToString());
            }
        }

        if (userManager.FindByEmailAsync("anotheruser@test.com").Result == null)
        {
            var user = new IdentityUser
            {
                Id = "c1a716ff-96c0-485e-a389-0badf5307f44",
                UserName = "anotheruser@test.com",
                NormalizedUserName = "ANOTHERUSER@TEST.COM",
                Email = "anotheruser@test.com",
                NormalizedEmail = "ANOTHERUSER@TEST.COM",
                EmailConfirmed = true,
                LockoutEnabled = false,
                PhoneNumber = "7025551212",
                PhoneNumberConfirmed = false,
                TwoFactorEnabled = false,
                AccessFailedCount = 0
            };
            var result = userManager.CreateAsync(user, Password).Result;

            if (result.Succeeded)
            {
                sql.AppendLine("IF (NOT EXISTS ");
                sql.AppendLine("( ");
                sql.AppendLine("    SELECT 1 ");
                sql.AppendLine("    FROM dbo.AspNetUserRoles ");
                sql.AppendLine("    WHERE UserId = 'c1a716ff-96c0-485e-a389-0badf5307f44' ");
                sql.AppendLine("          AND RoleId = '1E809E28-211D-44E7-89F2-C5C9A6502072' ");
                sql.AppendLine(") ");
                sql.AppendLine("   ) ");
                sql.AppendLine("BEGIN ");
                sql.AppendLine(" ");
                sql.AppendLine("    INSERT INTO [dbo].[AspNetUserRoles] ");
                sql.AppendLine("    ( ");
                sql.AppendLine("        [UserId], ");
                sql.AppendLine("        [RoleId] ");
                sql.AppendLine("    ) ");
                sql.AppendLine("    VALUES ");
                sql.AppendLine(
                    "    ('c1a716ff-96c0-485e-a389-0badf5307f44', '1E809E28-211D-44E7-89F2-C5C9A6502072'); ");
                sql.AppendLine("END; ");

                db.Database.ExecuteSqlRaw(sql.ToString());
            }
        }
    }
}