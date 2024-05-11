using ProyectoMongo2024;

Alumno alumno = new Alumno();
alumno.Nombre = "Conrado";
alumno.Apellido = "Quezada";
alumno.Matricula = "159357";
alumno.Grupo = "scomm61";

Console.WriteLine("Insertando un elemento");
alumno.Agregar(alumno);
Console.WriteLine("Elemento agregado");