using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using WebApplication1.Models;

namespace WebApplication1.Models
{
    // You can add User data for the user by adding more properties to your User class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public ClaimsIdentity GenerateUserIdentity(ApplicationUserManager manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = manager.CreateIdentity(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }

        public Task<ClaimsIdentity> GenerateUserIdentityAsync(ApplicationUserManager manager)
        {
            return Task.FromResult(GenerateUserIdentity(manager));
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<News> News { get; set; }
        public DbSet<Gallery> Gallery { get; set; }

        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<News>()
                 .HasKey(e => e.Id);

            modelBuilder.Entity<News>()
                 .Property(x => x.Id)
                 .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<News>()
                .Property(x => x.DateTime)
                .HasColumnType("DATETIME2");

            base.OnModelCreating(modelBuilder);
        }
    }

    public class News
    {
        public Guid Id { get; set; }
        public String Title { get; set; }
        public String Article { get; set; }
        public DateTime DateTime { get; set; }
    }

    public class Gallery
    {
        public Guid Id { get; set; }
        public String Name { get; set; }
        public String Path { get; set; }
    }

}

    #region Helpers
    namespace WebApplication1
    {
        public static class IdentityHelper
        {
            // Used for XSRF when linking external logins
            public const string XsrfKey = "XsrfId";

            public const string ProviderNameKey = "providerName";
            public static string GetProviderNameFromRequest(HttpRequest request)
            {
                return request.QueryString[ProviderNameKey];
            }

            public const string CodeKey = "code";
            public static string GetCodeFromRequest(HttpRequest request)
            {
                return request.QueryString[CodeKey];
            }

            public const string UserIdKey = "userId";
            public static string GetUserIdFromRequest(HttpRequest request)
            {
                return HttpUtility.UrlDecode(request.QueryString[UserIdKey]);
            }

            public static string GetResetPasswordRedirectUrl(string code, HttpRequest request)
            {
                var absoluteUri = "/Account/ResetPassword?" + CodeKey + "=" + HttpUtility.UrlEncode(code);
                return new Uri(request.Url, absoluteUri).AbsoluteUri.ToString();
            }

            public static string GetUserConfirmationRedirectUrl(string code, string userId, HttpRequest request)
            {
                var absoluteUri = "/Account/Confirm?" + CodeKey + "=" + HttpUtility.UrlEncode(code) + "&" + UserIdKey + "=" + HttpUtility.UrlEncode(userId);
                return new Uri(request.Url, absoluteUri).AbsoluteUri.ToString();
            }

            private static bool IsLocalUrl(string url)
            {
                return !string.IsNullOrEmpty(url) && ((url[0] == '/' && (url.Length == 1 || (url[1] != '/' && url[1] != '\\'))) || (url.Length > 1 && url[0] == '~' && url[1] == '/'));
            }

            public static void RedirectToReturnUrl(string returnUrl, HttpResponse response)
            {
                if (!String.IsNullOrEmpty(returnUrl) && IsLocalUrl(returnUrl))
                {
                    response.Redirect(returnUrl);
                }
                else
                {
                    response.Redirect("~/");
                }
            }
        }
    }
#endregion
