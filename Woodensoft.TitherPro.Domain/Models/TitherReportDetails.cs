using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Woodensoft.TitherPro.Domain.Models
{
    public class TitherReportDetails
    {
        public DateTime DateJoined { get; set; }
        public decimal TotalAmount { get; set; }
        public string FullName { get { return LastName + "," + FirstName + (MiddleName ?? ""); } set { } }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public int Year { get; set; }
        public int TitherId { get; set; }
    }
}
