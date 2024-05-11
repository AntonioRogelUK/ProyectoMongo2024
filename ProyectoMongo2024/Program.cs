using ProyectoMongo2024;

Alumno alumno = new Alumno();
alumno.Nombre = "Conrado";
alumno.Apellido = "Quezada";
alumno.Matricula = "159357";
alumno.Grupo = "scomm62";

//Console.WriteLine("Insertando un elemento");
//alumno.Agregar(alumno);
//Console.WriteLine("Elemento agregado");

//Alumno alumnoPorMatricula = new Alumno();
//alumnoPorMatricula = alumnoPorMatricula.ConsultarPorMatricula("159357");
//if (alumnoPorMatricula != null)
//{
//    Console.WriteLine(alumnoPorMatricula.Nombre);
//}

//Alumno alumnoEditar = new Alumno();
//alumnoEditar = alumnoEditar.ConsultarPorMatricula("123456");
//alumnoEditar.Grupo = "scomm61";
//alumnoEditar.Actualizar("123456", alumnoEditar);

//Alumno alumnoEditar = new Alumno();
//alumnoEditar.Eliminar("159357");

Console.WriteLine(alumno.ToString());
