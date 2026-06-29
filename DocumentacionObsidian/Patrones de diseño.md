
# Patrones de Diseño y Programación Orientada a Objetos

  

> [!summary]

> Los ****patrones de diseño**** son soluciones probadas para problemas comunes en el desarrollo de software.  

> Nos ayudan a escribir código más ****limpio****, ****escalable****, ****legible****, ****mantenible**** y fácil de trabajar en equipo.

  

---

  

## 1. ¿Qué son los patrones de diseño?

  

Los ****patrones de diseño**** son formas recomendadas de resolver problemas frecuentes al momento de diseñar software.

No son código listo para copiar y pegar, sino una guía para tomar mejores decisiones de diseño.
Nos ayudan a:
- Aplicar buenas prácticas.

- Evitar código repetido o desordenado.

- Construir software escalable.

- Mejorar la legibilidad del código.

- Facilitar el mantenimiento.

- Trabajar mejor en equipo.

- Tener una solución práctica para problemas comunes.

  

> [!quote]

> Un patrón de diseño es una solución reutilizable para un problema común dentro del diseño de software.


---

# Clasificación de los patrones de diseño

Los patrones de diseño se clasifican principalmente en ****tres tipos****:


1. [[Patrones Creacionales]]

2. [[Patrones Estructurales]]

3. [[Patrones de Comportamiento]]

  

---

  

## 2. Patrones creacionales

  

Los ****patrones creacionales**** se encargan de la ****creación de objetos****.

  

Su objetivo es permitir crear objetos de una forma más flexible, evitando que el código dependa directamente de clases concretas.

  

### Ejemplos

  

- [[Factory Method]]

- [[Abstract Factory]]

- [[Builder]]

- [[Singleton]]

- [[Prototype]]

  

> [!info]

> Los patrones creacionales responden a la pregunta:  

> ****¿Cómo se crean los objetos?****

  

---

  

## 3. Patrones estructurales

  

Los ****patrones estructurales**** se enfocan en cómo se organizan y se relacionan las clases y los objetos.

  

Nos ayudan a crear estructuras más limpias, reutilizables y fáciles de mantener.

  

### Ejemplos

  

- [[Adapter]]

- [[Decorator]]

- [[Facade]]

- [[Composite]]

- [[Proxy]]

- [[Bridge]]

  

> [!info]

> Los patrones estructurales responden a la pregunta:  

> ****¿Cómo se estructuran las clases y los objetos?****

  

---

  

## 4. Patrones de comportamiento

  

Los ****patrones de comportamiento**** definen cómo interactúan los objetos entre sí y cómo se distribuyen las responsabilidades.

  

Ayudan a organizar mejor la lógica del sistema y evitan que una sola clase tenga demasiadas responsabilidades.

  

### Ejemplos

  

- [[Strategy]]

- [[Observer]]

- [[Command]]

- [[Chain of Responsibility]]

- [[State]]

- [[Template Method]]

  

> [!info]

> Los patrones de comportamiento responden a la pregunta:  

> ****¿Cómo se comunican y actúan los objetos?****

  

---

  

# Programación Orientada a Objetos

  

## 5. ¿Qué es la Programación Orientada a Objetos?

  

La ****Programación Orientada a Objetos****, también conocida como ****POO****, es un paradigma de programación.

  

Un paradigma es una forma de pensar, organizar y construir el código.

  

En POO trabajamos con ****objetos****.

  

Un objeto puede tener:

  

- ****Propiedades:**** representan sus datos o características.

- ****Métodos:**** representan sus acciones o comportamientos.

  

### Ejemplo en C#

  

```csharp

public class Usuario

{

    public string Nombre { get; set; }

    public string Email { get; set; }

  

    public void IniciarSesion()

    {

        Console.WriteLine("El usuario inició sesión");

    }

}

```

  

En este ejemplo:

  

- `Nombre` y `Email` son propiedades.

- `IniciarSesion()` es un método.

- `Usuario` es una clase.

  

---

  

## 6. Clase

  

Una ****clase**** es un molde o una plantilla.

  

Define cómo estará construido un objeto, qué propiedades tendrá y qué métodos podrá ejecutar.

  

### Ejemplo

  

```csharp

public class Auto

{

    public string Marca { get; set; }

    public string Color { get; set; }

  

    public void Encender()

    {

        Console.WriteLine("El auto está encendido");

    }

}

```

  

La clase `Auto` funciona como molde.

  

A partir de esa clase podemos crear objetos:

  

```csharp

Auto miAuto = new Auto();

miAuto.Marca = "Toyota";

miAuto.Color = "Rojo";

```

  

> [!note]

> La clase define la estructura.  

> El objeto es una instancia creada a partir de esa clase.

  

---

  

## 7. Clase abstracta

  

Una ****clase abstracta**** sirve como base para otras clases hijas.

  

Normalmente no se usa para crear objetos directamente. Se usa para compartir estructura y comportamiento común entre varias clases.

  

### Ejemplo

  

```csharp

public abstract class Animal

{

    public string Nombre { get; set; }

  

    public abstract void HacerSonido();

}

```

  

Una clase hija puede heredar de ella:

  

```csharp

public class Perro : Animal

{

    public override void HacerSonido()

    {

        Console.WriteLine("Guau");

    }

}

```

  

> [!important]

> Una clase abstracta sirve cuando queremos definir una base común, pero permitir que las clases hijas implementen ciertos comportamientos a su manera.

  

---

  

