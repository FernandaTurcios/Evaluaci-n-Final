namespace Final_Jennifer_Turcios;

public class Biblioteca
{
    public string[]  libros = new string[10] { "La Biblia", "Odisea", "Don Quijote", "El Principito", "Lolita", "Diez negritos", "El alquimista", "Iliada", "El hobbit", "Orgullo y Prejuicio" };
    //Se crea un arreglo con 10 libros ya quemados

    public string[] librosPrestados = new string[10]; //Se crea un segundo arreglo para guardar libros que están siendo prestados

    public string libroretirado; //Se declaran las propiedades
    public string libroprestado;
    public string libroaregresar;

    public void PrestarLibro() //Se crea una función en la que el usuario prestará un libro
    {
        Console.WriteLine("¿Que libro desea prestar?");
        Console.WriteLine("1. La Biblia");
        Console.WriteLine("2. Odisea");
        Console.WriteLine("3. Don Quijote");
        Console.WriteLine("4. El Principito");
        Console.WriteLine("5. Lolita");
        Console.WriteLine("6. Diez negritos");
        Console.WriteLine("7. El alquimista");
        Console.WriteLine("8. Iliada");
        Console.WriteLine("9. El hobbit");
        Console.WriteLine("10. Orgullo y Prejuicio");
        int opcionlibro = int.Parse(Console.ReadLine());
        switch (opcionlibro) //Se utiliza un switch para evaluar que libro será prestado y en cada caso guardar dicho libro el el arreglo librosPrestados
        {
            case 1:
                    libros[0] = "";
                    librosPrestados [0] = "La Biblia";
                break;
            case 2:
                    libros[1] = "";
                    librosPrestados [1] = "Odisea";
                break;
            case 3:
                    libros[2] = "";
                    librosPrestados [2] = "Don Quijote";
                break;
            case 4:
                    libros[3] = "";
                    librosPrestados [3] = "El Principito";
                break;
            case 5:
                    libros[4] = "";
                    librosPrestados [4] = "Lolita";
                break;
            case 6:
                    libros[5] = "";
                    librosPrestados [5] = "Diez negritos";
                break;
            case 7:
                    libros[6] = "";
                    librosPrestados [6] = "El alquimista";
                break;
            case 8:
                    libros[7] = "";
                    librosPrestados [7] = "Iliada";
                break;
            case 9:
                    libros[8] = "";
                    librosPrestados [8] = "El hobbit";
                break;
            case 10:
                    libros[9] = "";
                    librosPrestados [9] = "Orgullo y Prejuicio";
                break;
            default:
                Console.WriteLine("Opción no valida");
                break;
        }
        Console.WriteLine("");
        Console.WriteLine(librosPrestados[opcionlibro-1]);
    }

    public void MostrarLibros() //Se crea una función en la que se reccore el areglo de los libros prestados y de muestran
    {

        for(int i = 0; i<librosPrestados.Length;i++)
        {
            if(librosPrestados[i]!=null)
            {
                Console.WriteLine("Libros prestados:" + librosPrestados[i]);
            }
        }
    }

    public void DevolverLibro () //Se crea una función en la que el usuario devolverá un libro
    {
        Console.WriteLine("¿Que libro desea regresar?");
        Console.WriteLine("1. La Biblia");
        Console.WriteLine("2. Odisea");
        Console.WriteLine("3. Don Quijote");
        Console.WriteLine("4. El Principito");
        Console.WriteLine("5. Lolita");
        Console.WriteLine("6. Diez negritos");
        Console.WriteLine("7. El alquimista");
        Console.WriteLine("8. Iliada");
        Console.WriteLine("9. El hobbit");
        Console.WriteLine("10. Orgullo y Prejuicio");
        int opcionlibro = int.Parse(Console.ReadLine());
        switch (opcionlibro) //Se utiliza un switch para evaluar que libro se regresará y así rellenar la casilla del arreglo igualada a 0 en la función para prestar libros
        {
            case 1:

                    libros[0] = "La Biblia";
                break;
            case 2:
                    libros[1] = "Odisea";
                break;
            case 3:
                    libros[2] = "Don Quijote";
                break;
            case 4:
                    libros[3] = "El Principito";
                break;
            case 5:
                    libros[4] = "Lolita";
                break;
            case 6:
                    libros[5] = "Diez negritos";
                break;
            case 7:
                    libros[6] = "El alquimista";
                break;
            case 8:
                    libros[7] = "Iliada";
                break;
            case 9:
                    libros[8] = "El hobbit";
                break;
            case 10:
                    libros[9] = "Orgullo y Prejuicio";
                break;
            default:
                Console.WriteLine("Opción no valida");
                break;
        }

    }

    public void CatalogoLibros() //Se crea una función para mostrar todos los libros con los que cuenta la biblioteca
    {
        for (int i = 0; i < libros.Length; i++) //Se reccore el arreglo para poder imprimirlo
        {
            Console.WriteLine("" + libros[i]);
        }
    }
    
}
