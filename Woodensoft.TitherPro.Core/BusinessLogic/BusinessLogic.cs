using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Woodensoft.TitherPro.Domain.UnitsOfWork;
using Woodensoft.TitherPro.Domain.Models;
using Woodensoft.TitherPro.Domain.Contexts;
namespace Woodensoft.TitherPro.Core.BusinessLogic
{
    public class BusinessLogic
    {
        private UnitOfWork _unitOfWork;
        public BusinessLogic(string connString)
        {
            _unitOfWork = new UnitOfWork(connString);
        }

        public TitherReport GetReport(DateTime start, DateTime end)
        {
            return _unitOfWork.ReportRepository.GetReport(start, end);
        }
        public List<Tither> GetAllTithers()
        {
            return _unitOfWork.TitherRepository.GetAll().ToList();
        }
        public List<TitheLog> GetAllTitherLogs(DateTime start, DateTime end)
        {
            return _unitOfWork.TithingLogRepository.GetAllByStartAndEndDate(start, end).ToList();
        }
        public List<TitherReportDetails> GetReportDetails(DateTime start, DateTime end)
        {
            return _unitOfWork.ReportRepository.GetReportDetails(start, end);
        }

        public void AddTither(string firstname, string lastname, string middlename)
        {
            _unitOfWork.TitherRepository.AddTither(firstname, lastname, middlename);
            _unitOfWork.Save();
        }
        public List<Tither> RecommendTithers(string firstName, string lastName)
        {
            return _unitOfWork.TitherRepository.RecommendTithers(firstName, lastName).ToList();
        }
        public void UpdateTither(int titherId, string lastname, string firstname, string middlename)
        {
            _unitOfWork.TitherRepository.UpdateTither(titherId, lastname, firstname, middlename);
            _unitOfWork.Save();
        }

        public void AddTitheLog(DateTime dateTithed, decimal amount, int titherId)
        {
            _unitOfWork.TithingLogRepository.AddTitheLog(dateTithed, amount, titherId);
            _unitOfWork.Save();
        }
        public void DeleteTithe(long titheLogId)
        {
            _unitOfWork.TithingLogRepository.DeleteTithe(titheLogId);
            _unitOfWork.Save();
        }
        public User ValidateUserLogin(string username, string password)
        {
            return _unitOfWork.UserRepository.ValidateUserLogin(username, password);
        }

        public void AddUser(string username, string password, bool isAdmin)
        {
            _unitOfWork.UserRepository.AddUser(username, password, isAdmin);
            _unitOfWork.Save();
        }

        public void UpdateUser(int userId, string password, bool isAdmin, bool active)
        {
            _unitOfWork.UserRepository.UpdateUser(userId, password, isAdmin, active);
            _unitOfWork.Save();
        }

        public void DeleteUser(int userId)
        {
            _unitOfWork.UserRepository.DeleteUser(userId);
            _unitOfWork.Save();
        }

        public List<User> GetAllUsers()
        {
            return _unitOfWork.UserRepository.GetAllUsers().ToList();
        }
    }
}
