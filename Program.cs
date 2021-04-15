using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAI
{
    class Program
    {
        static void Main(string[] args)
        {          
            List<string> listaOperarios;
            listaOperarios = new List<string>();

            string nombreOperario;

            int breakIngresoOperarios = 0;
            do
            {
                Console.WriteLine("Ingrese el nombre de un operario. Presione 0 para finalizar.");
                nombreOperario = Console.ReadLine();
                
                bool ok = false;
                while (!ok)
                {
                    string ingreso = Console.ReadLine();
                    ok = string.IsNullOrEmpty(nombreOperario);
                    if (!ok)
                    {
                        Console.WriteLine("No ha ingresado un nombre valido.");
                    }
                    else if (breakIngresoOperarios == 0)
                    {
                        break;
                    }
                    else
                    {
                        listaOperarios.Add(nombreOperario);
                        break;
                    }
                }
            } while (breakIngresoOperarios != 0);
            
            List<int> listaOrdenes;
            listaOrdenes = new List<int>();

            int breakIngresoOrdenes = 0;
            do
            {
                Console.WriteLine("Ingrese una nueva orden. Presione 0 para finalizar.");
                bool ok = false;
                
                while (!ok)
                {
                    string ingreso = Console.ReadLine();
                    ok = int.TryParse(ingreso, out breakIngresoOrdenes);
                    if (!ok)
                    {
                        Console.WriteLine("No ha ingresado un entero valido.");
                    }
                    else if (breakIngresoOrdenes == 0)
                    {
                        break;
                    }
                    else
                    {
                        listaOrdenes.Add(breakIngresoOrdenes);
                        break;
                    }
                }
            } while (breakIngresoOrdenes != 0);
        }
    }
}
