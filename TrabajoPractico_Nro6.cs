internal class Program
{
    private static void Main(string[] args)
    {
        //Variables
        int menuOption = 0; 
        
        // Set Color
        Console.BackgroundColor = ConsoleColor.Black; //Color del fondo de la Consola.
        

        MenuPrincipal();

#region Menus
        void MenuPrincipal(){
            Console.ForegroundColor = ConsoleColor.DarkBlue; // Color de la fuente de la Consola.

            Console.Clear();

            Console.WriteLine("\nPara Seleccionar una actividad pulse un número del -1- al -6-, o -0- para volver al menú principal.\n");

            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkYellow;

            Console.Write("Número de actividad: ");

            menuOption = Int32.Parse(Console.ReadLine());
            Console.ResetColor();

            Menu(menuOption);
        }
        
        
        void Menu(int option)
        {
            Console.Clear();
            switch (option)
            {
                case 0:
                        MenuPrincipal();
                    break;
                case 1:
                        InstruccionesCafe();
                    break;
                case 2:
                        NombrePersonalizado();
                    break;
                case 3:
                        TipoDeDatos();
                    break;
                case 4:
                        SumaDeNumeros();
                    break;
                case 5:
                        MayorMenorIgual();
                    break;
                case 6:
                    Calculadora();
                    break;                    
                default:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Error, Intente con un número del -0- al -6-");

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Pulsa cualquier tecla para continuar...");
                    Console.ReadKey();
                    Console.Clear();
                    
                    MenuPrincipal();
                break;
            }
        }
#endregion

#region Actividades
        void InstruccionesCafe()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Instrucciones para hacer una taza de café.");
            Console.ResetColor();
            Console.WriteLine("Pulse cualquier tecla para continuar...");
            Console.ReadKey();

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Paso 1: Poner agua a calentar");
            Console.ResetColor();
            Console.WriteLine("Pulse cualquier tecla para continuar...");
            Console.ReadKey();
            
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Paso 2: Poner café en una taza");
            Console.ResetColor();
            Console.WriteLine("Pulse cualquier tecla para continuar...");
            Console.ReadKey();

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Paso 3: Una vez el agua hierva, vertir lentamente dentro de la taza con café previamente puesto e ir mezclando.");
            Console.ResetColor();
            Console.WriteLine("Pulse cualquier tecla para continuar...");
            Console.ReadKey();

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Paso 4: Agregar azúcar a gusto y mezclar.");
            Console.ResetColor();
            Console.WriteLine("Pulse cualquier tecla para continuar...");
            Console.ReadKey();

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Paso 5: Disfrutar el café.");
            Console.ResetColor();
            Console.WriteLine("Pulse cualquier tecla para continuar...");
            Console.ReadKey();
            
            MenuPrincipal();
        }

        void NombrePersonalizado(){
            string fullName = "";

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("\nPor favor ingrese su nombre completo. \n");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Nombre completo: ");
            fullName = Console.ReadLine();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\nHola, " + fullName + "! Tienes un bonito nombre.\n");
            Console.ResetColor();

            Console.Write("Oye ");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write(fullName);
            Console.ResetColor();
            Console.WriteLine("! Pulsa cualquier tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
            MenuPrincipal();
        }

        void TipoDeDatos(){
            int edad;
            decimal sueldo;
            string nombre, r;
            bool esMayor = false;           

            //Nombre
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Por favor, Ingrese su nombre: ");
            nombre = Console.ReadLine();
            Console.ResetColor();
            Console.WriteLine("Pulsa cualquier tecla para continuar...");
            Console.ReadKey();
            Console.Clear();

            //Edad
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Por favor, Ingrese su edad: ");
            edad = Int32.Parse(Console.ReadLine());
            Console.ResetColor();
            Console.WriteLine("Pulsa cualquier tecla para continuar...");
            Console.ReadKey();
            Console.Clear();

            //Es Mayor de edad? 
            Console.ForegroundColor = ConsoleColor.DarkYellow;

            esMayor = edad >= 18 ? esMayor = true : esMayor = false;

            r = esMayor == true ? r = "Usted es mayor de edad." : r = "Usted es menor de edad.";

            Console.WriteLine(r);
            Console.ResetColor();
            Console.WriteLine("Pulsa cualquier tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
            

            //Sueldo
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Por favor, Ingrese su Sueldo: ");
            sueldo = decimal.Parse(Console.ReadLine());
            Console.ResetColor();
            Console.WriteLine("Pulsa cualquier tecla para continuar...");
            Console.ReadKey();
            Console.Clear();

            //SHOW IN CONSOLE
            //Nombre
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("\nNombre: ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(nombre);

            //Edad
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("\nEdad: ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(edad);
            
            //Es Mayor
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("\nMayor de edad?: ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(/*esMayor + ", " + */r); //bool esMayor
            
            //Sueldo
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("\nSueldo: ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(sueldo);

            Console.ResetColor();
            Console.WriteLine("Pulsa cualquier tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
            MenuPrincipal();
        }
        
        void SumaDeNumeros(){
            int resultado, nro1, nro2;

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Por favor, Ingrese número a sumar: ");
            Console.ForegroundColor = ConsoleColor.White;
            nro1 = Int32.Parse(Console.ReadLine());
            
            Console.ResetColor();
            Console.WriteLine("Pulsa cualquier tecla para continuar...");
            Console.ReadKey();
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Por favor, Ingrese otro número: ");
            Console.ForegroundColor = ConsoleColor.White;
            nro2 = Int32.Parse(Console.ReadLine());

            Console.ResetColor();
            Console.WriteLine("Pulsa cualquier tecla para continuar...");
            Console.ReadKey();
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            resultado = nro1 + nro2;

            Console.Write("La suma entre los números "+ nro1 + " y " + nro2 + " es de: ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(resultado+"\n");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Pulsa cualquier tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
            MenuPrincipal();
        }

        void MayorMenorIgual(){
            float nro1, nro2;

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Por favor, Ingrese un número: ");
            Console.ForegroundColor = ConsoleColor.White;
            nro1 = Int32.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Pulsa cualquier tecla para continuar...");
            Console.ReadKey();
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Por favor, Ingrese otro número: ");
            Console.ForegroundColor = ConsoleColor.White;
            nro2 = Int32.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Pulsa cualquier tecla para continuar...");
            Console.ReadKey();
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.DarkYellow;
             
            if(nro1 > nro2){
            Console.WriteLine("El número " + nro1 + " es mayor que el número " + nro2);
            }else if (nro1 < nro2){
            Console.WriteLine("El número " + nro1 + " es menor que el número " + nro2);
            }else {
            Console.WriteLine("El número " + nro1 + " es igual que el número " + nro2);
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nPulsa cualquier tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
            MenuPrincipal();
        }

        void Calculadora(){
            int opcion;
            float numb1, numb2, result;
            string signo;

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Por favor, Ingrese un número: ");
            numb1 = float.Parse(Console.ReadLine());
           Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Pulsa cualquier tecla para continuar...");
            Console.ReadKey();
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Por favor, Ingrese otro número: ");
            numb2 = float.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Pulsa cualquier tecla para continuar...");
            Console.ReadKey();
            Console.Clear();

            
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Ingrese un número según la operación que desea realizar.");
            Console.WriteLine("Opción 1: Suma.\nOpción 2: Resta.\nOpción 3: Multiplicación.\nOpcion 4: División.");
            opcion = Int32.Parse(Console.ReadLine());


            switch (opcion){
                case 1:
                    result = numb1 + numb2;
                    signo = " + ";
                break;
                case 2:
                    result = numb1 - numb2;
                    signo = " - ";
                break;
                case 3:
                    result = numb1 * numb2;
                    signo = " * ";
                break;
                case 4:
                    result = numb1 / numb2;
                    signo = " / ";
                break;
                default:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Error, Intente Nuevamente");
                    Console.ForegroundColor = ConsoleColor.White;   
                    Console.WriteLine("Pulsa cualquier tecla para continuar...");
                    Console.ReadKey();
                    Console.Clear();

                    Calculadora();
                break;
            }

             Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Resultado: " + numb1 + signo + numb2 + " = " + result);

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Pulsa cualquier tecla para continuar...");
            Console.ReadKey();
            Console.Clear();

            MenuPrincipal();
}

        #endregion


    }
}