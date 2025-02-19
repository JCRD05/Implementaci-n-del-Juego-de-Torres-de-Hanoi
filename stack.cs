using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Structure.Stack
{
    class Stack
    {
        public Node head; // Primer elemento del stack o top
        private string name; // Nombre del stack
        private int length; // Variable que almacena la cantidad de elementos del stack
        
        // Constructor de la clase Stack
        // Crea la estructura sin ningun dato almacenado
        public Stack(string name) 
        {
            this.name = name;
            head = null;
            length = 0;
        }
        
        // Metodo que agrega un elemento al principio del stack
        public void Push(int data)
        {
            // Si esta vacio crea un nuevo nodo y almacena el elemento
            if(IsEmpty()){ head = new Node(data); } 
            else { head = new Node(data, head); }
            length++;
        }
        
        // Metodo que elimina un elemento del principio del stack
        public int Pop()
        {
            if(IsEmpty()){ return 0; } // Si el stack esta vacio retorna la funcion
            
            int erasedData = head.data; // Almacena el dato del elemento eliminado
            
            if(length == 1){ head = null; }
            else { head = head.next; }
            length--;
            
            return erasedData; // Retorna el elemento eliminado
        }
        
        // Metodo que retorna el elemento que se encuentra al principio del stack
        public int Peek() 
        {
            if (IsEmpty()){ return 0; } // Si el stack esta vacio retorna 0
            else { return head.data; } 
        }
        
        // Metodo que imprime en la consola los elementos del stack
        public void Print()
        {
            // Si la pila esta vacia retorna un mensaje de error
            if (IsEmpty()) 
            { 
                Console.WriteLine("\n" + name + "\n"); 
                Console.WriteLine("No hay discos"); 
            }
            else 
            {
                Node current = head;
                Console.WriteLine("\n" + name + "\n");
                for(int i = 0; i < length; i++)
                {
                    Console.WriteLine(current.data);
                    current = current.next;
                } 
                Console.WriteLine("\n");
            }
        }
        
        // Metodo que checa si la pila se encuentra vacia
        public bool IsEmpty() 
        {
            if (length == 0){ return true; }
            else { return false; }
        }
    }
}