using Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;


namespace Dsw2026Ej11.Tests;


internal class Ejemplos
{
    //Agregar 3 alumnos a la lista
    //Listar por consola los alumnos
    //Buscar por nombre un alumno que exista y mostrar por consola
    //Buscar por nombre un alumno que no exista y mostrar por consola el texto "No existe"
    //Eliminar un alumno y listar por consola los alumnos
    //Eliminar el primer elemento de la lista y listar por consola los alumnos
    public static void EjemploList()
    {
        CasoList casoList = new CasoList();

        Alumno alumno1 = new Alumno(1, "Pedro", 8.1);
        Alumno alumno2 = new Alumno(2, "Sofia", 9.7);
        Alumno alumno3 = new Alumno(3, "Juan", 6.3);

        casoList.AgregarAlumno(alumno1);
        casoList.AgregarAlumno(alumno2);
        casoList.AgregarAlumno(alumno3);

        Console.WriteLine("Lista de alumnos:");
        MostrarAlumnos(casoList.GetAlumnos());

        Console.WriteLine("Buscar alumno existente:");
        Alumno? buscado = casoList.BuscarPorNombre("Pedro");
        Console.WriteLine(buscado != null ? buscado.ToString() : "No existe");

        Console.WriteLine("Buscar alumno que no existe:");
        Alumno? noExiste = casoList.BuscarPorNombre("Ana");
        Console.WriteLine(noExiste != null ? noExiste.ToString() : "No existe");

        Console.WriteLine("Eliminar un alumno:");
        casoList.EliminarAlumno(alumno2);
        MostrarAlumnos(casoList.GetAlumnos());

        Console.WriteLine("Eliminar el primer elemento:");
        casoList.EliminarAlumnoPorPosicion(0);
        MostrarAlumnos(casoList.GetAlumnos());
    }

    //Agregar 3 alumnos al diccionario
    //Listar por consola los alumnos
    //Buscar un alumno por clave y mostrar por consola
    //Buscar un alumno por clave, pero que no exista, y mostrar por consola el texto "No existe"
    //Eliminar un alumno por clave y listar por consola los alumnos
    public static void EjemploDictionary()
    {
        CasoDictionary casoDictionary = new CasoDictionary();

        Alumno alumno1 = new Alumno(1, "Pedro", 8.1);
        Alumno alumno2 = new Alumno(2, "Sofia", 9.7);
        Alumno alumno3 = new Alumno(3, "Juan", 6.3);

        casoDictionary.AgregarAlumno(alumno1);
        casoDictionary.AgregarAlumno(alumno2);
        casoDictionary.AgregarAlumno(alumno3);

        Console.WriteLine("Diccionario de alumnos:");
        MostrarAlumnos(casoDictionary.GetAlumnos().Values);

        Console.WriteLine("Buscar alumno por clave existente:");
        Alumno? buscado = casoDictionary.BuscarPorClave(1);
        Console.WriteLine(buscado != null ? buscado.ToString() : "No existe");

        Console.WriteLine("Buscar alumno por clave que no existe:");
        Alumno? noExiste = casoDictionary.BuscarPorClave(99);
        Console.WriteLine(noExiste != null ? noExiste.ToString() : "No existe");

        Console.WriteLine("Eliminar alumno por clave:");
        casoDictionary.EliminarAlumno(2);
        MostrarAlumnos(casoDictionary.GetAlumnos().Values);
    }

    //Realizar una llamada a cada método definido en CasoLinq y mostar por consola según corresponda
    public static void EjemploLinq()
    {
        CasoLinq casoLinq = new CasoLinq();

        Console.WriteLine("Primer libro:");
        MostrarLibro(casoLinq.GetPrimero());

        Console.WriteLine("Último libro:");
        MostrarLibro(casoLinq.GetUltimo());

        Console.WriteLine($"Suma total de precios: {casoLinq.GetTotalPrecios():C}");

        Console.WriteLine($"Promedio de precios: {casoLinq.GetPromedioPrecios():C}");

        Console.WriteLine("Libros con Id mayor a 15:");
        MostrarLibros(casoLinq.GetListById());

        Console.WriteLine("Lista de libros con título y precio:");
        foreach (string libro in casoLinq.GetLibros())
        {
            Console.WriteLine(libro);
        }

        Console.WriteLine("Libro con mayor precio:");
        MostrarLibro(casoLinq.GetMayorPrecio());

        Console.WriteLine("Libro con menor precio:");
        MostrarLibro(casoLinq.GetMenorPrecio());

        Console.WriteLine("Libros con precio mayor al promedio:");
        MostrarLibros(casoLinq.GetMayorPromedio());

        Console.WriteLine("Libros ordenados por título descendente:");
        MostrarLibros(casoLinq.GetLibrosOrdenadosDescendente());
    }

    private static void MostrarAlumnos(IEnumerable<Alumno> alumnos)
    {
        foreach (Alumno alumno in alumnos)
        {
            Console.WriteLine(alumno);
        }

        Console.WriteLine();
    }

    private static void MostrarLibro(Libro libro)
    {
        Console.WriteLine($"{libro.Id} - {libro.Titulo} - {libro.Precio:C}");
        Console.WriteLine();
    }
    private static void MostrarLibros(IEnumerable<Libro> libros)
    {
        foreach (Libro libro in libros)
        {
            Console.WriteLine($"{libro.Id} - {libro.Titulo} - {libro.Precio:C}");
        }

        Console.WriteLine();
    }
}
