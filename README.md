## Generalidades del lenguaje C#

**01-Variables-y-constantes.cs**

***Variables en C#:***
  - Declaración: En C#, las variables se definen indicando el tipo de dato seguido del nombre de la variable. Ejemplo: `int age;`.
  - Inferencia de tipos: A partir de C# 3.0, se puede usar "var" para permitir que el compilador infiera el tipo automáticamente. Ejemplo: `var name = "John";`.

***Constantes en C#:***
  - Declaración: Las constantes se definen con "const" seguido del tipo de dato y el nombre. Ejemplo: `const double pi = 3.14159;`.
  - Inferencia de tipos: Las constantes no pueden usar inferencia de tipos; se debe especificar el tipo explícitamente.

**02-Operadores-aritmeticos.cs**

Los operadores aritméticos en C# incluyen suma `+`, resta `-`, multiplicación `*`, división `/` y módulo `%`.

Ejemplo:
```csharp
  int a = 10;
  int b = 5;
  int sum = a + b; // sum = 15
  int product = a * b; // product = 50
```

**03-Operadores-relacionales.cs**

Los operadores relacionales en C# se utilizan para comparar valores y devolver un resultado booleano.

Los operadores incluyen mayor que `>`, menor que `<`, mayor o igual que `>=`, menor o igual que `<=`, igual a `==`, y no igual a `!=`.

No existen los conceptos de "valores truthy" y "valores falsy".

No existe el operadorador de igualdad estricta.

Ejemplo:
```csharp
  int x = 5;
  int y = 10;
  bool result = x < y; // result = true
```

**04-Operadores-logicos.cs**

Los operadores lógicos en C# se utilizan para combinar expresiones lógicas y obtener resultados booleanos.

Los operadores incluyen AND lógico `&&`, OR lógico `||` y NOT lógico `!`.

Ejemplo:
```csharp
  bool condition1 = true;
  bool condition2 = false;
  bool result = condition1 && !condition2; // result = true
```

**05-Operadores-unarios.cs**

Los operadores unarios en C# actúan sobre un solo operando.

Los operadores de incremento `++` y decremento `--` aumentan y disminuyen el valor de una variable en 1, respectivamente.

Ejemplo:
```csharp
  int x = 5;
  x++; // x = 6
```

**06-Estructura-condicional-if.cs**


La estructura condicional "if-else" permite tomar decisiones basadas en condiciones lógicas.

Si la condición es verdadera, se ejecuta el bloque "if". Si es falsa, se ejecuta el bloque "else" (opcional) o se continúa con el código siguiente.

Ejemplo:
```csharp
  int age = 18;
  if (age >= 18) {
    Console.WriteLine("Eres mayor de edad.");
  } else{
    Console.WriteLine("Eres menor de edad.");
  }
```

**07-Sentencia-de-control-de-flujo-break.cs**

La sentencia "break" se utiliza para interrumpir la ejecución de un bucle o switch.

Cuando se encuentra "break" dentro de un bucle, el control salta fuera del bucle, y cuando se encuentra en un switch, se sale del switch.

Ejemplo:
```csharp
  for (int i = 1; i <= 5; i++) {
    if (i == 3){
      break; // Sale del bucle cuando i es igual a 3.
    }
    Console.WriteLine(i);
  }
```

**08-Sentencia-de-control-de-flujo-continue.cs**

La sentencia "continue" se utiliza para omitir el resto del código dentro de una iteración y continuar con la siguiente iteración en un bucle.

Cuando se encuentra "continue", se salta al inicio del bucle, evitando el código restante para esa iteración.

Ejemplo:
```csharp
  for (int i = 1; i <= 5; i++) {
    if (i == 3) {
      continue; // Omite la impresión de 3 y continua con la siguiente iteración.
    }
    Console.WriteLine(i);
  }
```

**09-Estructura-condicional-switch-case.cs**

La estructura condicional "switch-case" permite realizar múltiples comparaciones para una variable específica.

Se compara la variable con varios valores y se ejecuta el bloque de código correspondiente al valor coincidente.

