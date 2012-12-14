using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Woodensoft.TitherPro.Domain.Contexts;
namespace Woodensoft.TitherPro.Domain.Repositories
{
    public class TithingLogRepository
    {
        private TitheDBEntities _entities;
        public TithingLogRepository(TitheDBEntities entities)
        {
            _entities = entities;
        }
        public void AddTitheLog(DateTime dateTithed, decimal amount, int titherId)
        {
            _entities.TitheLogs.AddObject(new TitheLog { TitherId = titherId, DateEntered = DateTime.Now, TitheAmount = amount, TitheDate = dateTithed });
        }
        public void DeleteTithe(long titheLogId)
        {
            var titheLog = _entities.TitheLogs.SingleOrDefault(x => x.TitheLogId == titheLogId);
            if (titheLog == null)
                return;
            _entities.TitheLogs.DeleteObject(titheLog);
        }

        public IEnumerable<TitheLog> GetAllByStartAndEndDate(DateTime start, DateTime end)
        {
            return _entities.TitheLogs.Where(x => x.DateEntered <= end && x.DateEntered >= start).ToList();
        }
    }
}
