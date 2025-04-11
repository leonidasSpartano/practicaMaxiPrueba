// REFERENCIAS
using System;
using System.ComponentModel.Design.Serialization;
using System.Diagnostics;
using System.Globalization;
using Ejemplo1.Model;
using Ejemplo1.PModel;

//Declaraciones GLOBALES
Menu menu;
List<Libro> listaDeLibros;
InitComponent();

void listarLibros()
{
    Console.WriteLine("-------Lista de Libros------");
    Console.WriteLine("| ID | Titulo | Autor | Genero | ISBN |");

    foreach (Libro libro in listaDeLibros)
    {
        Console.WriteLine(libro);
    }

    Console.WriteLine("---------------------------------");
}

int ObtenerPosicion(List<Item> lista, int opcion)
{
    int posicion = -1;
    foreach (Item item in lista)
    {
        if (opcion == item.IdOpcion)
        {
            posicion = item.IdOpcion;
            break;
        }
    }
    return posicion;
}

Libro crearLibro()
{

    foreach (Libro obj in listaDeLibros) { }
   
    
    Libro libro = new Libro();
    int id = libro.Id +1;
    id = +1;
    int id2 = id +1;
    libro.Id = id2;
    Console.WriteLine(id2+" <- esta es la id que esta ahora");
    Console.Write("Ingresar el titulo del libro: ");
    string tituloLibro = Console.ReadLine();
    libro.Titulo = tituloLibro;

    Console.Write("Ingresar el autor del libro: ");
    string autorLibro = Console.ReadLine();
    libro.Autor = autorLibro;

    Console.Write("Ingresar el genero del libro: ");
    string generoLibro = Console.ReadLine();
    libro.Genero = generoLibro;

    Console.Write("Ingresar el isbn del libro: ");
    string isbnLibro = Console.ReadLine();
    libro.Isbn = isbnLibro;

    return libro;
}



// Ejecucion

bool run = true;
while (run)
{
    Console.WriteLine(menu);
    Console.Write("Ingrese una opción: ");
    string txt = Console.ReadLine();

    /// VALIDACION
    int opcion = int.Parse(txt);
   
    ////
    Console.Clear();
    //string label = ObtenerOpcionTxt(menu.Opciones, opcion);
    string alternativa = menu.Opciones[ObtenerPosicion(menu.Opciones, opcion)].Label;
    Console.WriteLine($"La opcion ingresada es: {opcion} | {alternativa}"); ////???limpiar pantalla
    switch (opcion)
    {
        case 0:
            Console.WriteLine("Saliendo con tu mamita...");
            run = false;
            break;
        case 1:
            Console.WriteLine("Agregar");
            //Libro libro = crearLibro();
            Console.Write("Ingrese el titulo del libro: "); string titulo =Console.ReadLine();
            Console.WriteLine("");
            Console.Write("Ingrese el titulo del autor: "); string autor = Console.ReadLine();
            Console.WriteLine("");
            Console.Write("Ingrese el titulo del genero "); string genero = Console.ReadLine();
            Console.WriteLine("");
            Console.Write("Ingrese el titulo del isbn: "); string isbn = Console.ReadLine();

            AgregarLibro(titulo,autor,genero,isbn);
            break;
        case 2:
            Console.WriteLine("Eliminar");
            listarLibros();
            Console.Write("Ingrese el id del libro que desea eliminar: ");
           
            int idLibro = int.Parse(Console.ReadLine());
            Libro libroEliminar = listaDeLibros.FirstOrDefault(l => l.Id == idLibro);   
            if (libroEliminar != null)
            {
                listaDeLibros.Remove(libroEliminar);
                Console.WriteLine("se elemino el libro con la id "+libroEliminar.Id+ "con el titulo "+ libroEliminar.Titulo);
            }
            else
            {
                Console.WriteLine("No se contro la id del libro ");
            }



                //listaDeLibros.Remove();
                break;
        case 3:
            Console.WriteLine("Modificar");
            listarLibros();
            Console.WriteLine("Ingrese el id del libro que desea modificar: ");
            int idLibroM = int.Parse(Console.ReadLine());

            Libro libroM = listaDeLibros.FirstOrDefault(l => l.Id == idLibroM);

            if (libroM != null)
            {
                Console.Write("ingrese el Titulo :");  
                libroM.Titulo = Console.ReadLine();

                Console.Write("ingrese el  Autor:");
                libroM.Autor = Console.ReadLine();

                Console.Write("ingrese el genero :");
                libroM.Genero = Console.ReadLine();

                Console.Write("ingrese el Isbn :");
                libroM.Isbn = Console.ReadLine();

            }
            else
            {
                Console.WriteLine("Id del libro no encontrada");
            }

            //Console.WriteLine(idLibroM + " esta es la id <-");
            //bool encontroElLibro = false;
            //foreach (Libro libroI in listaDeLibros)
            //{
            //    if (libroI.Id == idLibroM)
            //    {

            //        Libro libroM = new Libro(); 
            //        libroM = crearLibro();
            //        Console.WriteLine(libroM);
            //        Console.WriteLine("Se ha modificado el libro con exito!");
            //        Console.WriteLine($"-> {libroM}");
            //        encontroElLibro = true;
            //    }
            //}
            //if (!encontroElLibro)
            //{
            //    Console.WriteLine("La id ingresada no se encontro!");
            //}



            break;
        case 4:
            listarLibros();

            break;
        default:
            Console.WriteLine("Opcion ioncorrecta");
            break;
    }
}

// Configuracion del software
void InitComponent()
{
    //Primero definir las opciones de mi menu
    menu = new Menu();
    menu.Opciones.Add(new Item(1, "Agregar"));
    menu.Opciones.Add(new Item(2, "Eliminar"));
    menu.Opciones.Add(new Item(3, "Modificar"));
    menu.Opciones.Add(new Item(4, "Listar"));
    menu.Opciones.Add(new Item(0, "Salir"));

    listaDeLibros = new List<Libro>();
    // Jose Mendez = Jose Mendez + 1 -> constructor

    listaDeLibros.Add(new Libro(1, "Kamasytra", "Vatsyayana, Mallanaga", "Educativo", "9783868200355"));
    // bastian P += 1
}
void AgregarLibro(string titulo,string autor,string genero,string isbn)
{
    Libro libro = new Libro();

    
    


    foreach (Libro obj in listaDeLibros.ToList()) {

       int id = listaDeLibros.Max(x => x.Id+1);
        //id = id+ 1;
        libro.Id = id;
       
    }
        libro.Titulo = titulo;
        libro.Autor = autor;
        libro.Genero = genero;
        libro.Isbn = isbn;

        listaDeLibros.Add(libro);
}