Ejemplo:
```csharp
  int day = 2;
  switch (day) {
    case 1:
      Console.WriteLine("Lunes");
      break;
    case 2:
      Console.WriteLine("Martes");
      break;
    default:
      Console.WriteLine("Día no reconocido");
      break;
  }
```

**10-Estructura-repetitiva-for.cs**


La estructura repetitiva "for" se utiliza para realizar bucles controlados por un contador.

El bucle se repite mientras la condición se cumpla y puede ejecutarse un número específico de veces.

Ejemplo:
```csharp
  for (int i = 1; i <= 5; i++) {
    Console.WriteLine(i); // Imprime los números del 1 al 5.
  }
```

**11-Estructura-repetitiva-while.cs**

La estructura repetitiva "while" se utiliza para realizar bucles mientras se cumpla una condición.

El bloque de código se ejecuta siempre que la condición sea verdadera.

Ejemplo:
```csharp
  int i = 1;
  while (i <= 5){
    Console.WriteLine(i);// Imprime los números del 1 al 5.
    i++;
  }
```

**12-Estructura-repetitiva-do-while.cs**

La estructura repetitiva "do-while" es similar a "while", pero garantiza que el bloque de código se ejecuta al menos una vez antes de evaluar la condición.

El bucle se repite mientras la condición sea verdadera.

Ejemplo:
```csharp
int i = 1;
do{
  Console.WriteLine(i); // Imprime los números del 1 al 5.
  i++;
} while (i <= 5);
```

**13-Funciones.cs**

Las funciones en C# son bloques de código que realizan tareas específicas y pueden devolver valores.

Pueden tomar parámetros para personalizar su comportamiento.

Ejemplo:
```csharp
  int Sum(int a, int b){
    return a + b;
  }
  int result = Sum(5, 3); // result = 8
```

**14-Estructura-de-datos-array.cs**

Los arrays (arreglos) en C# son estructuras que almacenan varios elementos del mismo tipo en una secuencia contigua de memoria.

Pueden tener una longitud fija y se accede a sus elementos mediante un índice numérico.

Ejemplo:
```csharp
  int[] numbers = new int[5]; // Declaración de un array de enteros con longitud 5.
  numbers[0] = 1;
  numbers[1] = 2;
```

**15-Estructura-de-datos-dictionary.cs**

Los diccionarios (Dictionary) en C# almacenan pares clave-valor, donde cada clave debe ser única.

Se utilizan para acceder rápidamente a valores utilizando una clave en lugar de un índice numérico.

Ejemplo:
```csharp
  Dictionary<string, int> ages = new Dictionary<string, int>();
  ages.Add("Alice", 30);
  int aliceAge = ages["Alice"]; // aliceAge = 30
```

**16-Estructura-de-datos-queue.cs**


Las colas (Queue) en C# son estructuras que siguen el principio FIFO (Primero en entrar, primero en salir).

Se utilizan para organizar elementos en un orden específico, como procesos en espera.

Ejemplo:
```csharp
  Queue<string> tasks = new Queue<string>();
  tasks.Enqueue("Tarea 1");
  tasks.Enqueue("Tarea 2");
  string nextTask = tasks.Dequeue(); // nextTask = "Tarea 1"
```

**17-Estructura-de-datos-stack.cs**


Las pilas (Stack) en C# siguen el principio LIFO (Último en entrar, primero en salir).

Se utilizan para organizar elementos en un orden inverso, como pila de llamadas a funciones.

Ejemplo:
```csharp
  Stack<string> books = new Stack<string>();
  books.Push("Libro 1");
  books.Push("Libro 2");
  string lastBook = books.Pop(); // lastBook = "Libro 2"
```

**18-Estructura-de-datos-hashset.cs**


Los conjuntos (HashSet) en C# almacenan elementos únicos sin duplicados.

Se utilizan cuando no es necesario mantener un orden específico de elementos.

Ejemplo:
```csharp
  HashSet<int> numbers = new HashSet<int>();
  numbers.Add(1);
  numbers.Add(2);
  numbers.Add(1); // No se permite duplicados, el conjunto solo contiene 1 y 2.
```

**19-Estructura-de-datos-linkedlist.cs**


Las listas enlazadas (LinkedList) en C# son estructuras donde cada elemento (nodo) contiene un valor y un enlace al siguiente nodo.

