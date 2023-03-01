using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    public class Equipo
    {
        private string nombre;
        private string universidad;
        private string lenguage;
        private List<Programador> miembros;

        public Equipo(string nombre, string universidad, string lenguage)
        {
            this.nombre = nombre;
            this.universidad = universidad;
            this.lenguage = lenguage;
        }

        public bool equipoCompleto()
        {
            return miembros.Count == 3;
        }

        public void anyadirProgramador(Programador p)
        {
            try
            {
                if (equipoCompleto())
                {
                    throw new Exception("Equipo lleno");
                }
                miembros.Add(p);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }

    public class Programador
    {
        private string nombre;
        private string apellidos;

        public Programador(string nombre, string apellidos)
        {
            Nombre = nombre;
            Apellidos = apellidos;
        }

        public string Nombre
        {
            get => nombre; set
            {
                if (!value.All(char.IsLetter) || value.Length >= 20)
                {
                    throw new Exception("Nombre incorrecto");
                }
                nombre = value;
            }
        }
        public string Apellidos
        {
            get => apellidos; set
            {
                if(!value.All(char.IsLetter) || value.Length >= 20)
                {
                    throw new Exception("Apellidos incorrectos");
                }
                apellidos = value;
            }
        }
    }
}
