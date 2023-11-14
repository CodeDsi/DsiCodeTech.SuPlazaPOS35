using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DsiCodeTech.Common.DataAccess.Filter.Page;

namespace DsiCodeTech.Common.DataAccess.Filter.Query
{
    public class EstadisticaQuery
    {
        public string CodBarras { get; set; }

        public string CodInterno { get; set; }

        public string Descripcion { get; set; }

        public Guid? IdProveedor { get; set; }

        public DateTime? FechaInicial { get; set; }

        public DateTime? FechaFinal { get; set; }

        public int? Mes { get; set; }

        public int? Anio { get; set; }

        public PageRequest Page { get; set; }

        public DateTime GetInitialDate()
        {
            DateTime current = DateTime.Now;

            if (Mes.HasValue || Anio.HasValue)
            {
                int month = Mes.HasValue ? Mes.Value : DateTime.Now.Month;
                int year = Anio.HasValue ? Anio.Value : DateTime.Now.Year;

                return new DateTime(year: year,
                       month: month,
                       day: 1,
                       hour: 00,
                       minute: 00,
                       second: 00);
            }
            else
            {
                return FechaInicial.HasValue ?
                       new DateTime(year: FechaInicial.Value.Year,
                       month: FechaInicial.Value.Month,
                       day: FechaInicial.Value.Day,
                       hour: FechaInicial.Value.Hour,
                       minute: FechaInicial.Value.Minute,
                       second: FechaInicial.Value.Second) :
                       new DateTime(year: current.Year,
                       month: current.Month,
                       day: current.Day,
                       hour: 00,
                       minute: 00,
                       second: 00);
            }
        }

        public DateTime GetEndDate()
        {
            DateTime current = DateTime.Now;

            if (Mes.HasValue || Anio.HasValue)
            {
                int month = Mes.HasValue ? Mes.Value : DateTime.Now.Month;
                int year = Anio.HasValue ? Anio.Value : DateTime.Now.Year;

                DateTime start = new DateTime(year: year, month: month, day: 1);

                return new DateTime(year: year,
                       month: month,
                       day: start.AddMonths(1).AddDays(-1).Day,
                       hour: 23,
                       minute: 59,
                       second: 59);
            }
            else
            {
                return FechaFinal.HasValue ?
                       new DateTime(year: FechaFinal.Value.Year,
                       month: FechaFinal.Value.Month,
                       day: FechaFinal.Value.Day,
                       hour: FechaFinal.Value.Hour,
                       minute: FechaFinal.Value.Minute,
                       second: FechaFinal.Value.Second) :
                       new DateTime(year: current.Year,
                       month: current.Month,
                       day: current.Day,
                       hour: 23,
                       minute: 59,
                       second: 59);
            }
        }

    }
}
