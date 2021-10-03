using System;


namespace MascotaFeliz.App.Dominio
 {
     public class Mascota:Propietario
     {
         public int IdMascota{get;set;}
         public string Nombre{get;set;}
         public float Temperatura{get;set;}
         public float Peso{get;set;}
         public int FreRespiratoria{get;set;}
         public int FreCardiaca{get;set;}
         public string EstadoAnimo{get;set;}
         public string Recomendaciones{get;set;}
         public Propietario Propietario {get;set;}
         public string Especie{get;set;}

         

        
     }

}