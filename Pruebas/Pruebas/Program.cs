
//Se debe colocar la cantidad de elementos (de 3 para arriba). La cantidad
//de oportunidades para abrir cofres será 4 en caso de elegir 3 cofres.
//Para 4-6 serán n chances y se podrá intentar romper una vez un cofre.
//A partir de 7 los intentos serán siempre 7 con 2 posibilidades de romper
//y a partir de 12 las oportunidades para romper se incrementan en 1.
//Para 20 en adelante, serán 12 chances y 10 oportunidades para romper un cofre.



using Pruebas;

int n = 0;
bool exit = false;
int diamante = 0;
bool gana = false;

//Pongo todo el texto a utilizar dentro de una clase
Texto t = new Texto(diamante);



while (exit == false)
{


    n = Menu.seleccion(1, 3, t.titulo+t.menu1);

    switch (n)
    {
        case 1://Preparando el juego--------------------------------------------------------------------------
            int intentos = 0, rompe = 0;
            int opcion = 0;
            n = Menu.seleccion(3, 25, t.titulo+t.menu2);
                        
            List<Cofre> listaCofres = new List<Cofre>(25);
            List<Llave> listaLlaves = new List<Llave>(25);

            Mecanicas.setElementos(ref listaCofres, ref listaLlaves, n);

            Mecanicas.setIntentos(n,ref intentos,ref rompe);

            //JUEGO---------------------------------------------------------------------------------------------------------------------------------------------JUEGO
            //-------------------------------------------------------------------------------------------------------------------------------------------------------
            //-------------------------------------------------------------------------------------------------------------------------------------------------------
            while (intentos>0)
            {
                int opcion1 = Menu.seleccion(0, n, t.titulo+$"-Intentos: {intentos}\n\n"+"Elija una llave:")-1;
                int opcion2 = Menu.seleccion(0, n, t.titulo+ $"-Intentos: {intentos}\n\n" + "Elija un cofre:")-1;

                if (opcion1 != -1 || opcion2 != -1)
                {

                    //si coinciden la llave y la cerradura se deberá abrir el cofre y mostrar su contenido
                    Console.WriteLine(Texto.mostrarContenido(listaCofres[opcion2], listaLlaves[opcion1]));
                    Console.ReadLine();
                    if (Texto.mostrarContenido(listaCofres[opcion2], listaLlaves[opcion1]).Contains("Diamante"))
                    {
                        diamante += 1;
                        gana = true;
                        break;
                    }
                    else intentos -= 1;

                }
                else break;
             
            }

            //El desenlace por acá...

            if (intentos == 0 && gana != false)
            {
                Console.WriteLine("\n\n\n\n\n\t\t\tHAS GANADO!!!");
                Console.ReadLine();
            }
            else Console.WriteLine("Mejor suerte la próxima :(");

            listaCofres.Clear();
            listaLlaves.Clear();
            gana = false;
            break;
        //---------------------------------------------------------------------------------------------------------------------------------------------------FIN JUEGO
        //------------------------------------------------------------------------------------------------------------------------------------------------------------
        //------------------------------------------------------------------------------------------------------------------------------------------------------------
        case 2:
            Console.Clear();
            Console.WriteLine(t.titulo);
            Texto.instrucciones();
            break;
        case 3:
            int u = Menu.confirmar(n);
            if (u == 1)
            {
                exit = true;
                Texto.salir();
            }
            break;

    }
}
