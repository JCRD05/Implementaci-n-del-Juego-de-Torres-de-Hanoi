# Torre de Hanoi - Implementación en C#

## Descripción
Este proyecto implementa el juego de la **Torre de Hanoi** en C#, utilizando estructuras de datos como pilas para representar las torres y nodos para gestionar los discos.

La aplicación permite:
- Jugar manualmente moviendo discos entre torres.
- Resolver el problema de manera automática utilizando un algoritmo recursivo.
- Mostrar el estado actual de las torres en la consola.

## Estructura del Proyecto

El código está organizado en las siguientes clases:

### **1. Program.cs**
Punto de entrada del programa. Inicia el juego llamando a `Game.Start()`.

### **2. Game.cs**
Gestiona el flujo del juego, mostrando las torres y permitiendo al usuario interactuar con ellas.

### **3. Tower.cs**
Representa una torre en la Torre de Hanoi. Contiene una pila (`Stack`) de discos y métodos para moverlos.

### **4. Stack.cs**
Implementa una estructura de pila (`Stack`) para almacenar los discos de cada torre.

### **5. Node.cs**
Define la estructura de un nodo utilizado en la pila para almacenar los discos.

## Uso

### **Ejecutar el programa**

1. Compila y ejecuta el programa en un entorno compatible con C#.
2. Al iniciar, ingresa el número de discos que deseas jugar.
3. Selecciona una de las opciones del menú para mover los discos entre torres.
4. Puedes elegir resolver el juego automáticamente o continuar jugando manualmente.
5. El juego finaliza cuando todos los discos han sido movidos a la tercera torre en orden.

### **Opciones del Menú**

- **Mover discos**: Permite al jugador mover un disco entre dos torres.
- **Resolver automáticamente**: Usa el algoritmo recursivo para completar el juego.
- **Reiniciar juego**: Permite empezar una nueva partida.
- **Salir**: Finaliza la aplicación.

## Algoritmo de Solución Automática
El método `SolveTower(int n, Tower origen, Tower destino, Tower auxiliar)` resuelve el juego recursivamente siguiendo la estrategia clásica:
1. Mover `n-1` discos desde la torre origen a la torre auxiliar.
2. Mover el disco más grande directamente a la torre destino.
3. Mover los `n-1` discos desde la torre auxiliar a la torre destino.

