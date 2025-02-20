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
        private string name; 
        public int length; // Variable que almacena la cantidad de elementos del stack
        
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
            if(IsEmpty()) { head = new Node(data); } 
            else { head = new Node(data, head); }
            length++;
        }
        
        // Metodo que elimina un elemento del principio del stack y lo retorna
        public int Pop()
        {
            if(IsEmpty()) { return 0; } 
            
            int erasedData = head.data; 
            
            if(length == 1) { head = null; }
            else { head = head.next; }
            length--;
            
            return erasedData; 
        }
        
        // Metodo que retorna el elemento que se encuentra al principio del stack
        public int Peek() 
        {
            if (IsEmpty()) { return 0; } 
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
                int[] stackData = new int[length];
                
                for(int i = 0; i < length; i++)
                {
                    stackData[i] = current.data;
                    current = current.next;
                } 
                
                int space = 0;
                int level = length;
                
                // Muestra La Torre En Forma De Piramide 
                for(int i = 0; i < length; i++) 
                {
                    for (int j = length - 1; j > i - 1; j--) 
                    {
                        Console.Write(" ");
                    }
                    
                    for (int j = 0; j < space; j++)
                    {
                        Console.Write(" ");
                        space -= 1;
                    }
                    
                    for (int j = 0; j < stackData[i]; j++)
                    {
                        Console.Write(stackData[i]);
                        Console.Write(" ");
                    }
                    level--;
                    Console.WriteLine();
                }
            }
        }
        
        // Metodo que checa si la pila se encuentra vacia
        public bool IsEmpty() 
        {
            if (length == 0) { return true; }
            else { return false; }
        }
    }
}
