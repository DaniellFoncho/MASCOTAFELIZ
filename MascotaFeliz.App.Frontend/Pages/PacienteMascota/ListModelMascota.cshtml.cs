using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MascotaFeliz.App.Persistencia.AppRepositorios;
using MascotaFeliz.App.Dominio;
using MascotaFeliz.App.Persistencia;




namespace MascotaFeliz.App.Frontend.Pages
{

    public class ListModelMascota: PageModel

    {
        private readonly IRepositorioMascotaMemoria  repositorioMascotaMemoria;

        public IEnumerable <Mascota> Mascota {get;set;}

        public ListModelMascota (IRepositorioMascotaMemoria repositorioMascotaMemoria)
        {

            this.repositorioMascotaMemoria = repositorioMascotaMemoria;
            }
         public void OnGet()
        {
            Mascota = repositorioMascotaMemoria.GetAll();
        }

    }
}    

