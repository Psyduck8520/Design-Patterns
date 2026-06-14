namespace DesingPatterns.Singleton;
public class Singleton
{
    //Nos sirver para crear objetos, si o si solo un objeto,
    // puede ser que hardaware o puede ser un pool de conexiones, tenemos que asegurar que tengamos un solo objeto 
    private readonly static Singleton _instance = new Singleton(); // es el unico que vamos a crear
    
    //Acceso 
    public static Singleton Instance // creamos una propiedad podemos acceder al unico objeto de esa clase 
    {
        get
        {
            return _instance;
        }
    }
    private Singleton()// como este es privado garantizamos que no podemos crear objetos de esta clase desde afuera, solo se puede crear un objeto dentro de la clase
    {
        
    }
    
}