using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class Mascota
    {
        //MASCOTAS - especie, su nombre, su fecha de nacimiento y su historial de vacunación
        private string nombre;
        private string especie;
        private string fechaNacimiento;
        private int ultimaVacuna;

        //CONSTRUCTORES
        public Mascota(string nombre, string especie, string domicilio, int telefono) 
        {
            this.nombre = nombre;
            this.especie = especie;
            this.fechaNacimiento = domicilio;
            this.ultimaVacuna = telefono;
        }

        //SETTERS
        public void CambiarNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public void CambiarEspecie(string especie)
        {
            this.especie = especie;
        }

        public void CambiarDomicilio(string fechaNacimiento)
        {
            this.fechaNacimiento = fechaNacimiento;
        }
        public void CambiarTelefono(int ultimaVacuna)
        {
            this.ultimaVacuna = ultimaVacuna;
        }


        //GETTERS
        public string ObtenerNombre()
        {
            return $"{this.nombre}";
        }
        public string ObtenerEspecie()
        {
            return $"{this.especie}";
        }
        public string ObtenerFechaNacimiento()
        {
            
            return $"{this.fechaNacimiento}";
        }

        public string ObtenerUltimaVacuna()
        {
            
            return $"{this.ultimaVacuna}";
        }

    }
}
