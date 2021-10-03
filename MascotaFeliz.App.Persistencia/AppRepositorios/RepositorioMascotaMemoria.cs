using System.Collections.Generic;
using MascotaFeliz.App.Dominio;



namespace MascotaFeliz.App.Persistencia.AppRepositorios
{   
    public class RepositorioMascotaMemoria : IRepositorioMascotaMemoria
    {
        List<Mascota> mascota;

        public RepositorioMascotaMemoria()
        {   
            mascota = new List<Mascota>()

            {
                new Mascota{IdMascota=1, Nombre = "max", Temperatura = 21, Peso = 32, FreRespiratoria = 2},
                new Mascota  {IdMascota=2, Nombre = "otto", Temperatura = 31, Peso = 34, FreRespiratoria = 22},
                new Mascota  {IdMascota=3, Nombre = "fidel", Temperatura = 41, Peso = 22, FreRespiratoria = 12},
                new Mascota  {IdMascota=4, Nombre = "oso", Temperatura = 21, Peso = 12, FreRespiratoria = 12}
                };

            }


        public IEnumerable<Mascota> GetAll()
        {
            return mascota; 
            
                }
                }
        }