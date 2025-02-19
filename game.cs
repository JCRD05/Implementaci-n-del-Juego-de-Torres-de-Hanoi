using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Structure.Stack;

namespace HanoiTowers
{
    class Game
    {
        // Torres utilizadas en el juego
        public Tower tower1; 
        public Tower tower2;
        public Tower tower3;
        
        // Numero de discos definido por el jugador
        public int number;
        
        // Constructor del juego
         public Game()
        {
            number = 0;
            tower1 = new Tower("Torre 1");
            tower2 = new Tower("Torre 2");
            tower3 = new Tower("Torre 3");
        }
        
        // Metodo que muestra las tres torres en la consola
        public void ShowTowers()
        {
            tower1.Print();
            Console.WriteLine("\n=====================\n");
            tower2.Print();
            Console.WriteLine("\n=====================\n");
            tower3.Print();
            Console.WriteLine("\n=====================\n");
        }
        
        // Metodo que checa si se ha completado el juego
        public bool Win()
        {
            if(tower3.disks == null){ return false; }
            else if(tower3.Get() < number + 1){ return false; }
            else { return true; }
        }
        
        // Metodo que permite Jugar
        // Mueve discos entre torres
        // Muestra las torres despues de cada movimiento
        // Checa si el jugador ha terminado el juego
        public void Play(Tower towerA, Tower towerB)
        {
            towerA.Move(towerA,towerB);
            ShowTowers();
            Win();
        }
        
        // Metodo que inicia el juego y despliega el menu
        // Deja al jugador elegir el numero de discos de la partida
        public void Start()
        {
            Console.WriteLine("\nBienvenido Al Juego De La Torre De Hanoi\n");
            Console.WriteLine("Presione Enter Para Iniciar El Juego");
            Console.ReadKey();
            
            Console.WriteLine("\nIntroduzca La Cantidad De Discos: ");
            int number = Convert.ToInt32(Console.ReadLine());
            
            tower1 = new Tower("Torre 1",number);
            ShowTowers(); // Muestra las torres antes de empezar los movimientos
            
            int option = 0;
            do // Ciclo que se repita hasta que se elija una opcion valida
            {
                Console.WriteLine("¿Que desea realizar?\n");
                Console.WriteLine("1. Mover Un Disco De La Torre 1 a la Torre 2\n");
                Console.WriteLine("2. Mover Un Disco De La Torre 1 a la Torre 3\n");
                Console.WriteLine("3. Mover Un Disco De La Torre 2 a la Torre 1\n");
                Console.WriteLine("4. Mover Un Disco De La Torre 2 a la Torre 3\n");
                Console.WriteLine("5. Mover Un Disco De La Torre 3 a la Torre 1\n");
                Console.WriteLine("6. Mover Un Disco De La Torre 3 a la Torre 2\n");
                Console.WriteLine("7. Salir Del Juego\n");
                option = Convert.ToInt32(Console.ReadLine());
                
                Operations(ref option); // Movimientos posibles del jugador
                if(option == 7){ return; } // Cierra el juego si el jugador asi lo desea
            }while(option > 0 && option < 8);
        }
        
        // Metodo que deja elegir las movimientos del jugador
        public void Operations(ref int option)
        {
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
                    Console.WriteLine("Gracias Por Jugar!");
                    break;
                default: 
                    Console.WriteLine("Elija una opcion entre 1 y 7");
                    break;
            }
        }
    }
}