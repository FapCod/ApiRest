using ApiRest.Datos;
using ApiRest.Models;
using ApiRest.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace ApiRest.Controllers
{
    public class TareaController : ApiController
    {
        // GET: Tarea
        public IEnumerable<TAREA> Get()
        {
            Service1Client client = new ConexionConWCF().ConexionWCF();
            var lista = client.ObtenerTareas();
            return lista;
        }

        // GET: Tarea/Details/5

        // POST: Tarea/Create
        public void Post([FromBody]Tarea tarea)
        {
            try
            {
                Service1Client client = new ConexionConWCF().ConexionWCF();
                TAREA t = new TAREA();
                t.ID = tarea.ID;
                t.TITULO = tarea.TITULO;
                t.NOTAS = tarea.NOTAS;
                t.ESTADO = tarea.ESTADO;
                t.PRIORIDAD = tarea.PRIORIDAD;
                t.FECHA_CREACION = tarea.FECHA_CREACION;
                t.FECHA_TERMINO = tarea.FECHA_TERMINO;
                client.InsertarTarea(t);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
            
        }

        // PUT: Tarea/Edit/5
        public void Put([FromBody] Tarea tarea)
        {
            try
            {
                Service1Client client = new ConexionConWCF().ConexionWCF();
                TAREA t = new TAREA();
                t.ID = tarea.ID;
                t.TITULO = tarea.TITULO;
                t.NOTAS = tarea.NOTAS;
                t.ESTADO = tarea.ESTADO;
                t.PRIORIDAD = tarea.PRIORIDAD;
                t.FECHA_CREACION = tarea.FECHA_CREACION;
                t.FECHA_TERMINO = tarea.FECHA_TERMINO;
                client.EditarTarea(t);

            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
        }

        // DELETE: Tarea/Delete/5
        public void Delete(int id)
        {
            try
            {
                Service1Client client = new ConexionConWCF().ConexionWCF();
                client.EliminarTarea(id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }


        }
    }
}
