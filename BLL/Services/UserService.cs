using BDE;
using BDE.Enums;
using BDE.Language;
using BLL.Interfaces;
using DAL;
using DAL.Interfaces;
using SVC;
using SVC.LanguageManager;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IEmployeeService _employeeService;
        private readonly IEventlogService _eventlogService;

        public UserService(IUserRepository userRepository, IEmployeeService employeeService, IEventlogService eventlogService)
        {
            _userRepository = userRepository;
            _employeeService = employeeService;
            _eventlogService = eventlogService;
        }

        public List<User> GetAll()
        {
            return _userRepository.GetAll();
        }
        public User GetById(int id)
        {
            return _userRepository.GetById(id);
        }

        public string GetRolById(int id)
        {
            return _userRepository.GetRolUser(id);
        }
        public bool Save(User newUser)
        {
            newUser.Password = SHAHashHelper.HashValue(newUser.Password);
            return _userRepository.Save(newUser);
        }

        public bool Update(User user)
        {
            if (_userRepository.Update(user))
            {
                SessionManager.GetInstance.user.Emp.Name = user.Emp.Name;
                SessionManager.GetInstance.user.Emp.Lastname = user.Emp.Lastname;
                SessionManager.GetInstance.user.Emp.Email = user.Emp.Email;
                return true;
            }
            return false;
        }

        public void UpdatePassword(string password)
        {
            string passwordHashed = SHAHashHelper.HashValue(password);
            if (_userRepository.UpdatePassword(SessionManager.GetInstance.user.Emp.Id, passwordHashed))
            {
                SessionManager.GetInstance.user.Password = passwordHashed;
            }
        }

        public void ChangeLanguage(Language language)
        {
            SessionManager.GetInstance.user.Language = language;
            _userRepository.ChangeLanguage(language, SessionManager.GetInstance.user.Emp.Id);
        }

        public bool ExistsById(int id)
        {
            return _userRepository.ExistsById(id);
        }

        public bool Validate(string username, string password)
        {
            string passwordHashed = SHAHashHelper.HashValue(password);
            if (!_userRepository.Validate(username, passwordHashed))
            {
                return false;
            }

            User userLogin = _userRepository.GetDataUser(username, passwordHashed);
            SessionManager.Login(userLogin);
            SessionManager.GetInstance.user.Language =
                SessionManager.translations
                .FirstOrDefault(l => l.Key.Name == userLogin.Language.Name).Key;
            //BLL_EventLog.LogEvent(
            //        "User logged in",
            //        BE_EventType.LOGIN,
            //        BE_ActivityLevel.INFORMATION);

            return true;
        }

        public bool CheckStatus(int idUser)
        {
            if (_userRepository.CheckStatus(idUser))
            {
                return true;
            }
            return false;
        }

        public bool BlockById(int id)
        {
            return _userRepository.BlockById(id);
        }

        public bool UnlockById(int id)
        {
            return _userRepository.Unlock(id);
        }
        public void BlockByUsername(string username)
        {
            _userRepository.BlockByUsername(username);
        }

        public void Logout()
        {
            _eventlogService.LogEvent("User logged out", BE_EventType.LOGOUT, BE_ActivityLevel.INFORMATION);
            SessionManager.Logout();
        }

        public void ResetPassword(int id)
        {
            string passwordHashed = SHAHashHelper.HashValue(_employeeService.GetById(id).Dni.ToString());
            _userRepository.ResetPassword(id, passwordHashed);
        }
    }
}
