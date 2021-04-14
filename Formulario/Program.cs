using System;

namespace Formulario
{
    class personal 
    {
        private string Nombre;
        private string Apellido;
        private int Edad;
        private int salario;
        private int fecha_de_nacimieto;
        private string lugar_de_residencia;
        private string nivel_de_escolaridad;
        private string carrera_univesitaria;
        
        personal() { }

        public void setNombre(string Nombre) 
        {
            this.Nombre = Nombre;
        }
       
        public void getNombre()
        {
            Console.WriteLine("Nombre:" + Nombre);
        }

        public void setApellido(string Apellido)
        {
            this.Apellido = Apellido;
        }

        public void getApellido()
        {
            Console.WriteLine("Apellido:" + Apellido);
        }

        public void setEdad(int Edad)
        {
            this.Edad = Edad;
        }

        public void getEdad()
        {
            Console.WriteLine("Edad:" + Edad);
        }

        public void setsalario(int salario)
        {
            this.salario = salario;
        }

        public void getsalario()
        {
            Console.WriteLine("salario:" + salario);
        }

        public void setfecha_de_nacimieto(int fecha_de_nacimieto)
        {
            this.fecha_de_nacimieto = fecha_de_nacimieto;
        }

        public void getfecha_de_nacimieto()
        {
            Console.WriteLine("fecha_de_nacimieto:" + fecha_de_nacimieto);
        }

        public void setlugar_de_residencia(string lugar_de_residencia)
        {
            this.lugar_de_residencia = lugar_de_residencia;
        }

        public void getlugar_de_residencia()
        {
            Console.WriteLine("lugar_de_residencia:" + lugar_de_residencia);
        }

        public void setnivel_de_escolaridad(string nivel_de_escolaridad)
        {
            this.nivel_de_escolaridad = nivel_de_escolaridad;
        }

        public void getnivel_de_escolaridad()
        {
            Console.WriteLine("nivel_de_escolaridad:" + nivel_de_escolaridad);
        }

        public void setcarrera_univesitaria(string carrera_univesitaria)
        {
            this.carrera_univesitaria = carrera_univesitaria;
        }

        public void getcarrera_univesitaria()
        {
            Console.WriteLine("carrera_univesitaria:" + carrera_univesitaria);
        }

        static void Main(string[] args)
        {

            personal personal = new personal();

            personal.setNombre("Manuel");
            personal.setApellido("perez rojas");
            personal.setEdad(30);
            personal.setsalario(30000);
            personal.setfecha_de_nacimieto(13_12_1994);
            personal.setlugar_de_residencia("santo domingo");
            personal.setnivel_de_escolaridad("nivel medio");
            personal.setcarrera_univesitaria("programacion");

            personal.getNombre();
            personal.getApellido();
            personal.getEdad();
            personal.getsalario();
            personal.getfecha_de_nacimieto();
            personal.getlugar_de_residencia();
            personal.getnivel_de_escolaridad();
            personal.getcarrera_univesitaria();








        }


    }
    

    
}
