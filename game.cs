using System;
using System.Threading;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Structure.Stack;
using System.Numerics;

namespace HanoiTowers
{
    class Game
    {
        // Torres utilizadas en el juego
        public Tower tower1; 
        public Tower tower2;
        public Tower tower3;
        
        // Intervalo en el que se realiza cada movimiento en la solucion automatica
        private double moveInterval;
        
        // Numero de discos definido por el jugador
        public int diskNumber;
        
        // Constructor del juego
        public Game()
        {
            // Intervalo entre cada movimiento en la solucion automatica
            moveInterval = 1000;
        }
        
        // Metodo que muestra las tres torres en la consola
        public void ShowTowers()
        {
            Console.Clear();
            tower1.Print();
            Console.WriteLine("\n=====================\n");
            //Thread.Sleep(500);
            tower2.Print();
            Console.WriteLine("\n=====================\n");
            //Thread.Sleep(500);
            tower3.Print();
            Console.WriteLine("\n=====================\n");
            Thread.Sleep(500);
        }
        
        // Metodo que checa si se ha completado el juego
        public bool Win()
        {
            if(tower3.disks == null){ return false; }
            if(tower3.Get() == 1 && tower3.disks.length == diskNumber)
            { 
                Console.WriteLine("Ganaste!");
                return true; 
            }
            return false; 
        }
        
        // Metodo que permite Jugar
        public void Play(Tower towerA, Tower towerB)
        {
            towerA.Move(towerB);
            ShowTowers();
            Win();
        }
        
        // Metodo que resuelve el juego 
        public void SolveTower(int n, Tower origin, Tower destination, Tower auxiliary)
        {
            if (n == 0) return;

            SolveTower(n - 1, origin, auxiliary, destination);
            Play(origin,destination);
            Thread.Sleep((int)moveInterval);
            SolveTower(n - 1, auxiliary, destination, origin);
        }
        
        // Metodo que inicia el juego 
        public void Start()
        {
            Console.WriteLine("\nBienvenido Al Juego De La Torre De Hanoi\n");
            Console.WriteLine("Presione Enter Para Iniciar El Juego");
            Console.ReadKey();
                
            int option = 0;
            GameLoop(ref option);
        }
        
        // Loop en el que se ejecuta el juego
        public void GameLoop(ref int option)
        {
            Console.Write("Introduzca La Cantidad De Discos: ");
            diskNumber = Convert.ToInt32(Console.ReadLine());
            
            tower1 = new Tower("Torre 1",diskNumber);
            tower2 = new Tower("Torre 2");
            tower3 = new Tower("Torre 3");
            ShowTowers(); // Muestra las torres antes de empezar los movimientos
            
            do // Ciclo que se repita hasta que se elija una opcion valida
            {
                Actions(ref option); // Movimientos posibles del jugador
                if(option == 9){ return;} // Cierra el juego si el jugador asi lo desea
            } while(true | option != 9);
        }
        
        // Metodo que deja elegir las movimientos del jugador
        public void Actions(ref int option)
        {
            Console.WriteLine("¿Que desea realizar?\n");
            Console.Write("1. Mover Un Disco De La Torre 1 a la Torre 2     ");
            Console.WriteLine("2. Mover Un Disco De La Torre 1 a la Torre 3     ");
            Console.Write("3. Mover Un Disco De La Torre 2 a la Torre 1     ");
            Console.WriteLine("4. Mover Un Disco De La Torre 2 a la Torre 3     ");
            Console.Write("5. Mover Un Disco De La Torre 3 a la Torre 1     ");
            Console.WriteLine("6. Mover Un Disco De La Torre 3 a la Torre 2     ");
            Console.Write("7. Resolver El Juego     ");
            Console.Write("8. Jugar De Nuevo     ");
            Console.Write("9. Salir Del Juego       \n");
            
            option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1: 
                    Play(tower1,tower2);
                    break;
                case 2: 
                    Play(tower1,tower3);
                    break;
                case 3: 
                    Play(tower2,tower1);
                    break;
                case 4: 
                    Play(tower2,tower3);
                    break;
                case 5: 
                    Play(tower3,tower1);
                    break;
                case 6: 
                    Play(tower3,tower2);
                    break;
                case 7:
                    SolveTower(diskNumber,tower1,tower3,tower2);
                    break;
                case 8:
                    Console.WriteLine();
                    GameLoop(ref option);
                    break;
                case 9: 
                    Console.WriteLine("Gracias Por Jugar!");
                    break;
                default: 
                    Console.WriteLine("Elija una opcion entre 1 y 9");
                    break;
            }
        }
    }
}
