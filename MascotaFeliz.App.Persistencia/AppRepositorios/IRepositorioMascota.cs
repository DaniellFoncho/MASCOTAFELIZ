
using System;
using System.Collections.Generic;
using System.Linq;
using MascotaFeliz.App.Dominio;


namespace MascotaFeliz.App.Persistencia.AppRepositorios
{
    public interface IRepositorioMascota
    {
        IEnumerable<Mascota> GetAllMascota();
        Mascota AddMascota(Mascota mascota);
       
        Mascota UpdateMascota(Mascota mascota, int idMascota_original);//modificada por mi para que funcionara
        void DeleteMascota(int idMascota);    
        Mascota GetMascota(int idMascota);
        //Veterinario AsignarVeterinario(int idMascota, int idVeterinario); 


    }


}