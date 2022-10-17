//variables
string Usuario, Pass;
int Cont = 0;

//metodo principal


    for (int i = 0; i < 3; i++) //estructura repetitiva, se repetira el ciclo 3 veces
    {
        Console.WriteLine("Usuario: ");
        Usuario = Console.ReadLine();
        Console.WriteLine("Contraseña: ");
        Pass = Console.ReadLine();
        Login(Usuario, Pass); //se llama a la funcion y le pasamos los parámetros
    }


//funcion
int Login(string user, string password)
{
    if (user == "usuario1" && password == "asdasd")//validacion de usuario y contraseña
    {
        Console.WriteLine("VERDADERO");
        Console.WriteLine("Presione cualquier tecla para terminar la ejecución...");
        Console.ReadKey();//detener la ejecución del programa hasta que se presiona una tecla
        Environment.Exit(0);//terina la ejecución
    }
    else
    {
        Cont++;
        Console.WriteLine("Intento No." + Cont); //contador mostrando los intentos
        Console.WriteLine("Intentos expirados...(presione cualquier tecla para continuar)");
        Console.ReadKey();
        Console.Clear();
    }
    return 0;
}
