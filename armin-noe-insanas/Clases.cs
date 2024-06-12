using System.Reflection.Metadata.Ecma335;
namespace libreria{
    public class perro{
        public int edad;
        public string raza;
        public string tamano;
        public void jugar(){
            Console.WriteLine("jugar");
        }
        public string ladrar()
        {
            return "gua gua ";
        }
    }
}