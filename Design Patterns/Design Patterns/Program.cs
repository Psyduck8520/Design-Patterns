class Program
{
    static void  Main(string[] args)
    {
        List<IVolador> aves = new List<IVolador>();
        aves.Add(new Pato());
        aves.Add(new Gallina());
         
        AVolar(aves);
    }

    static void  AVolar(List<IVolador>  aves)
    {
        foreach (var ave  in aves)
        {
            ave.Vuela();
        }   
    }
    interface IVolador
    {
        public void Vuela();
    }
     interface ICaminar
    {
        public void Camina();
    }
    public class  Pato : IVolador, ICaminar
    {
        public void Vuela()
        {
            Console.WriteLine("El pato vuela");
        }

        public void Camina()
        {
            Console.WriteLine("El pato camina");
        }
    }
    
    
    public class Gallina : ICaminar,IVolador
    {
        public void Camina()
        {
            Console.WriteLine("El gallina camina");
        }
        public void Vuela()
        {
            Console.WriteLine("La gallina vuela, pero tiene alas");
        }
    }
  
}


