using System;
using Final_Jennifer_Turcios;

int opcionmenu1=0;
Usuario objUsuario = new Usuario(); //Se crea un objeto de la clase Usuario
do //Se utiliza un ciclo Do While para mostrar un menú que se repetirá
{
    Console.WriteLine("--------------------------------------------------");
    Console.WriteLine("Ingrese la opción que desee:");
    Console.WriteLine("1. Ingresar datos");
    Console.WriteLine("2. Mostrar datos");
    Console.WriteLine("3. Salir del programa");
    opcionmenu1 = int.Parse(Console.ReadLine());
    switch (opcionmenu1) //Se utiliza un switch para evaluar los posibes casos
    {
        case 1:
            Console.WriteLine("--------------------------------------------------");
            objUsuario.InfoUsuario(); //Se llama a la función InfoUsuarios de la clase Usuario
            break;
        case 2:
            Console.WriteLine("--------------------------------------------------"); //Se muestra otro menú dentro de este caso
            Console.WriteLine("¿Qué desea mostrar?");
            Console.WriteLine("1. Listado de libros prestados por usuarios");
            Console.WriteLine("2. Consultar catálogo de libros");
            Console.WriteLine("3. Usuarios activos");
            int opcionmenu3 = int.Parse(Console.ReadLine());
            switch (opcionmenu3) //Se utuliza un switch para evaluar los casos
            {
                case 1:
                    objUsuario.MostarPrestados(); //Se llama a la función requerida segun el procedimiento adecuado
                    Console.WriteLine("--------------------------------------------------");
                    break;
                case 2:
                    objUsuario.CatalogoLibros(); //Se llama a la función requerida segun el procedimiento adecuado
                    Console.WriteLine("--------------------------------------------------");
                    break;
                case 3:
                    objUsuario.UsuariosActivos(); //Se llama a la función requerida segun el procedimiento adecuado
                    Console.WriteLine("--------------------------------------------------");
                    break;
                default:
                    break;
            }
            break;
        case 3:
            break;
        default:
            Console.WriteLine("Opción no valida");
            break;
    }
}
while (opcionmenu1 != 3); //Condición que debe cumplir el ciclo
