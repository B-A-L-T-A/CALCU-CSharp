using System;
using System.Threading;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            carga();
            Console.Clear();
            string ejecutar;
            Console.WriteLine("\n\n[ ¿Desea ejecutar la Calculadora? ]\n");
            Console.WriteLine("[1]. Si");
            Console.WriteLine("[2]. No\n");
            Console.WriteLine("[*] Elija : ");
            ejecutar = Console.ReadLine();
            float ejec = Convert.ToSingle(ejecutar);
            while (ejec == 1)
            {
                inicio();
                string elija;
                Console.WriteLine("[*] Elija : ");
                elija = Console.ReadLine();
                float elija2 = Convert.ToSingle(elija);

                if (elija2 == 1)
                {
                    Console.WriteLine("\n[*] ═══════════════════════════════════════");
                    string radius;
                    Console.WriteLine("[*] Por favor ingrese un radio : ");
                    radius = Console.ReadLine();
                    float rad = Convert.ToSingle(radius);
                    float c = 2 * 3.14f * rad;
                    Console.WriteLine("[+] La circunferencia es : {0}", c);
                    Console.WriteLine("[*] ═══════════════════════════════════════\n");
                    Console.WriteLine("\n[ La calculadora iniciará de nuevo en 10 segundos ]");
                    Thread.Sleep(10000);
                }
                else if (elija2 == 2)
                {
                    Console.WriteLine("\n[*] ═══════════════════════════════════════");
                    string circunferencia;
                    Console.WriteLine("[*] Por favor ingrese la circunferencia : ");
                    circunferencia = Console.ReadLine();
                    float cir = Convert.ToSingle(circunferencia);
                    float rad = cir / 2 * 3.14f;
                    Console.WriteLine("[+] La circunferencia es : {0}", rad);
                    Console.WriteLine("[*] ═══════════════════════════════════════\n");
                    Console.WriteLine("\n[ La calculadora iniciará de nuevo en 10 segundos ]");
                    Thread.Sleep(10000);
                }
                else if (elija2 == 3)
                {
                    Console.WriteLine("\n[*] ═══════════════════════════════════════");
                    string ladoA;
                    string ladoB;
                    Console.WriteLine("[*] Por favor ingrese el valor del lado A : ");
                    ladoA = Console.ReadLine();
                    Console.WriteLine("[*] Por favor ingrese el valor del lado B : ");
                    ladoB = Console.ReadLine();

                    float a = Convert.ToSingle(ladoA);
                    float b = Convert.ToSingle(ladoB);

                    double h2 = Math.Pow(a, 2) + Math.Pow(b, 2);
                    double h = Math.Sqrt(h2);

                    Console.WriteLine("[+] La hipotenusa es {0}", h);
                    Console.WriteLine("[*] ═══════════════════════════════════════\n");
                    Console.WriteLine("\n[ La calculadora iniciará de nuevo en 10 segundos ]");
                    Thread.Sleep(10000);
                }

                else if (elija2 == 4)
                {
                    Console.WriteLine("\n[*] ═══════════════════════════════════════");
                    string num1;
                    string num2;
                    Console.WriteLine("[*] Ingresa el primer numero : ");
                    num1 = Console.ReadLine();
                    Console.WriteLine("[*] Ingresa el segundo numero : ");
                    num2 = Console.ReadLine();
                    float num01 = Convert.ToSingle(num1);
                    float num02 = Convert.ToSingle(num2);
                    Console.WriteLine("[+] La respuesta es : {0}", num01 + num02);
                    Console.WriteLine("[*] ═══════════════════════════════════════\n");
                    Console.WriteLine("\n[ La calculadora iniciará de nuevo en 10 segundos ]");
                    Thread.Sleep(10000);
                }

                else if (elija2 == 5)
                {
                    Console.WriteLine("\n[*] ═══════════════════════════════════════");
                    string num1;
                    string num2;
                    Console.WriteLine("[*] Ingresa el primer numero : ");
                    num1 = Console.ReadLine();
                    Console.WriteLine("[*] Ingresa el segundo numero : ");
                    num2 = Console.ReadLine();
                    float num01 = Convert.ToSingle(num1);
                    float num02 = Convert.ToSingle(num2);
                    Console.WriteLine("[+] La respuesta es : {0}", num01 - num02);
                    Console.WriteLine("[*] ═══════════════════════════════════════\n");
                    Console.WriteLine("\n[ La calculadora iniciará de nuevo en 10 segundos ]");
                    Thread.Sleep(10000);
                }

                else if (elija2 == 6)
                {
                    Console.WriteLine("\n[*] ═══════════════════════════════════════");
                    string num1;
                    string num2;
                    Console.WriteLine("[*] Ingresa el primer numero : ");
                    num1 = Console.ReadLine();
                    Console.WriteLine("[*] Ingresa el segundo numero : ");
                    num2 = Console.ReadLine();
                    float num01 = Convert.ToSingle(num1);
                    float num02 = Convert.ToSingle(num2);
                    Console.WriteLine("[+] La respuesta es : {0}", num01 / num02);
                    Console.WriteLine("[*] ═══════════════════════════════════════\n");
                    Console.WriteLine("\n[ La calculadora iniciará de nuevo en 10 segundos ]");
                    Thread.Sleep(10000);
                }

                else if (elija2 == 7)
                {
                    Console.WriteLine("\n[*] ═══════════════════════════════════════");
                    string num1;
                    string num2;
                    Console.WriteLine("[*] Ingresa el primer numero : ");
                    num1 = Console.ReadLine();
                    Console.WriteLine("[*] Ingresa el segundo numero : ");
                    num2 = Console.ReadLine();
                    float num01 = Convert.ToSingle(num1);
                    float num02 = Convert.ToSingle(num2);
                    Console.WriteLine("[+] La respuesta es : {0}", num01 * num02);
                    Console.WriteLine("[*] ═══════════════════════════════════════\n");
                    Console.WriteLine("\n[ La calculadora iniciará de nuevo en 10 segundos ]");
                    Thread.Sleep(10000);
                }

                else if (elija2 == 8)
                {
                    Console.WriteLine("\n[*] ═══════════════════════════════════════");
                    string num1;
                    string num2;
                    Console.WriteLine("[*] Ingresa el primer numero : ");
                    num1 = Console.ReadLine();
                    Console.WriteLine("[*] Ingresa el segundo numero : ");
                    num2 = Console.ReadLine();
                    float num01 = Convert.ToSingle(num1);
                    float num02 = Convert.ToSingle(num2);
                    Console.WriteLine("[+] La respuesta es : {0}", num01 % num02);
                    Console.WriteLine("[*] ═══════════════════════════════════════\n");
                    Console.WriteLine("\n[ La calculadora iniciará de nuevo en 10 segundos ]");
                    Thread.Sleep(10000);
                }
                else if (elija2 == 9)
                {
                    carga();
                    Console.WriteLine("\n[ Adios, vuelva pronto ]");
                    break;

                }
            }
            if (ejec == 2)
            {
                carga();
                Console.WriteLine("\n[ Adios, vuelva pronto ]");
            }
        }

        protected static void inicio()
        {
            Console.WriteLine("\n\n░█████╗░░█████╗░██╗░░░░░░█████╗░██╗░░░██╗");
            Console.WriteLine("██╔══██╗██╔══██╗██║░░░░░██╔══██╗██║░░░██║");
            Console.WriteLine("██║░░╚═╝███████║██║░░░░░██║░░╚═╝██║░░░██║");
            Console.WriteLine("██║░░██╗██╔══██║██║░░░░░██║░░██╗██║░░░██║");
            Console.WriteLine("╚█████╔╝██║░░██║███████╗╚█████╔╝╚██████╔╝");
            Console.WriteLine("░╚════╝░╚═╝░░╚═╝╚══════╝░╚════╝░░╚═════╝░\n");
            Console.WriteLine("[*] ═══════════════════════════════════════");
            Console.WriteLine("[*] Calculadora programada en C#");
            Console.WriteLine("[*] Author   : Balta");
            Console.WriteLine("[*] Github   : https://github.com/B-A-L-T-A");
            Console.WriteLine("[*] WhastApp : +500 61013");
            Console.WriteLine("[*] ═══════════════════════════════════════\n\n");
            Console.WriteLine("[  Menú de Opciones  ]\n");
            Console.WriteLine("[1]. Calcular Circunferencia ");
            Console.WriteLine("[2]. Calcular Radio");
            Console.WriteLine("[3]. Calcular Hipotenusa ");
            Console.WriteLine("[4]. Suma");
            Console.WriteLine("[5]. Resta");
            Console.WriteLine("[6]. División");
            Console.WriteLine("[7]. Multiplicación");
            Console.WriteLine("[8]. Modulo");
            Console.WriteLine("[9]. Salir \n");
        }

        protected static void carga()
        {
            Console.WriteLine("\nCargando: [....................] 0%");
            Thread.Sleep(300);
            Console.WriteLine("Cargando: [##..................] 10%");
            Thread.Sleep(300);
            Console.WriteLine("Cargando: [####................] 20%");
            Thread.Sleep(300);
            Console.WriteLine("Cargando: [######..............] 30%");
            Thread.Sleep(300);
            Console.WriteLine("Cargando: [########............] 40%");
            Thread.Sleep(300);
            Console.WriteLine("Cargando: [##########..........] 50%");
            Thread.Sleep(300);
            Console.WriteLine("Cargando: [############........] 60%");
            Thread.Sleep(300);
            Console.WriteLine("Cargando: [##############......] 70%");
            Thread.Sleep(300);
            Console.WriteLine("Cargando: [################....] 80%");
            Thread.Sleep(300);
            Console.WriteLine("Cargando: [##################..] 90%");
            Thread.Sleep(300);
            Console.WriteLine("Cargando: [####################] 100%");
        }
    }
}
