using System;
using DesingPatterns.Singleton;

namespace DesingPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //var singleton = Singleton.Singleton.Instance; // accedemos a la instancia del singleton, no podemos crear un nuevo objeto de singleton porque el constructor es privado, solo podemos acceder a la instancia que ya se creo dentro de la clase singleton
            //Console.WriteLine(singleton);   //  no podemos crear otro mas  pero podemos acceder al unico objeto.
             
            var log = Singleton.Log.Instance; // accedemos a la instancia del log, no podemos crear un nuevo objeto de log porque el constructor es privado, solo podemos acceder a la instancia que ya se creo dentro de la clase log
            Log.Save("a");
             Log.Save("b");
             Log.Save("c");

        }
    }
};

