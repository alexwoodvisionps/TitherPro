using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Woodensoft.TitherPro.Domain.Contexts;
using Woodensoft.TitherPro.Domain.Models;
namespace Woodensoft.TitherPro.Domain.Repositories
{
    public class ReportRepository
    {
        private TitheDBEntities _entities;
        public ReportRepository(TitheDBEntities entities)
        {
            _entities = entities;
        }
        public TitherReport GetReport(DateTime start, DateTime end)
        {
            var allTithes = _entities.TitheLogs.Where(x => x.DateEntered >= start && x.DateEntered <= end).ToList();
            var titheDic = new Dictionary<int, decimal>();
            foreach (var titheLog in allTithes)
            {
                if (titheLog.TitherId.HasValue && !titheDic.ContainsKey(titheLog.TitherId.Value))
                {
                    titheDic.Add(titheLog.TitherId.Value, titheLog.TitheAmount);
                }
                else if (titheLog.TitherId.HasValue)
                {
                    titheDic[titheLog.TitherId.Value] += titheLog.TitheAmount;
                }
            }
            var maxId = 0;
            var minId = 0;
            decimal minAmount = int.MaxValue;
            decimal maxAmount = 0;
            foreach (var titheKey in titheDic.Keys)
            {
                if (maxAmount < titheDic[titheKey])
                {
                    maxAmount = titheDic[titheKey];
                    maxId = titheKey;
                }
                if (minAmount > titheDic[titheKey])
                {
                    minAmount = titheDic[titheKey];
                    minId = titheKey;
                }
            }

            var minTither = _entities.TitheLogs.FirstOrDefault(x => x.TitherId == minId).Tither;
            var maxTither = _entities.TitheLogs.FirstOrDefault(x => x.TitherId == maxId).Tither;
            var titheReport = new TitherReport { MaxTither = maxTither, MinTither = minTither, MaxTithe = maxAmount, MinTithe = minAmount, TotalTithes = allTithes.Sum(x => x.TitheAmount) };
            return titheReport;
        }

        public List<TitherReportDetails> GetReportDetails(DateTime start, DateTime end)
        {
            return _entities.TitheLogs.Where(x => x.DateEntered >= start && x.DateEntered <= end && x.TitherId.HasValue)
               .Select(x => new TitherReportDetails
               {
                   FirstName = x.Tither.FirstName,
                   LastName = x.Tither.LastName,
                   MiddleName = x.Tither.MiddleName,
                   Year = end.Year,
                   DateJoined = x.Tither.DateJoined,
                   TotalAmount = _entities.TitheLogs.Where(y => y.DateEntered >= start && y.DateEntered <= end && y.TitherId == x.TitherId).Sum(y => y.TitheAmount),
                   TitherId = x.TitherId.Value
               }).ToList();
        }
    }
}
