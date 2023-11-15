using DsiCodeTech.Builder.Generic;
using DsiCodeTech.Opos.Manager;
using DsiCodeTech.Opos.Recursos;
using Microsoft.PointOfService;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DsiCodeTech.Opos.Common
{
    public class DevicesOPOS
    {
        private static readonly NLog.Logger logger = LogManager.GetCurrentClassLogger();

        private PosExplorer posExplorer;

        private CashDrawer cashDrawer;

        private PosPrinter printer;

        private Scanner scanner;

        private LineDisplay display;

        public DevicesOPOS()
        {
            this.OpenDevicesOpos();
        }

        #region Apertura de Dispositivos
        private void OpenDevicesOpos()
        {
            this.OpenCashDrawer(true,"algo");
            this.OpenDisplay(true,"algo");
        }
        #endregion

        #region Cerrar-Dispositivos
        private void CloseDevicesOpos()
        {
           
        }
        #endregion


        #region OpenDevices
        /// <summary>
        /// Este metodo se encarga de Abrir el Cajon como Dispositivo
        /// </summary>
        /// <param name="enable"></param>
        /// <param name="nameDeviceType"></param>
        /// <exception cref="Exception"></exception>
        private void OpenCashDrawer(bool enable, string nameDeviceType)
        {
            if (enable)
            {
                logger.Info($"Se Inicializa el Proceso de Instancia para el CashDrawer");
                DeviceInfo deviceInfo= GetDeviceInfo(DeviceType.CashDrawer, nameDeviceType);
                if (deviceInfo == null) 
                {
                    logger.Error($"Ocurrio un Error al momento de Cargar el CashDrawer: {nameDeviceType}");
                    throw new Exception(nameDeviceType + " no se pudo localizar");
                }
                this.cashDrawer = (CashDrawer)posExplorer.CreateInstance(deviceInfo);
                ///Abre el cajon despues del procesamientro de un flujo de entrada/salida
                this.cashDrawer.Open();
                //tiempo de acceso  en un dsipositivo (cajon) para abrir
                this.cashDrawer.Claim(5000);
                this.cashDrawer.DeviceEnabled = enable;
                logger.Info($"Se Finaliza el proceso para la Instancia CashDrawer:  {this.cashDrawer}");
            }
        }

        private void OpenDisplay(bool enable, string nameDeviceType)
        {
            try
            {
                logger.Info(MessageResources.LoggerInicialize + $"{nameDeviceType}");
                if (enable)
                {
                    DeviceInfo deviceInfo = GetDeviceInfo("LineDisplay", nameDeviceType);
                    if (deviceInfo == null)
                    {
                        throw new BusinessException(MessageResources.LoggerError + nameDeviceType);
                    }
                    display = (LineDisplay) posExplorer.CreateInstance(deviceInfo);
                    display.Open();
                    display.Claim(200);
                    display.DeviceEnabled = enable;
                    logger.Info(MessageResources.LoggerFinalice+$"{nameDeviceType}");

                }
            }
            catch (PosException ex)
            {
                logger.Error (ex.Message);  
                logger.Error(MessageResources.LoggerError + $"{nameDeviceType}");
                throw new BusinessException(MessageResources.LoggerError + nameDeviceType);
            }
        }


        private void OpenPrinter(bool enable, string nameDeviceType)
        {
            try
            {

            }
            catch (PosException ex)
            {

                
            }
        }




        #endregion

        private DeviceInfo GetDeviceInfo(string deviceType, string nameDeviceType)
        {
            DeviceInfo result = null;
            //el metodo GetDevices regresa todos los  devices esepcificados y su tipo
            DeviceCollection devices = posExplorer.GetDevices(deviceType);
            foreach (DeviceInfo device in devices) 
            {
                if (device.ServiceObjectName == nameDeviceType)
                {
                    return device;
                }
            }
            return result;
        }

    }
}
