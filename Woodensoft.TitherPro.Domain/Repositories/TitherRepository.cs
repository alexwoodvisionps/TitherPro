using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Woodensoft.TitherPro.Domain.Contexts;
namespace Woodensoft.TitherPro.Domain.Repositories
{
    public class TitherRepository
    {
        private TitheDBEntities _entities;
        public TitherRepository(TitheDBEntities entities)
        {
            _entities = entities;
        }
        public void AddTither(string firstname, string lastname, string middlename)
        {
            _entities.Tithers.AddObject(new Tither { FirstName = firstname, LastName = lastname, MiddleName = middlename, DateJoined = DateTime.Now });
        }
        public IEnumerable<Tither> RecommendTithers(string firstName, string lastName)
        {
            return _entities.Tithers.Where(x => x.FirstName.StartsWith(firstName) && x.LastName.StartsWith(lastName)).ToList();
        }
        public void UpdateTither(int titherId, string lastname, string firstname, string middlename)
        {
            var tither = _entities.Tithers.SingleOrDefault(x => x.TitherId == titherId);
            if (tither == null)
                return;
            tither.LastName = lastname;
            tither.FirstName = firstname;
            tither.MiddleName = middlename;
        }

        public IEnumerable<Tither> GetAll()
        {
            return _entities.Tithers.ToList();
        }
    }
}
