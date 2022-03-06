using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Reparaciones.Controllers._ctx;
using Reparaciones.Models;
using Reparaciones.DTO;



namespace Reparaciones.Controllers.Celulares
{
    public class celularControlador : entityConnection
    {
        public List<celularesDTO> GetCelulares()
        {
            try
            {
                List<tbl_Celulares> lstCelulares = context.tbl_Celulares.Where(x => x.esReparado == false).ToList();
                List<tbl_Marcas> lstMarcas = context.tbl_Marcas.ToList();
                var lst = lstCelulares.Select(x => new celularesDTO
                {
                    id = x.id,   
                    idMarca = x.idMarca,
                    marca = "",
                    modelo = x.modelo,
                    caracteristicas = x.caracteristicas,
                    esReparado = x.esReparado,
                    esreparado = x.esReparado == true ? "Reparado" : "En reparacion"
                }).ToList();
                foreach (var item in lst)
                {
                    item.marca = lstMarcas.Where(x => x.id == item.idMarca).Select(z => z.marca).FirstOrDefault();
                }
                return lst;
            }
            catch (Exception err)
            {
                return null;
            }
        }

        public tbl_Celulares GuardarCelulares(tbl_Celulares nuevoCelular)
        {
            try
            {
                tbl_Celulares celulares = new tbl_Celulares();      
                celulares.idMarca = nuevoCelular.idMarca;
                celulares.modelo = nuevoCelular.modelo;
                celulares.caracteristicas = nuevoCelular.caracteristicas;
                celulares.esReparado = false;
                context.tbl_Celulares.Add(celulares);
                context.SaveChanges();
                return celulares;
            }
            catch (Exception err)
            {
                return null;                
            }
        }
    }
}