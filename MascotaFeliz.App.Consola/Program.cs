using System;
using MascotaFeliz.App.Dominio;
using MascotaFeliz.App.Persistencia;
using System.Collections.Generic;

namespace MascotaFeliz.App.Consola
{
    class Program
    {
        private static IRepositorioDueno _repoDueno = new RepositorioDueno(new Persistencia.AppContext());
        private static IRepositorioVeterinario _repoVeterinario = new RepositorioVeterinario(new Persistencia.AppContext());
        private static IRepositorioMascota _repoMascota = new RepositorioMascota(new Persistencia.AppContext());
        //private static IRepositorioHistoria _repoHistoria = new RepositorioHistoria(new Persistencia.AppContext());
        //private static IRepositorioVisitaPyP _repoVisitaPyP = new RepositorioVisitaPyP(new Persistencia.AppContext());
        static void Main(string[] args)
        {
            Console.WriteLine("Hola amigos vamos a empezar a trabajar con las tablas");
                       
            //ListarDuenosFiltro();      
            //AddDueno();
            //AddMascota();
            //AddVeterinario();
            //BuscarDueno(5);
            //BuscarMascota(3);
            ListarMascota();

            //ListarVeterinariosFiltro();
            //AddVeterinario();
            //BuscarVeterinario(1);
            //AddHistoria();            

        }

        private static void AddDueno()
        {
            var dueno = new Dueno
            {
                Nombres = "Luis",
                Apellidos = "Boom", 
                Direccion = "Calle 123 456",
                Telefono = "111258258",
                Correo = "pablo@gmail.com"
            };
            _repoDueno.AddDueno(dueno);
        }

        private static void AddVeterinario()
        {
            var veterinario = new Veterinario
            {
                Nombres = "Tatiana ",
                Apellidos = "Ramirez", 
                Direccion = "Manzana 120 567g",
                Telefono = "kra 22",
                TarjetaProfesional = "TP123456"
            };
            _repoVeterinario.AddVeterinario(veterinario);
        }

        private static void AddMascota()
        {
            var mascota = new Mascota
            {
                Nombre = "Radna",
                Color = "Blanco ", 
                Especie = "Canino",
                Raza = "Pincher"
                
            };
            _repoMascota.AddMascota(mascota);
        }

         private static void BuscarDueno(int idDueno)
         {
            var dueno = _repoDueno.GetDueno(idDueno);
         Console.WriteLine(dueno.Nombres + " " + dueno.Apellidos + " " + dueno.Direccion + " "+ dueno.Telefono + "" );

         }

         private static void ListarDueno()
         {
            var duenos = _repoDueno.GetAllDuenos();
            foreach (Dueno  d in duenos)
            {
                Console.WriteLine(d.Nombres + "   " + d.Apellidos);
            }
          
         }
         
         private static void BuscarMascota(int idMascota)
         {
            var mascota = _repoMascota.GetMascota(idMascota);
         Console.WriteLine(mascota.Nombre + "   " + mascota.Color + "   " + mascota.Especie + "   " + mascota.Raza );

         }

         private static void ListarMascota()
         {
            var mascotas = _repoMascota.GetAllMascotas();
            foreach (Mascota  d in mascotas)
            {
                Console.WriteLine(d.Nombre + "   " + d.Color + "   " + d.Especie);
            }
        }
    }
}