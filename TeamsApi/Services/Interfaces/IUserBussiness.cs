using Microsoft.AspNetCore.Identity.UI.V4.Pages.Account.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamsApi.ViewModels;

namespace TeamsApi.Services.Interfaces
{
    public interface IUserBussiness
    {
        Task<string> RegisterAsync(RegisterUserViewModel model);
        Task<AuthenticationViewModel> GetTokenAsync(TokenRequestViewModel model);
    }
}
