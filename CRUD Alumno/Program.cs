using Dominio;
using Dominio.MetodosHTTP;

namespace CRUD_Alumno
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            
            var app = builder.Build();

            app.UseSwagger();
            app.UseSwaggerUI();

            app.MapGet("/", () => "Hello World!");
            app.MapGet("/alumnos/{legajo}", (int legajo) =>
            {
                Alumno alu = AlumnoHTTP.BuscarUno(legajo);
                if (alu != null) {
                    return Results.Ok(alu);
                }
                else { 
                    return Results.NotFound();
                }
            });
            app.MapGet("/alumnos", () => {
                List<Alumno> alumnos = AlumnoHTTP.Listar();
                return Results.Ok(alumnos);
            });
            app.MapPost("/alumnos", (Alumno alu) => {

                Alumno nuevoAlumno = new Alumno(
                        Alumno.ObtenerProxId(),
                        alu.Apellido,
                        alu.Nombre, 
                        alu.Legajo, 
                        alu.Direccion
                    );
                AlumnoHTTP.Agregar(nuevoAlumno);
                return Results.Created($"/alumnos/{nuevoAlumno.Id}",nuevoAlumno);

            });
            app.MapPut("/alumnos", (Alumno alu) => {
                bool existe = AlumnoHTTP.Actualizar(alu);
                if (existe) {
                    return Results.NoContent();
                }
                else
                {
                    return Results.NotFound();
                }

            });
            app.MapDelete("/alumnos/{id}", (int id) =>
            {
                bool existe = AlumnoHTTP.Borrar(id);
                if (existe)
                {
                    return Results.NoContent();
                }
                else
                {
                    return Results.NotFound();
                }
            });

            app.Run();
        }
    }
}
