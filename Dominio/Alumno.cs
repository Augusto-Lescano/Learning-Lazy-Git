using System.ComponentModel;

namespace Dominio
{
    public class Alumno
    {
        public int Id { set;get; }
        public string Apellido { set; get; }
        public string Nombre { set;get; }

        public int Legajo { set; get; }

        public string Direccion { set; get; }

        public static readonly List<Alumno> lista = new List<Alumno> {
            new Alumno(1,"Lescano", "Augusto", 50422, "guasca 355"),
            new Alumno(2,"Lescano", "Sergio", 50423, "guasca 355"),
            new Alumno(3, "Lucía", "Gómez", 34567, "Avenida Siempreviva 742"),
            new Alumno(4, "Carlos", "Monzón", 45678, "Mitre 101"),
            new Alumno(5, "María", "Fernández", 56789, "Belgrano 202"),
            new Alumno(6, "Ana", "Sánchez", 67890, "San Martín 303"),
            new Alumno(7, "Diego", "Martínez", 78901, "Urquiza 404"),
            new Alumno(8, "Jorge", "López", 89012, "Rivadavia 505"),
            new Alumno(9, "Sofía", "Díaz", 90123, "Laprida 606"),
            new Alumno(10, "Camila", "Silva", 12345, "Saavedra 707")
        };


        public static int ObtenerProxId() {
            if (lista.Count == 0) {
                return 1;
            }
            else {
                var idsAlumnos = from l in lista
                                orderby l.Id descending
                                select l.Id;
                int ultId = idsAlumnos.First();
                return ultId + 1;
            }
        
        }

        public Alumno(int id, string apellido, string nombre, int legajo, string direccion)
        {
            Id = id;
            Apellido = apellido;
            Nombre = nombre;
            Legajo = legajo;
            Direccion = direccion;
        }

        
    }
}
