using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ConsoleApplication15
{
    class Calculadora //Nombre de nuestra clase.
    {
        static void Main(string[] args)
        {
            Console.Title = "Nombre: Miguel Andino matricula:10-EIST-1-163  Seccion: 908"; //Sirve para agregarle un titulo a la ventana
            string resp = "";
             int t = 0;

                string nombre;
                double descuento1, descuento2, sueldo, sueldototal, sueldobruto, ISR;
            do
            {
               
                //Aqui mostraremos los mensajes que apareceran en nuestra consola igual que el menu de seleccion.
                Console.Clear();
                Console.WriteLine("");
                Console.WriteLine("     Nombre: Miguel Andino  Matricula:10-EIST-1-163  Seccion: 908");
                Console.WriteLine("");
                Console.WriteLine("     Presione el simbolo para realizar la operacion:n");
                Console.WriteLine("");
                Console.WriteLine("     1 Sueldos Menores A $34685.00");
                Console.WriteLine("     2 Sueldos Mayores A $34685.01 Y Menores A $52027.41");
                Console.WriteLine("     3 Sueldos Mayores A $52027.42");
                Console.WriteLine("     4 Salir: "); 
                resp = Console.ReadLine();
                string eleccion = Convert.ToString(resp);
                
                switch (eleccion)

                {

                    case "1":
                        Console.WriteLine("INTRODUCE LA CANTIDAD DE SUELDOS A CALCULAR");
                         int.TryParse(Console.ReadLine(), out t);
                         for (int i = 0; i < t; i++)
                         {
                             Console.WriteLine("INGRESA EL NOMBRE DEL EMPLEADO:");
                             nombre = Console.ReadLine();
                             Console.WriteLine("INGRESA EL SUELDO:");
                             sueldo = int.Parse(Console.ReadLine());

                             descuento1 = (sueldo * 0.0304);
                             descuento2 = (sueldo * 0.0287);

                             sueldobruto = (sueldo - descuento1);
                             sueldobruto = sueldobruto - descuento2;
                             if (sueldobruto < 34685.00)
                             {
                                 Console.WriteLine("");
                                 Console.WriteLine("No se Cobra ISR");
                                 Console.WriteLine("El Sueldo Total es:" + sueldo);
                                 Console.WriteLine("El Descuento SFS es:" + descuento1);
                                 Console.WriteLine("El Descuento AFP es:" + descuento2);
                                 /* Console.WriteLine("El ISR es:" + ISR);*/
                                 Console.WriteLine("El Sueldo Neto Es igual a:" + sueldobruto);

                                 Console.Read();
                                 Console.ReadLine();
                             }
                             else if(sueldobruto > 34685.00)
                             { Console.WriteLine("Es Mayor de lo que se puede calcular");
                             Console.Write("¿Desea Continuar? s/n: "); //Si para realizarlo de nuevo y no para salir.

                             resp = Console.ReadLine();
                             }
                         }

                        break;

                    case "2":
                         Console.WriteLine("INTRODUCE LA CANTIDAD DE SUELDOS A CALCULAR");
                         int.TryParse(Console.ReadLine(), out t);
                         for (int i = 0; i < t; i++)
                         {
                        Console.WriteLine("INGRESA EL NOMBRE DEL EMPLEADO:");
                         nombre = Console.ReadLine();
                         Console.WriteLine("INGRESA EL SUELDO:");
                         sueldo = int.Parse(Console.ReadLine());

                             descuento1 = (sueldo * 0.0304);
                              descuento2 = (sueldo * 0.0287);

                              sueldobruto = (sueldo - descuento1);
                              sueldobruto = sueldobruto - descuento2;

                              if (sueldobruto > 34685.00 && sueldobruto < 52027.41)
                              {
                                  ISR = sueldobruto * 0.15;
                                  sueldobruto = sueldobruto - ISR;



                                  Console.WriteLine("El Sueldo Total es:" + sueldo);
                                  Console.WriteLine("El Descuento SFS es:" + descuento1);
                                  Console.WriteLine("El Descuento AFP es:" + descuento2);
                                  Console.WriteLine("El ISR es:" + ISR);
                                  Console.WriteLine("El Sueldo Neto Es igual a:" + sueldobruto);

                                 
                                  Console.Read();
                                  Console.ReadLine();
                              }
                              else
                              {
                                  Console.WriteLine("Es Mayor/Menor de lo que se puede calcular");
                                  Console.Write("¿Desea Continuar? s/n: "); //Si para realizarlo de nuevo y no para salir.

                                  resp = Console.ReadLine();
                              }
                }

                        break;

                    case "3":
                         Console.WriteLine("INTRODUCE LA CANTIDAD DE SUELDOS A CALCULAR");
                         int.TryParse(Console.ReadLine(), out t);
                         for (int i = 0; i < t; i++)
                         {
                             Console.WriteLine("INGRESA EL NOMBRE DEL EMPLEADO:");
                             nombre = Console.ReadLine();
                             Console.WriteLine("INGRESA EL SUELDO:");
                             sueldo = int.Parse(Console.ReadLine());

                             descuento1 = (sueldo * 0.0304);
                             descuento2 = (sueldo * 0.0287);

                             sueldobruto = (sueldo - descuento1);
                             sueldobruto = sueldobruto - descuento2;

                             if (sueldobruto > 52027.41)
                             {

                                 ISR = sueldobruto * 0.20;
                                 sueldobruto = sueldobruto - ISR;
                                 Console.WriteLine("El Sueldo Total es:" + sueldo);
                                 Console.WriteLine("El Descuento SFS es:" + descuento1);
                                 Console.WriteLine("El Descuento AFP es:" + descuento2);
                                 Console.WriteLine("El ISR es:" + ISR);
                                 Console.WriteLine("El Sueldo Neto Es igual a:" + sueldobruto);
                                 Console.Read();
                                 Console.ReadLine();
                             }
                             else if (sueldobruto < 52027041)
                             {
                                 Console.WriteLine("Es Menor de lo que se puede carcular");
                                 Console.WriteLine("¿Desea Continuar? s/n:");
                                 resp = Console.ReadLine();
                             }
                         }
                        break;

                    case "4":
                        break;

                }

                Console.Write("¿Desea Continuar? s/n: "); //Si para realizarlo de nuevo y no para salir.

                resp = Console.ReadLine();

            }

            while (resp == "s" || resp == "s");

        }
    }

    }

