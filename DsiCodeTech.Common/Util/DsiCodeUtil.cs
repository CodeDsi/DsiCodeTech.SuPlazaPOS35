using DsiCodeTech.Common.Constant;
using DsiCodeTech.Common.DataAccess.Domain;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DsiCodeTech.Common.Util
{
    public sealed class DsiCodeUtil
    {
        private static readonly object _dsiLock = new object();
        private static DsiCodeUtil _instance = null;

        private DsiCodeUtil() { }

        public static DsiCodeUtil Connection
        {
            get
            {
                lock (_dsiLock)
                {
                    if (_instance is null)
                    {
                        _instance = new DsiCodeUtil();
                    }

                    return _instance;
                }
            }
        }

        /// <summary>
        /// Trunca los valores a N posiciones para decimales
        /// </summary>
        /// <param name="positions"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static decimal DecimalTruncate(short positions, decimal value)
        {
            return Math.Round(Math.Round(value, positions, MidpointRounding.ToEven), 2, MidpointRounding.ToEven);
        }

        /// <summary>
        /// Recibe un arreglo de valores, regresa true si  alguno de los valores no cumple, no si todos los valores cumplen la expresión regular
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public static bool IsDecimal(params string[] args)
        {
            return args.Any(x => !Regex.IsMatch(x, DsiCodeConst.PATTERN_DECIMAL));
        }

        /// <summary>
        /// Recibe un arreglo de valores, regresa true si  alguno de los valores es vacio o null, no si todos los valores son informados
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public static bool IsNull(params string[] args)
        {
            return args.Any(x => string.IsNullOrEmpty(x));
        }

        /// <summary>
        /// Recibe un listado de argumentos a evaluar, si alguno de los valores es diferente de null o vacio, retorna un true
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public static bool IsAnyNotNullOrEmpty(params string[] args)
        {
            return args.Any(x => !string.IsNullOrEmpty(x));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string TitleCase(string value)
        {
            if (IsNull(value)) return null;
            TextInfo text = new CultureInfo("es-MX", false).TextInfo;
            return text.ToTitleCase(value.ToLower());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string AsC2(decimal value)
        {
            return value.ToString("C2");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string AsG9(decimal value)
        {
            return value.ToString("G9");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static decimal AsC2Number(decimal value)
        {
            return decimal.Parse(value.ToString("C2"));
        }

        public static decimal Subtotal(decimal precio_impuestos, decimal utilidad)
        {
            //return Math.Round(Round6Positions(precio_impuestos / (1 - (utilidad / 100))), 3);

            return Math.Round(Round6Positions(precio_impuestos + (precio_impuestos * utilidad / 100)), 2);
        }

        public static decimal Ieps(decimal subtotal, decimal ieps)
        {
            return ieps > 0 ? Math.Round(Round6Positions(subtotal * (ieps / 100)), 2) : 0;
        }

        public static decimal Iva(decimal subtotal, decimal ieps_desglosado, decimal iva)
        {
            return iva > 0 ? Math.Round(Round6Positions((subtotal + ieps_desglosado) * (iva / 100)), 2) : 0;
        }

        public static decimal Sum(params decimal[] values)
        {
            return values.Aggregate(0.0m, (total, value) => total + value);
        }

        public static decimal GetTotalIva(decimal totalVenta, decimal iva)
        {
            decimal subtotal = Round6Positions(totalVenta / (1 + iva));
            return Round6Positions(subtotal * iva);
        }

        public static decimal GetTotalIeps(decimal totalVenta, decimal ieps)
        {
            decimal subtotal = Round6Positions(totalVenta / (1 + ieps));
            return Round6Positions(subtotal * ieps);
        }

        public static decimal GetDiscount(decimal totalVenta, decimal descuento)
        {
            return Round6Positions(totalVenta * descuento);
        }

        public static decimal GetSubtotal(decimal totalVenta, decimal iva, decimal ieps)
        {
            return Round6Positions(totalVenta - iva - ieps);
        }

        public static decimal Round2Positions(decimal value)
        {
            return Math.Truncate(value * 100) / 100;
        }

        public static decimal Round6Positions(decimal value)
        {
            return Math.Round(value, 6);
        }
    }
}
