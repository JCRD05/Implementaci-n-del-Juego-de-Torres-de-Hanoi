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
        
        // Recibe un numero de discos y los agrega a la torre
        public Tower(string name, int number) 
        {
            disks = new Stack(name);
            for(int i = 0; i < number; i++)
            {
                disks.Push(number - i);
            }
        }
        
        // Crea la torre sin ningun disco
        public Tower(string name)
        {
            disks = new Stack(name);
        }
        
        // Metodo que permite mover discos entre dos torres
        public void Move(Tower tower)
        {
            // Retorna un mensaje al usuario mostrandole que el movimiento no es valido
            if (disks.IsEmpty()){ Console.WriteLine("\nTorre Vacia, Intente Otro Movimiento"); }
            
            // Retorna un mensaje de error si el disco de la Torre A es mayor al disco de la Torre B
            else if(Get() > tower.Get() && tower.Get() != 0){ Console.WriteLine("\nILEGALISIMO"); }
            
            // Mueve el disco de una torre a otra
            else{ tower.disks.Push(disks.Pop()); } 
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
    }
}
