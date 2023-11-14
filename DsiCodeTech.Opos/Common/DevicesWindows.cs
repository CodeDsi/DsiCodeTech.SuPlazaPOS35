using System;
using System.Drawing.Printing;
using System.IO.Ports;
using System.Linq;

namespace DsiCodeTech.Opos.Common
{
    /// <summary>
    /// Esta clase se encarga de mostrar y proporcionar información acerca de las impresoras
    /// y puertos seriales de las impresoras instaladas en el sistema operativo.
    /// </summary>
    public class DevicesWindows
    {
        public DevicesWindows()
        {
                
        }

        /// <summary>
        /// Este metodo se encarga de obtener los nombres de un puerto serial
        /// </summary>
        /// <returns></returns>
        public static string[] GetPortsCOM() {
            return SerialPort.GetPortNames();
        }

        /// <summary>
        /// Este metodo se encarga de especificar el bit de paridad para un objeto del 
        /// tipo Serial Port
        /// </summary>
        /// <returns></returns>
        public static string[] GetParitys()
        {
            return Enum.GetNames(typeof(Parity));
        }
        /// <summary>
        /// Este metodo se utiliza para identificar los bits de parada
        /// del objeto serial port
        /// </summary>
        /// <returns></returns>
        public static string[] GetStopBits()
        {
            return Enum.GetNames( typeof(StopBits));  
        }

        /// <summary>
        /// Este metodo se encarga de especificar información de como se imprime un documento
        /// incluida la impresora, desde una aplicacion de windows,
        /// de igual forma se encarga de cargar las impresoras instaladas en el sistema operativo
        /// </summary>
        /// <returns></returns>
        public static string[] GetPrintersWindows()
        {
            return PrinterSettings.InstalledPrinters.Cast<string>().ToArray();
        }

    }
}
