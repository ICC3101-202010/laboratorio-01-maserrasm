using System;



namespace Lab1
{   

    public class Person
    {
        string nombre;
        string apellido;

        // Constructor de objeto tipo persona que servira para parte 2 de Lab. 
        public Person(string name, string lastName) {
            nombre = name;
             apellido = lastName; 
        }

        // Funciones que retornan nombre y apellido.

        public string firstName() {
            return nombre;
        }

        public string lastName()
        {
            return apellido;
        }

        // Funcion que retorna integer resultado de lanzamiento. 

        public int lanzar()
        {
            Random rand = new Random();
            int play = rand.Next(0, 2);
            return play;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Creo objeto de tipo persona, le doy nombre y apellido, hago la jugada y muestro en consola.

            Person Manuel = new Person("Manuel", "Serra");
            int jugada = Manuel.lanzar();
            Console.WriteLine(jugada);

            // Ahora ocupo constructor de persona para crear persona de nombre Bob
            // y apellido Kunga

            Person BobK = new Person("Bob", "Kunga");


        }
    }
}
