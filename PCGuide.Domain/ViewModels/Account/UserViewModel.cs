using Microsoft.AspNetCore.Identity;
using System;

namespace PCGuide.Domain.ViewModels.Account
{
    public class UserViewModel
    {
        public string UserName { get; set; }

        public string Email { get; set; }

        public string PasswordHash { get; set; }

        public static explicit operator UserViewModel(IdentityUser user)
        {
            return new UserViewModel
            {
                UserName = user.UserName,
                Email = user.Email,
                PasswordHash = user.PasswordHash
            };
        }
    }
}
