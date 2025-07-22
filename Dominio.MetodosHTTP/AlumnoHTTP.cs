namespace Dominio.MetodosHTTP
{
    public abstract class AlumnoHTTP
    {
        public static Alumno BuscarUno(int legajo) {
            var alumno = from a in Alumno.lista
                         where a.Legajo == legajo
                         select a;
            if (alumno.ToList().Count != 0)
            {
                return alumno.First();
            }
            else {
                return null;
            }
            
        }
        public static List<Alumno> Listar()
        {
            var alumnos = from a in Alumno.lista
                         select a;
            return alumnos.ToList();
        }
        public static bool Agregar(Alumno alu) {
            Alumno.lista.Add(alu);
            return true;
        }
        public static bool Actualizar(Alumno alu)
        {
            var alusActualizar = from a in Alumno.lista
                                where a.Id == alu.Id
                                select a;
            Alumno? aluActualizar = alusActualizar.First();
            if (aluActualizar != null)
            {
                aluActualizar.Apellido = alu.Apellido;
                aluActualizar.Nombre = alu.Nombre;
                aluActualizar.Direccion = alu.Direccion;
                return true;
            }
            else {
                return false;
            }

        }
        public static bool Borrar(int id) {
            var alusBorrar = from a in Alumno.lista
                             where a.Id == id
                             select a;
            Alumno? aluBorrar = alusBorrar.First();
            if (aluBorrar != null)
            {
                Alumno.lista.Remove(aluBorrar);
                return true;
            }
            else {
                return false;
            }
        }

    }
}
