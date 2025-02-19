using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Structure.Stack;

namespace HanoiTowers
{
    class Tower
    {
        public Stack disks; // Stack en el que se almacenan los discos
        
        // Constructor de la clase Tower
        // Recibe un numero de discos y los agrega a la torre
        public Tower(string name, int number) 
        {
            disks = new Stack(name);
            for(int i = 0; i < number; i++)
            {
                disks.Push(number - i);
            }
        }
        
        // Constructor de la clase Tower
        // Crea la torre sin ningun disco
        public Tower(string name)
        {
            disks = new Stack(name);
        }
        
        // Metodo que permite mover discos entre dos torres
        public void Move(Tower towerA, Tower towerB)
        {
            // Retorna un mensaje al usuario mostrandole que el movimiento no es valido
            if (disks.IsEmpty()){ Console.WriteLine("\nTorre Vacia, Intente Otro Movimiento"); }
            
            // Mueve el disco de la torre A a la torre B si no hay discos en la torre B
            else if(towerB.Get() == 0){ towerB.disks.Push(towerA.disks.Pop()); }
            
            // Retorna un mensaje de error si el disco de la Torre A es mayor al disco de la Torre B
            else if(towerA.Get() > towerB.Get()){ Console.WriteLine("\nILEGALISIMO"); }
            
            // Mueve el disco de una torre a otra
            else{ towerB.disks.Push(towerA.disks.Pop()); }
        }
        
        // Metodo que imprime una torre
        public void Print()
        {
            disks.Print();
        }
        
        // Metodo que retorna el primer disco de la torre
        public int Get()
        {
            return disks.Peek();
        }
        
         // Metodo que retorna el disco siguiente de la torre
        public int GetNext()
        {
            return disks.head.next.data;
        }
    }
}