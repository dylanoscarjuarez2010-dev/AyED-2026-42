using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plantilla
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                            Etapa 5

   Paradigmas Programación Orientada a Objetos (POO)

Abstracción
Modularidad
Encapsulamiento
Ocultamiento


         Abstracción

thing object

      mate profe    

mate
altura = 10cm                                                                       
tieneBombilla = true
capacidad = 70ml                                      ATRIBUTOS
radio = 4cm
material = “Quebracho”

tomar(): void                                              METODO   
cebar():void

                          Atributos (Características)
Objeto 
                          Método (Función)    


      mate rojo

mate
altura = 12cm                                                                       
tieneBombilla = false
capacidad = 60ml                                      ATRIBUTOS
radio = 2.5cm
material = “Cuero”

tomar(): void                                              METODO   
cebar():void


        mate abuela

mate
altura = 5cm                                                                       
tieneBombilla = false
capacidad = 30ml                                      ATRIBUTOS
radio = 2cm
material = “Aluminio”

tomar(): void                                              METODO   
cebar():void

        mate eurocopa
        
mate
altura = 11cm                                                                       
tieneBombilla = false
capacidad = 55ml                                      ATRIBUTOS
radio = 2.5cm
material = “Aluminio”

tomar(): void                                              METODO   
cebar():void
               

        mate brrr brr patapin

mate
altura = 9cm                                                                       
tieneBombilla = false
capacidad = 50ml                                      ATRIBUTOS
radio = 3cm
material = “Aluminio”

tomar(): void                                              METODO   
cebar():void


          mate cana

mate
altura = 8cm                                                                       
tieneBombilla = false
capacidad = 45ml                                      ATRIBUTOS
radio = 2.5cm
material = “Cerámica”

tomar(): void                                              METODO   
cebar():void

             */

            Mate mateProfe = new Mate(10, 4, 70, true, "Quebracho");

            Mate mateRojo = new Mate(12, 2.5, 60, false, "Vidrio");

            Mate mateAbuela = new Mate(5, 2, 30, false, "Aluminio");

            Mate mateEurocopa = new Mate(11, 2.5, 55, false, "Aluminio");

            Mate mateBrrBrrPatapin = new Mate(9, 3, 50, false, "Aluminio");

            Mate mateCana = new Mate(8, 2.5, 45, false, "Cerámica");
        }
    }

    class Mate
    {
        //ATRIBUTOS
        private double altura;
        private bool tieneBombilla;
        private int capacidad;
        private double radio;
        private string material;
        private int cantAgua = 0;

        //CONSTRUCTOR
        public Mate(double altura, double radio, int capacidad, bool tieneBombilla, string material)
        {
            this.altura = altura;
            this.radio = radio;
            this.capacidad = capacidad;
            this.tieneBombilla = tieneBombilla;
            this.material = material;
        }

        public int getCantAgua()
        {
            return cantAgua;
        }

        //METODOS
        public void cebar()
        {
            cantAgua = capacidad;
        }

        public void tomar(int Capacidad)
        {
            cantAgua -= capacidad;
        }
    }
}
