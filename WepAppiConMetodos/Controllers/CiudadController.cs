using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WepAppiConMetodos.ServicioRest;

namespace WepAppiConMetodos.Controllers
{
    public class CiudadController : ApiController
    {
        ServiciosMovil sm = new ServiciosMovil();

        public List<string> GetObtenerCategorias()
        {
            List<string> l = new List<string>();
            string[] cate = sm.ObtenerCategorias();
            foreach (string a in cate)
            {
                l.Add(a);
            }
            return l;
        }

        [HttpPost]
        public string PostSubirFoto(string latitud, string longitud, string imageb64, string categoria)
        {
            return "a";
            //return sm.CrearDenunciaPorFoto(latitud.Trim(), longitud.Trim(), categoria, imageb64);
        }
    }
}
