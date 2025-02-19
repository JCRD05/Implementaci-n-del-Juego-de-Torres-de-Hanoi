# Torres de Hanoi - Implementación en C#

## Descripción
Esta implementación de las Torres de Hanoi en C# utiliza estructuras de datos como pilas (stacks) para simular el movimiento de discos entre tres torres. El programa permite a los usuarios jugar interactivamente, moviendo discos según las reglas clásicas del juego.

## Estructura del Proyecto
El código se organiza en varias clases:

### 1. `Node.cs`
Define la estructura de un nodo para la pila, que almacena un valor entero y una referencia al siguiente nodo.

### 2. `Stack.cs`
Implementa una pila (stack) basada en nodos, con operaciones básicas como:
- `Push(int data)`: Agrega un elemento a la pila.
- `Pop()`: Elimina y devuelve el elemento superior de la pila.
- `Peek()`: Devuelve el elemento superior sin eliminarlo.
- `Print()`: Muestra el contenido de la pila en consola.
- `IsEmpty()`: Verifica si la pila está vacía.

### 3. `Tower.cs`
Representa cada torre del juego como una pila y permite mover discos entre torres. Métodos clave:
- `Move(Tower towerA, Tower towerB)`: Mueve un disco de una torre a otra respetando las reglas del juego.
- `Print()`: Muestra el estado actual de la torre.
- `Get()`: Obtiene el disco superior de la torre.

### 4. `Game.cs`
Controla la lógica del juego, incluyendo la inicialización y la interacción del usuario. Métodos principales:
- `Start()`: Inicia el juego y permite al usuario elegir el número de discos.
- `ShowTowers()`: Muestra las torres en la consola.
- `Play(Tower towerA, Tower towerB)`: Permite mover discos entre torres y verifica el estado del juego.
- `Win()`: Comprueba si el jugador ha completado el juego.

### 5. `Program.cs`
Punto de entrada del programa, donde se crea una instancia del juego y se inicia con `game.Start()`.

## Ejemplo de Uso
1. Ejecutar el programa.
2. Introducir el número de discos.
3. Seleccionar movimientos utilizando las opciones del menú.
4. Mover los discos hasta completar el juego.
5. Salir del juego cuando se desee.

## Reglas del Juego
- Solo se puede mover un disco a la vez.
- Un disco más grande no puede colocarse sobre uno más pequeño.
- El objetivo es mover todos los discos de la Torre 1 a la Torre 3 utilizando la Torre 2 como auxiliar.

¡Disfruta resolviendo las Torres de Hanoi en C#!

