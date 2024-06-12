using System;
using libreria;

namespace principal{
    class programacionprincipal{

        static void Main(){

            string nombre;
            nombre ="juan";
           
            perro firulai;
            firulai = new perro();
            
            perro pedro;
            pedro = new perro();

            Console.WriteLine("hola");

            firulai.edad =2;

            firulai.tamano= "grande";

            firulai.raza= "caniche";

            firulai.jugar();
            Console.WriteLine(firulai.ladrar());
        }
    }
}