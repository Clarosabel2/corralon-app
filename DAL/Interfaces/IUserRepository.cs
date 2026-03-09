using BDE;
using BDE.Language;
using System.Collections.Generic;
using System.Data;

namespace DAL.Interfaces
{
    public interface IUserRepository
    {
        bool Save(User user);
        bool Update(User user);
        bool UpdatePassword(int idUser, string newPassword);


        bool Validate(string username, string password);

        bool BlockByUsername(string username);
        bool BlockById(int idUser);
        bool Unlock(int idUser);

        void ResetPassword(int idUser, string passwordHashed);
        void ChangeLanguage(Language language, int idUser);
        bool CheckStatus(int idUser);

        bool ExistsById(int idUser);
        bool ExtisByUsername(string username);

        List<User> GetAll();
        DataTable GetByProfile();
        User GetDataUser(string username, string password);
        User GetById(int idUser);
        string GetRolUser(int idUser);
    }
}
