using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cintera.DAL
{
    public class Case
    {
        public int CaseId { get; set; }

        public virtual ICollection<Vehicle> Vehicles { get; set; }
        public virtual ICollection<Sighting> Signtings { get; set; }
    }

    public class Vehicle
    {
        public int VehicleId { get; set; }
        public int CaseId { get; set; }
        public virtual Case Case { get; set; }
        public string VehicleIdentificationNumber { get; set; }

    }

    public class Sighting
    {
        public int SightingId { get; set; }
        public int CaseId { get; set; }
        public virtual Case Case { get; set; }

        public string Address { get; set; }
        public DateTime Date { get; set; }

    }
}
