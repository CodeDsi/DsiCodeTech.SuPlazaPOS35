using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DsiCodeTech.Common.DataAccess.Filter.Page;

namespace DsiCodeTech.Common.DataAccess.Filter.Query
{
    public class CompraQuery
    {
        public Guid? IdProveedor { get; set; }

        public string Observacion { get; set; }

        public DateTime? FechaInicial { get; set; }

        public DateTime? FechaFinal { get; set; }

        public bool IsAbierta { get; set; }

        public PageRequest Page { get; set; }

        public DateTime? GetInitialDate()
        {
            return FechaInicial.HasValue ?
                        new DateTime(year: FechaInicial.Value.Year,
                        month: FechaInicial.Value.Month,
                        day: FechaInicial.Value.Day,
                        hour: 00,
                        minute: 00,
                        second: 00) :
                        null;
        }

        public DateTime? GetEndDate()
        {
            return FechaFinal.HasValue ?
                       new DateTime(year: FechaFinal.Value.Year,
                       month: FechaFinal.Value.Month,
                       day: FechaFinal.Value.Day,
                       hour: 23,
                       minute: 59,
                       second: 59) : null;
        }

        public bool HasInicialValue() => FechaInicial.HasValue;

        public bool HasFinalValue() => FechaFinal.HasValue;
    }
}
