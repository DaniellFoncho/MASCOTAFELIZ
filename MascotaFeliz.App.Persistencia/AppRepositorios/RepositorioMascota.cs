using System.Collections.Generic;
using System.Linq;
using MascotaFeliz.App.Dominio;

namespace MascotaFeliz.App.Persistencia.AppRepositorios
{

    public class RepositorioMascota : IRepositorioMascota
    {
        /// <summary>
        /// Referencia al contexto de Paciente
        /// </summary>
        private readonly AppContext _appContext;
        /// <summary>
        /// Metodo Constructor Utiiza 
        /// Inyeccion de dependencias para indicar el contexto a utilizar
        /// </summary>
        /// <param name="appContext"></param>//
        public RepositorioMascota(AppContext appContext)
        {
            _appContext = appContext;
        }


        Mascota IRepositorioMascota.AddMascota(Mascota mascota)
        {
            var mascotaAdicionado = _appContext.Mascota.Add(mascota);
            _appContext.SaveChanges();
            return mascotaAdicionado.Entity;

        }

        void IRepositorioMascota.DeleteMascota(int idMascota)
        {
            var mascotaEncontrado = _appContext.Mascota.FirstOrDefault(p => p.Id == idMascota);
            if (mascotaEncontrado == null)
                return;
            _appContext.Mascota.Remove(mascotaEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<Mascota> IRepositorioMascota.GetAllMascota()
        {
            return _appContext.Mascota;
        }

        Mascota IRepositorioMascota.GetMascota(int idMascota)
        {
            return _appContext.Mascota.FirstOrDefault(p => p.Id == idMascota);
        }

        
        Mascota IRepositorioMascota.UpdateMascota(Mascota mascota, int idMascota_original)  
        {
            
            var mascotaEncontrado = _appContext.Mascota.FirstOrDefault(p => p.Id == idMascota_original);
            if (mascotaEncontrado != null)
            {
                mascotaEncontrado.Nombre = mascota.Nombre;
                mascotaEncontrado.Temperatura = mascota.Temperatura;
                mascotaEncontrado.Peso = mascota.Peso;
                mascotaEncontrado.FreRespiratoria = mascota.FreRespiratoria;
                mascotaEncontrado.FreCardiaca = mascota.FreCardiaca;
                mascotaEncontrado.EstadoAnimo = mascota.EstadoAnimo;
                mascotaEncontrado.Recomendaciones = mascota.Recomendaciones;
                mascotaEncontrado.Propietario = mascota.Propietario;
                mascotaEncontrado.Especie = mascota.Especie;
                

                _appContext.SaveChanges();


            }
            return mascotaEncontrado;
        }

        
        //Veterinario IRepositorioMascota.AsignarVeterinario(int idMascota, int idVeterinario)
        //{
        //    var mascotaEncontrado = _appContext.Mascota.FirstOrDefault(p => p.Id == idMascota);
        //    if (mascotaEncontrado != null)
        //    {
        //        var veterinarioEncontrado = _appContext.idVeterinario.FirstOrDefault(m => m.Id == idVeterinario);
        //        if (veterinarioEncontrado != null)
        //        {
        //            mascotaEncontrado.idVeterinario = veterinarioEncontrado;
        //            _appContext.SaveChanges();
        //        }
        //        return veterinarioEncontrado;
        //    }
        //    return null;

        //}
    }
}