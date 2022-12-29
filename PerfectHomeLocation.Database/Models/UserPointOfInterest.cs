using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfectHomeLocation.Database.Models
{
    public class UserPointOfInterest
    {
        public long UserId { get; set; }

        public int PointOfInterestTypeId { get; set; }

        public virtual User User { get; set; }

        public virtual PointOfInterestType PointOfInterestType { get; set; }
    }
}
