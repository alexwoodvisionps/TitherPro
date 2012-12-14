using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Woodensoft.TitherPro.Domain.Contexts;
namespace Woodensoft.TitherPro.Domain.Models
{
    public class TitherReport
    {
        public Tither MaxTither { get; set; }
        public Tither MinTither { get; set; }
        public decimal MaxTithe { get; set; }
        public decimal MinTithe { get; set; }
        public decimal TotalTithes { get; set; }

    }
}
