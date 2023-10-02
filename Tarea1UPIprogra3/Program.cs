using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tarea1UPIprogra3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int opcion = 0;
            do //ejecuta primero y luego evalua
            {
                Console.Clear();    
                Console.WriteLine("1- Ejercicio 1");
                Console.WriteLine("2- Ejercicio 2");
                Console.WriteLine("3- Ejercicio 3");
                Console.WriteLine("4- Salir");

                Console.WriteLine("Digite una opción");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {

                    case 1:
                        Ejercicio1();
                        break;
                    case 2: Ejercicio2(); 
                        break;
                        
                    case 3: Ejercicio3(); 
                        break;
                      
                    case 4: break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Opción incorrecta");
                        Console.ReadLine();
                        break;
                }

            } while (opcion!=4); 


        }

        //1 camisa sin descuento
        // de 2 a 5 con 15 % descuento
        // mas de 5 con 20$
        static void Ejercicio1()
        {

            float precio = 0;
            int cantidad = 0;

            Console.WriteLine("Digite el precio");
            precio= float.Parse(Console.ReadLine());    

            Console.WriteLine("Digite la cantidad de camisas");
            cantidad= int.Parse(Console.ReadLine()) ;



            if (cantidad==1)
            {
                Console.WriteLine($"El precio de la camisa es de:   { cantidad * precio}");
            } else
            if (cantidad >= 2 && cantidad<=5) 
            {
                Console.WriteLine($"El precio de la camisa es es de {(precio-(precio*0.15))*cantidad} con descuento de 15%");   
            } else
            if (cantidad>=5)
            {
                Console.WriteLine($"El precio de la camisa es es de {(precio - (precio * 0.20)) * cantidad} con descuento de 20%");
            }

            Console.ReadLine() ;    


        }

        static void Ejercicio2()
        {

            float precio = 0;
            int cantidad = 0;
            float promediofinal = 0;
            int carnet = 0;
            string nombre = "";
            float quiz1 = 0;
            float quiz2 = 0;
            float quiz3 = 0;
            float tarea1 = 0;
            float tarea2 = 0;
            float tarea3 = 0;
            float examen1 = 0;
            float examen2 = 0;
            float examen3 = 0;
            float porcentajequices = 0;
            float porcentajetareas = 0;
            float porcentajeexamentes = 0;
            string condicionestudiante = "";
      
            Console.WriteLine("Digite numero de carnet del estudiante");
            carnet = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite el nombre del estudiante");
            nombre = Console.ReadLine();

            Console.WriteLine("Digite nota del quiz 1");
            quiz1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite nota del quiz 2");
            quiz2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite nota del quiz 3");
            quiz3 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite nota del tarea 1");
            tarea1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite nota del tarea 2");
            tarea2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite nota del tarea 3");
            tarea3 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite nota del examen 1");
            examen1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite nota del examen 2");
            examen2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite nota del examen 3");
            examen3 = float.Parse(Console.ReadLine());

            porcentajequices = (quiz1 + quiz2 + quiz3)/3;
            porcentajequices = porcentajequices* 25 ;
            porcentajequices = porcentajequices/ 100;
            porcentajetareas = (tarea1 + tarea2 + tarea3)/3;
            porcentajetareas = porcentajetareas * 30;
            porcentajetareas = porcentajetareas/100;
            porcentajeexamentes = (examen1 + examen2 + examen3)/3;
            porcentajeexamentes = porcentajeexamentes* 45;
            porcentajeexamentes = porcentajeexamentes/100;
            promediofinal = porcentajequices + porcentajetareas + porcentajeexamentes;

            if (promediofinal >= 70)
            {
                condicionestudiante = "Aprobado";
            }
            else
            {
                if (promediofinal >= 50 && promediofinal <= 70)
                {
                    condicionestudiante = "Aplazado";
                }
                else
                {
                    condicionestudiante = "Reprobado";
                }

            }

            Console.WriteLine($"Carnet:{carnet} ");
            Console.WriteLine($"Nombre Estudiante:{nombre} ");
            Console.WriteLine($"porcentaje de quices (25%):{porcentajequices} ") ;
            Console.WriteLine($"porcentaje de tareas (30%):{porcentajetareas} ");
            Console.WriteLine($"porcentaje de examenes (45%):{porcentajeexamentes} ");
            Console.WriteLine($"promedio Final:{promediofinal} ");
            Console.WriteLine($"condicion del Estudiante:{condicionestudiante} ");

            Console.ReadLine();

        }

        static void Ejercicio3() 
        {
            float preciototal = 0;
            int cantidadproductos = 0;
            float precioarticulo = 0;

            Console.WriteLine("Digite cantidad de productos a comprar");
            cantidadproductos = int.Parse(Console.ReadLine());

            
            if (cantidadproductos <= 10)
            {
                precioarticulo = 20;
                Console.WriteLine($"la cantidad de productos adquiridos:   {cantidadproductos}");
                Console.WriteLine($"El precio por unidad:  $  {precioarticulo}");
                Console.WriteLine($"El precio total:   {preciototal = precioarticulo * cantidadproductos}");
            }
            else
               {
                precioarticulo = 15;
                Console.WriteLine($"la cantidad de productos adquiridos:   {cantidadproductos}");
                Console.WriteLine($"El precio por unidad:  $  {precioarticulo}");
                Console.WriteLine($"El precio total:   {preciototal = precioarticulo * cantidadproductos}");
            }

            Console.ReadLine();
        }

    }
}

