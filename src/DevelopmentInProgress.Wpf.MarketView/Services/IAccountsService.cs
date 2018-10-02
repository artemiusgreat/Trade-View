﻿using DevelopmentInProgress.Wpf.MarketView.Model;
using System.Threading.Tasks;

namespace DevelopmentInProgress.Wpf.MarketView.Services
{
    public interface IAccountsService
    {
        Task<UserAccounts> GetAccounts();
        Task<UserAccount> GetAccount(string accountName);
        Task SaveAccount(UserAccount userAccount);
        Task DeleteAccount(UserAccount userAccount);
    }
}