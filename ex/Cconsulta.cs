using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ex
{
    public class Cconsulta
    {

        private string cadenaconxion = System.Web.Configuration.WebConfigurationManager.
         ConnectionStrings["dbcuentaConnectionString"].
         ConnectionString;

        public DataSet Cfechas(string f1,string f2)
        {
            SqlConnection Ocon = new SqlConnection(cadenaconxion);
            SqlDataAdapter da = new SqlDataAdapter("SELECT    persona.DNI, persona.Nombre,persona.Apellido, Cuentaahorros.NroCuenta, movimientocuenta.FechaRetiro, movimientocuenta.MontoRetirado FROM  persona INNER JOIN   Cuentaahorros ON persona.DNI = Cuentaahorros.DNI INNER JOIN    movimientocuenta ON Cuentaahorros.NroCuenta = movimientocuenta.NroCuenta  where movimientocuenta.FechaRetiro >= '" + f1+"' and movimientocuenta.FechaRetiro <= '"+f2+"' ", Ocon);
            DataSet ds = new DataSet();
            da.Fill(ds, "cfecha");
            return ds;

        }
        public DataSet movimiento()
        {
            SqlConnection Ocon = new SqlConnection(cadenaconxion);
            SqlDataAdapter da = new SqlDataAdapter("SELECT        dbo.persona.DNI, dbo.persona.Nombre, dbo.Cuentaahorros.SaldoApertura, dbo.Cuentaahorros.SaldoMovimiento, dbo.movimientocuenta.NroCuenta, dbo.movimientocuenta.MontoRetirado FROM            dbo.persona INNER JOIN                         dbo.Cuentaahorros ON dbo.persona.DNI = dbo.Cuentaahorros.DNI INNER JOIN                         dbo.movimientocuenta ON dbo.Cuentaahorros.NroCuenta = dbo.movimientocuenta.NroCuenta", Ocon);
            DataSet ds = new DataSet();
            da.Fill(ds, "cfecha");
            return ds;

        }
        public DataSet verificarDni(string dni)
        {
            SqlConnection Ocon = new SqlConnection(cadenaconxion);
            SqlDataAdapter da = new SqlDataAdapter("SELECT  NroCuenta,  dbo.Cuentaahorros.DNI, dbo.Cuentaahorros.FechaApertura, " +
                "dbo.Cuentaahorros.SaldoApertura FROM            dbo.persona INNER JOIN " +
                "                         dbo.Cuentaahorros ON dbo.persona.DNI = dbo.Cuentaahorros.DNI " +
                "WHERE(dbo.Cuentaahorros.DNI = '"+dni+"') ", Ocon);
            DataSet ds = new DataSet();
            da.Fill(ds, "dni");
            return ds;

        }

        public DataSet verificMonto(string dni)
        {
            SqlConnection Ocon = new SqlConnection(cadenaconxion);
            SqlDataAdapter da = new SqlDataAdapter("SELECT        dbo.persona.DNI, dbo.persona.Nombre, dbo.persona.Apellido, dbo.Cuentaahorros.NroCuenta, dbo.Cuentaahorros.FechaApertura, dbo.Cuentaahorros.SaldoApertura FROM            dbo.persona INNER JOIN  " +
                "                         dbo.Cuentaahorros ON dbo.persona.DNI = dbo.Cuentaahorros.DNI" +
                " where persona.DNI="+dni+" ", Ocon);
            DataSet ds = new DataSet();
            da.Fill(ds, "dnis");
            return ds;

        }


        public string retirar(string nc, string m)
        {

            string mensaje;
            int insertados;
            string sql = "insert into values( "+ nc + ",GETDATE()," + m + ")";

            SqlConnection oCon = new SqlConnection(cadenaconxion);
            SqlCommand cmd = new SqlCommand(sql, oCon);
            try
            {
                oCon.Open();
                insertados = cmd.ExecuteNonQuery();
                mensaje = "Nro de registros insertados es " + insertados.ToString();
                return mensaje;
            }
            catch (Exception mm)
            {
                mensaje = "el error es " + mm.Message;
                return mensaje;

            }
            finally
            {
                oCon.Close();
            }

        }

        public string depositar(string dni, string m)
        {

            string mensaje;
            int insertados;
            SqlConnection oCon = new SqlConnection(cadenaconxion);

            
            string sql = "Update Cuentaahorros  set SaldoApertura = SaldoApertura + '" + m + "' WHERE(NroCuenta = '" + dni + "') ";

            
            SqlCommand cmd = new SqlCommand(sql, oCon);
            try
            {
                oCon.Open();
                insertados = cmd.ExecuteNonQuery();
                mensaje = "Nro de registros insertados es " + insertados.ToString();
                return mensaje;
            }
            catch (Exception mms)
            {
                mensaje = "el error es " + mms.Message;
                return mensaje;

            }
            finally
            {
                oCon.Close();
            }

        }

    }
}