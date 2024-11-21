using Enumerable.UI.Consola;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("===============");
        Console.WriteLine("Enumerable");
        Console.WriteLine("===============");
        Console.WriteLine("\n");
        Console.WriteLine("**Lista**   lista<T>");
        #region Lista
        //se ocultan partes del codigo
        var lista = new List<Alumnos>
        {
            new Alumnos{Matricula=1, Nombre="Juan", Precio=21.452M},
            new Alumnos{Matricula=2, Nombre="Leslye", Precio=24.993M},
            new Alumnos{Matricula=3, Nombre="Abigail", Precio=24.22M},
            new Alumnos{Matricula=4, Nombre="Luis", Precio=23.1234M},
            new Alumnos{Matricula=5, Nombre="Jose", Precio=19.99M},
            new Alumnos{Matricula=6, Nombre="Casco", Precio=22.25M},
            new Alumnos{Matricula=7, Nombre="Isabel", Precio=25275M},
            new Alumnos{Matricula=8, Nombre="Alexandra", Precio=20.21M},
            new Alumnos{Matricula=9, Nombre="Zuri", Precio=20.123M},
            //"Juan",
            //"Leslye",
            //"Abigail",
            //"Luis",
            //"Jose",
            //"Casco",
            //"Isabel",
            //"Alexandra",
            //"Zuri"
        };

        //foreach (var nombre in lista)
        //{
        //    Console.WriteLine(nombre);
        //}
        lista = lista.OrderBy(x => x.Precio).ToList();

        for (int i = 0; i < lista.Count; i++) {
            Console.WriteLine(lista[i]);
        }

        

        #endregion




        Console.ReadKey();
    }
}