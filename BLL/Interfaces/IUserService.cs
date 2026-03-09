using BDE;
using BDE.Language;
using System.Collections.Generic;

namespace BLL.Interfaces
{
    public interface IUserService
    {
        List<User> GetAll();
        User GetById(int id);
        string GetRolById(int id);

        bool Save(User user);
        bool Update(User user);
        void UpdatePassword(string password);

        void BlockByUsername(string username);
        bool BlockById(int userId);
        bool UnlockById(int userId);

        void ChangeLanguage(Language language);
        bool ExistsById(int id);
        bool Validate(string username, string password);
        bool CheckStatus(int userId);

        void Logout();
        void ResetPassword(int userId);
    }
}
