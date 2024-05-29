using System.ComponentModel.DataAnnotations;

namespace Final_Jennifer_Turcios;

public class Usuario : Biblioteca //Se crea la clase Usuario que heredará de la clase Biblioteca
{
    public string nombre; //Se declaran las propiedades
    public string apellidos;
    public int carnet;
    public int telefono;
    public string Libro;
    int opcionmenu2;
    public int validacionmenu2;
    public Usuario[] usuarios;

    Biblioteca objBiblioteca = new Biblioteca(); //Se crea un objeto de la clase biblioteca
    public Usuario() //Utilizando un constructor se inicializan las propiedades
    {
        nombre = "";
        apellidos = "";
        carnet = 0;
        telefono = 0;
        usuarios = new Usuario[10];
    }
    public void InfoUsuario() //Se crea una función en la que se solicitará la información del usuario y qué desea hacer
    {

        Usuario objUsuario = new Usuario();
        Console.WriteLine("Ingrese su nombre:");
        objUsuario.nombre = Console.ReadLine(); //Se guardan los valores dentro del objeto
        Console.WriteLine("Ingrese sus apellidos:");
        objUsuario.apellidos = Console.ReadLine();
        Console.WriteLine("Ingrese su no. de carnet");
        objUsuario.carnet = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese su no. de teléfono");
        objUsuario.telefono = int.Parse(Console.ReadLine());

        Console.WriteLine("¿Qué desea hacer?");
        int validacion =0;
        do //Se utiliza un ciclo do while para mostrar otro menú hasta dejar dde cumplir una condición
        {
            Console.WriteLine("1. Prestar un libro");
            Console.WriteLine("2. Devolver un libro");
            Console.WriteLine("3. Ninguna de las anteriores");
            opcionmenu2 = int.Parse(Console.ReadLine());
            switch (opcionmenu2) //Se utliza un switch para evaluar y ejecutar instrucciones según los casos
            {
                case 1:
                    objBiblioteca.PrestarLibro(); //Se llama a la función para prestar libros de la clase Biblioteca
                    Libro = objBiblioteca.libroretirado;
                    validacion = 1;
                    break;
                case 2:
                    objBiblioteca.DevolverLibro(); //Se llama a la función para devolver libros de la clase Biblioteca
                    break;
                case 3:
                    Libro = "";
                    break;
                default:
                    Console.WriteLine("Opción no valida");
                    break;
            }
        }while (opcionmenu2 != 3);

        if(validacion == 0) //Utilizando una variable que se guarda en el objeto de la clase usuario para posteriormente evaluar si son clientes activos, según los valores asignados
            {
                objUsuario.validacionmenu2=0;
            }
            if(validacion == 1)
            {
                objUsuario.validacionmenu2=1;
            }

        
        for (int i = 0; i < usuarios.Length; i++) //se reccore el arreglo
        {
            if (usuarios[i] == null)
            {
                usuarios[i] = objUsuario;
                break;
            }
            else
            {
                if (usuarios[9] != null)
                {
                    Console.Write("Número de usuarios lleno");
                }
            }
        }
    }


    public void UsuariosActivos() //Se crea una función para evaluar quienes son usuarios activos, se tomarán como cliantes activos a aquellos que estén prestando o devolviendo un libro
    {
        for (int i = 0; i < usuarios.Length; i++)
        {
            if (usuarios[i] != null)
            {

                if (usuarios[i].validacionmenu2 == 1)
                {
                    Console.WriteLine(usuarios[i].nombre + " es usuario activo");
                }
            }
        }
    }

    public void MostarPrestados() //Se crea una función en la cual se llamará a la función MostrarLibros de la clase Biblioteca para mejorar el uso de objetos
    {
        objBiblioteca.MostrarLibros();
    }

}