Se utilizan para manipular datos en secuencias enlazadas, insertar y eliminar elementos de manera eficiente.

Ejemplo:
```csharp
  LinkedList<string> names = new LinkedList<string>();
  names.AddLast("Alice");
  names.AddLast("Bob");
```

**20-Estructura-de-datos-tree.cs**

Los árboles (Tree) en C# son estructuras jerárquicas donde cada elemento (nodo) tiene hijos y un solo padre, comenzando con un nodo raíz.

Se utilizan para representar relaciones jerárquicas y organizar datos de manera eficiente.

Ejemplo:
```csharp
  class TreeNode {
    public string Data;
    public List<TreeNode> Children = new List<TreeNode>();
  }
```

**21-Estructura-de-datos-graph.cs**


Los grafos (Graph) en C# son conjuntos de nodos conectados por aristas, que pueden ser dirigidas o no dirigidas.

Se utilizan para representar relaciones complejas entre elementos.

Ejemplo:
```csharp
  class GraphNode{
    public string Data;
    public List<GraphNode> Neighbors = new List<GraphNode>();
  }
```

**22-Estructura-de-datos-hashtable.cs**

Las tablas hash (Hashtable) en C# son estructuras de datos que utilizan un mecanismo de hash para acceder a los elementos de manera rápida.

Se utilizan para almacenar y recuperar datos de manera eficiente.

Ejemplo:
```csharp
  Hashtable ages = new Hashtable();
  ages.Add("Alice", 30);
  int aliceAge = (int)ages["Alice"]; // aliceAge = 30
```

**23-Struct.cs**

Las estructuras (struct) en C# son tipos de valor que se utilizan para encapsular un conjunto de campos o propiedades. A diferencia de las clases, las estructuras se almacenan en la pila en lugar del montón (heap), lo que las hace más eficientes en términos de rendimiento.

Ejemplo:

```csharp
  public struct Point {
    public int X;
    public int Y;
  }
  Point p = new Point();
  p.X = 10;
  p.Y = 20;
```

**24-Recursion.cs**

La recursión es un enfoque de resolución de problemas en el que una función se llama a sí misma para resolver un problema más pequeño. Es especialmente útil en problemas que pueden dividirse en subproblemas idénticos o similares. En C#, es importante tener en cuenta los casos base para evitar bucles infinitos.

Ejemplo:

```csharp
  public int Factorial(int n) {
    if (n == 0) return 1;
    return n * Factorial(n - 1);
  }
  int result = Factorial(5); // result = 120
```


**25-Expresiones-lamdba.cs**

Las expresiones lambda son funciones anónimas y compactas que se pueden usar para crear delegados o tipos de expresiones en C#. Permiten escribir funciones cortas y concisas directamente en el código sin la necesidad de definir un método completo. Las expresiones lambda son especialmente útiles al trabajar con LINQ (Language-Integrated Query) y delegados.

Ejemplo:

```csharp
// Expresión lambda para calcular el cuadrado de un número
Func<int, int> square = x => x * x;

int result = square(5); // result = 25
```

**26-Delegados.cs**

Los delegados en C# son tipos de referencia que representan referencias a métodos con una firma específica. Permiten pasar métodos como argumentos a otros métodos o asignarlos a variables y usarlos para invocar el método posteriormente. Los delegados son fundamentales en la implementación de eventos y permiten lograr una mayor flexibilidad y extensibilidad en la programación.

Ejemplo:

```csharp
public delegate void MyDelegate(string message);

// Crear una instancia del delegado y asociarlo con un método
MyDelegate myDelegate = message => Console.WriteLine(message);

// Invocar el método a través del delegado
myDelegate("¡Hola, mundo!");
```

**27-Clousures.cs**

Los closures son funciones anidadas que pueden acceder y recordar variables locales de las funciones en las que están definidas. En C#, los closures son útiles cuando se trabaja con delegados, eventos o expresiones lambda.

Ejemplo:

```csharp
  public Func<int, int> MultiplyBy(int factor) {
    return x => x * factor;
  }
  var multiplyByFive = MultiplyBy(5);
  int result = multiplyByFive(10); // result = 50
```