## 8. Interfaz

  

Una ****interfaz**** es un contrato.

  

Define qué propiedades o métodos debe tener una clase, pero no necesariamente cómo deben funcionar internamente.

  

### Ejemplo

  

```csharp

public interface INotificacion

{

    void Enviar(string mensaje);

}

```

  

Una clase puede implementar esa interfaz:

  

```csharp

public class EmailNotificacion : INotificacion

{

    public void Enviar(string mensaje)

    {

        Console.WriteLine("Enviando email: " + mensaje);

    }

}

```

  

La interfaz obliga a que la clase cumpla con el método `Enviar`.

  

> [!tip]

> La interfaz dice ****qué debe hacerse****, pero la clase decide ****cómo hacerlo****.

  

---

  

# Importancia de las interfaces

  

## 9. ¿Por qué son importantes las interfaces?

  

Las interfaces son importantes porque ayudan a evitar una limitación de la herencia.

  

En lenguajes como C#, una clase solo puede heredar de una clase base, pero puede implementar varias interfaces.

  

### Ejemplo

  

```csharp

public class ServicioPago : IPago, IAuditable, INotificable

{

}

```

  

Esto permite categorizar una clase con diferentes comportamientos.

  

Una interfaz también ayuda a que el equipo trabaje con uniformidad.

  

Si todos usan la misma interfaz, todos saben:

  

- Qué métodos deben existir.

- Cómo deben llamarse.

- Qué contrato debe cumplirse.

- Qué comportamiento se espera.

  

### Ejemplo

  

```csharp

public interface IRepository

{

    void Guardar();

    void Eliminar();

    void Actualizar();

}

```

  

Todas las clases que implementen `IRepository` deberán tener esos métodos.

  

Esto hace que el código sea más:

  

- Ordenado.

- Predecible.

- Fácil de mantener.

- Fácil de probar.

- Fácil de extender.

  

---

  

# Interfaces y patrones de diseño

  

## 10. Relación entre interfaces y patrones de diseño

  

Las interfaces son una base muy importante para muchos patrones de diseño.

  

Permiten separar el contrato de la implementación.

  

Esto ayuda a que el sistema sea más flexible y fácil de modificar.

  

### Ejemplo con Strategy

  

En el patrón [[Strategy]], podemos definir una interfaz que representa una estrategia de pago:

  

```csharp

public interface IEstrategiaPago

{

    void Pagar(decimal monto);

}

```

  

Luego podemos tener diferentes implementaciones:

  

```csharp

public class PagoTarjeta : IEstrategiaPago

{

    public void Pagar(decimal monto)

    {

        Console.WriteLine("Pago con tarjeta");

    }

}

  

public class PagoTransferencia : IEstrategiaPago

{

    public void Pagar(decimal monto)

    {

        Console.WriteLine("Pago por transferencia");

    }

}

```

  

Así podemos cambiar el comportamiento sin modificar todo el sistema.

  

> [!success]

> Las interfaces ayudan a aplicar principios como ****SOLID****, especialmente el principio de inversión de dependencias.

  

---

  

# Resumen rápido

  

## Idea principal

  

Los patrones de diseño se clasifican en tres tipos:

  

| Tipo | Propósito | Pregunta que responde |

|---|---|---|

| Creacionales | Crear objetos | ¿Cómo se crean los objetos? |

| Estructurales | Organizar clases y objetos | ¿Cómo se estructuran? |

| Comportamiento | Definir interacción entre objetos | ¿Cómo se comunican y actúan? |

  

---

  

## Resumen para explicar

  

Los patrones de diseño se clasifican en ****creacionales****, ****estructurales**** y ****de comportamiento****.

  

Los creacionales nos ayudan a crear objetos.  

Los estructurales nos ayudan a organizar clases y objetos.  

Los de comportamiento nos ayudan a definir cómo interactúan los objetos.

  

Estos patrones permiten aplicar buenas prácticas, escribir código limpio, escalable, legible y fácil de mantener, especialmente cuando trabajamos en equipo.

  

La ****Programación Orientada a Objetos**** es un paradigma que organiza el software mediante objetos. Los objetos tienen propiedades y métodos. Las clases son moldes para crear objetos. Las clases abstractas sirven como base para clases hijas. Las interfaces funcionan como contratos que las clases deben cumplir.

  

Las interfaces son muy importantes porque permiten definir comportamientos comunes, trabajar con uniformidad y aplicar muchos patrones de diseño de forma más limpia.

  

---

  

# Conexiones recomendadas en Obsidian

  

- [[Clean Code]]

- [[SOLID]]

- [[Design Patterns]]

- [[Factory Method]]

- [[Strategy]]

- [[Observer]]

- [[Decorator]]

- [[Programación Orientada a Objetos]]

- [[Clean Architecture]]

  

---

  

# Preguntas de repaso

  

1. ¿Qué problema resuelven los patrones creacionales?

2. ¿Cuál es la diferencia entre una clase y un objeto?

3. ¿Para qué sirve una clase abstracta?

4. ¿Por qué una interfaz se considera un contrato?

5. ¿Por qué las interfaces son importantes en los patrones de diseño?

6. ¿Qué diferencia hay entre patrones estructurales y patrones de comportamiento?

7. ¿Cómo ayuda una interfaz al trabajo en equipo?

  

---

  

# Frase clave

  

> Los patrones de diseño no son solo teoría: son una forma de escribir software más limpio, escalable y entendible para otros desarrolladores.