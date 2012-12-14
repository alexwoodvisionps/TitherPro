using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Woodensoft.TitherPro.Domain.Contexts;
using Woodensoft.TitherPro.Domain.Repositories; 
namespace Woodensoft.TitherPro.Domain.UnitsOfWork
{
	public class UnitOfWork
	{
        private TitheDBEntities _entities;
        public UnitOfWork(string connString)
        {
            _entities = new TitheDBEntities(connString);
        }

        private UserRepository _userRepo;
        public UserRepository UserRepository { get { return _userRepo ?? (_userRepo = new UserRepository(_entities));} }

        private ReportRepository _reportRepo;
        public ReportRepository ReportRepository { get { return _reportRepo?? (_reportRepo = new ReportRepository(_entities));} }

        private TitherRepository _titherRepo;
        public TitherRepository TitherRepository { get { return _titherRepo ?? (_titherRepo = new TitherRepository(_entities)); } }

        private TithingLogRepository _logRepo;
        public TithingLogRepository TithingLogRepository {get{return _logRepo?? (_logRepo = new TithingLogRepository(_entities));}}

        public void Save()
        {
            _entities.SaveChanges();
        }

	}
}
