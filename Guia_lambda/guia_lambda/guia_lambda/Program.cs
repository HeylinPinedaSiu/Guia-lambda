using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guia_lambda
{ 
    public class Program
    {
            static void Main(string[] args)
            {
                Console.WriteLine();
            Console.WriteLine("▒▒▒▒ Bienvenido al sistema de notas lambda ▒▒▒▒");
                Console.WriteLine();

                List<Estudiante> estudiantes = new List<Estudiante>
             {
            
               new Estudiante { Nombre = "Gerson", Edad = 22, Nota = 80 },
               new Estudiante { Nombre = "Arlen", Edad = 15, Nota = 50 },
               new Estudiante { Nombre = "Heylin", Edad = 20, Nota = 85},
               new Estudiante { Nombre = "Eymi", Edad = 19, Nota = 70 },
               new Estudiante { Nombre = "Miguel", Edad = 17, Nota = 90 }
             };

             /* "Where(e => e.Edad > 18)"   es un metodo de
             * LINQ que filtra la coleccion "estudiante", este 
              aplica una expresion lambda
              "e => e.Edad > 18" que significa,
             "Seleccionar aquellos 
              estudiantes cuya edad sea mayor a 18".*/
            var estudiante_mayor_DE_18 = estudiantes.Where(e => e.Edad > 18);
                Console.WriteLine("Los estudiantes que son mayores de edad");

            /*utilizamos foreach
             * para iterar sobre una coleccion de elementos*/
            foreach (var estudiante in estudiante_mayor_DE_18)
                {
                    
                    Console.WriteLine($"nombre: {estudiante.Nombre},edad: {estudiante.Edad}");
                }
                Console.WriteLine();

            /*"OrderByDescending(e => e.Nota)" -> Es un metodo de LINQ 
             * que ordena la coleccion "estudiantes"en orden 
                descendente segun la propiedad 
            "Nota"  de cada estudiante.   */
          
            var estudiante_nota_Maxima = estudiantes.OrderByDescending(e => e.Nota).FirstOrDefault();
                Console.WriteLine($"Estudiante con la nota más alta: {estudiante_nota_Maxima.Nombre}, Nota: {estudiante_nota_Maxima.Nota}");
                Console.WriteLine();

             /*OrderBy(e => e.Nombre)" -> es un metodo de LINQ el cual
             ordena la lista "estudiante" en orden ascendente 
              segun la propiedad Nombre de cada estudiante.  */
            
            var estudiantesOrdenadosNombre = estudiantes.OrderBy(e => e.Nombre);
                Console.WriteLine("Estudiantes ordenados por nombre:");
                foreach (var estudiante in estudiantesOrdenadosNombre)
                {
                    Console.WriteLine($"Nombre: {estudiante.Nombre}");
                }
                Console.WriteLine();

                
                var promedioNotas = estudiantes.Average(e => e.Nota);
                Console.WriteLine($"Promedio de notas: {promedioNotas}");

            }
        }
    }
