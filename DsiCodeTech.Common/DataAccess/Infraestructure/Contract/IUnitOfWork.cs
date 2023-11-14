using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;

namespace DsiCodeTech.Common.DataAccess.Infraestructure.Contract
{
    public interface IUnitOfWork : IDisposable
    {
        /// <summary>
        /// Return the database reference for this UOW
        /// </summary>
        DbContext Db { get; }

        /// <summary>
        /// Consulta que se ejecuta para validar que haya conexión con la base de datos
        /// </summary>
        void KeepAlive();

        /// <summary>
        /// Comando para ejecutar un store procedure dinamicamente
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="spName"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
       // List<T> ExecuteDynamicProcedure<T>(string spName, SqlParameter[] parameters);

        /// <summary>
        /// Comando para ejecutar un store procedure dinamicamente pero que regresa solo un resultado - registro
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="spName"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        //T ExecuteObjectProcedure<T>(string spName, SqlParameter[] parameters);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="command"></param>
        /// <param name="parameters"></param>
        //void ExecuteCommandProcedure(string command, SqlParameter[] parameters);
    }
}
