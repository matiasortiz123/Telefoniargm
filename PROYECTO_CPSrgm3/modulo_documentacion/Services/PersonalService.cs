using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using modulo_documentacion.Areas.Albacea.Models;
using modulo_documentacion.Models;

namespace modulo_documentacion.Services
{
    public class PersonalService
    {
        public SqlConnection _connection;

        public PersonalService()
        {
            _connection = new SqlConnection("data source=10.190.16.54;initial catalog=tacoin;user id=sa;password=Cps@2019");
        }

        /*Persona*/
        /// <summary>
        /// Busca persona por dni
        /// </summary>
        /// <param >dni de la persona</param>
        /// <returns>Persona</returns>
        
        [HttpGet]
        public PersonaAlbacea ObtenerPersonaAlbacea(int dni)
        {
            _connection.Open();
            string query = $"select * from openquery(mysql_prod, 'select `dni`, `apellido`, `nombre`,`grado`,`cod_unidad` from tablas_comunes.usuarios_siam_autorizados where dni=" + dni + "')";

            SqlDataAdapter da = new SqlDataAdapter(query, _connection);

            //adapter.SelectCommand = new SqlCommand(
            DataSet dataSet = new DataSet();
            da.Fill(dataSet);

            var personaAlbacea = new PersonaAlbacea();
            DataTable respuesta = dataSet.Tables[0];
            if (Convert.ToInt32(respuesta.Rows.Count) > 0)
            {
                personaAlbacea.dni = Convert.ToInt32(respuesta.Rows[0]["dni"]);
                personaAlbacea.Apellido = respuesta.Rows[0]["apellido"].ToString();
                personaAlbacea.Nombre = respuesta.Rows[0]["nombre"].ToString();
                personaAlbacea.Grado = respuesta.Rows[0]["grado"].ToString();
                personaAlbacea.Unidad = respuesta.Rows[0]["cod_unidad"].ToString();
            }
            _connection.Close();
            personaAlbacea.AbreviaturaUnidad = ObtenerDescripUnidad(personaAlbacea.Unidad);
            return personaAlbacea;
        }
        [HttpGet]
        public string ObtenerDescripUnidad(string cod_unidad = null)
        {
            string unidad = "";
            if (cod_unidad != null)
            {
                _connection.Open();
                string query = $"select * from openquery(mysql_prod, 'select `abreviatura` from tablas_comunes.vista_unidades_personal";
                query += " where cod_unidad = \"" + cod_unidad + "\"')";
                SqlDataAdapter da = new SqlDataAdapter(query, _connection);

                //adapter.SelectCommand = new SqlCommand(
                DataSet dataSet = new DataSet();
                da.Fill(dataSet);


                DataTable respuesta = dataSet.Tables[0];
                if (Convert.ToInt32(respuesta.Rows.Count) > 0)
                {
                    unidad = respuesta.Rows[0]["abreviatura"].ToString();
                }
                _connection.Close();
            }

            return unidad;
        }

    }
}
