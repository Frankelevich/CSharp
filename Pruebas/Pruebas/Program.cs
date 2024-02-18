
//Se debe colocar la cantidad de elementos (de 3 para arriba). La cantidad
//de oportunidades para abrir cofres será 4 en caso de elegir 3 cofres.
//Para 4-6 serán n chances y se podrá intentar romper una vez un cofre.
//A partir de 7 los intentos serán siempre 7 con 2 posibilidades de romper
//y a partir de 12 las oportunidades para romper se incrementan en 1.
//Para 20 en adelante, serán 12 chances y 10 oportunidades para romper un cofre.



using Pruebas;

int n = 0;
bool exit = false;

//Pongo todo el texto a utilizar dentro de una clase
Texto t = new Texto();

int intentos = 0, rompe = 0;
int diamante = 0;
int gana = 0;





while (exit == false)
{


    n = Menu.seleccion(1, 3, t.menu1);

    switch (n)
    {
        case 1://Preparando el juego
            int opcion = 0;
            n = Menu.seleccion(3, 25, t.menu2);
            List<Cofre> cofres = new List<Cofre>(25);
            List<Llave> llaves = new List<Llave>(25);

            Mecanicas.setElementos(ref cofres, ref llaves, n);

            Mecanicas.setIntentos(n, intentos, rompe);
            
            //JUEGO---------------------------------------------------------------------------------------------------------------------------------------------JUEGO
            //
            //
            while (intentos>0)
            { 
            opcion = Menu.juego(n, ref opcion);

                if (opcion != 0)
                {
                    //Acá falta escribir (método Mecanicas.seleccionCofre() y String Texto.menu3())
                }
                else break;
            }

            //El desenlace por acá...
            
            if (intentos == 0 && gana != 0) 
            {
                //Esta historia continuará...
            }

            cofres.Clear();
            llaves.Clear();
            break;
        //---------------------------------------------------------------------------------------------------------------------------------------------------FIN JUEGO
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
