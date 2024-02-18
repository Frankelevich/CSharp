
//Se debe colocar la cantidad de elementos (de 3 para arriba). La cantidad
//de oportunidades para abrir cofres será 4 en caso de elegir 3 cofres.
//Para 4-6 serán n chances y se podrá intentar romper una vez un cofre.
//A partir de 7 los intentos serán siempre 7 con 2 posibilidades de romper
//y a partir de 12 las oportunidades para romper se incrementan en 1.
//Para 20 en adelante, serán 12 chances y 10 oportunidades para romper un cofre.



using Pruebas;

String input = "";
int n = 0;
bool exit = false;
int intentos=0, rompe=0;
int monedas = 0;
Texto t = new Texto();

while (exit == false)
{


    n = Menu.menuSeleccion(1, 3, t.menu1);

    switch (n)
    {
        case 1:


            //JUEGO---------------------------------------------------------------------------------------------------------------------------------------------JUEGO
            //
            //
            n = Menu.menuSeleccion(3, 25, t.menu2);

            List<Cofre> cofres= new List<Cofre>(25);
            List<Llave> llaves= new List<Llave>(25);

            Mecanicas.setElementos(ref cofres,ref llaves, n);

            Mecanicas.setIntentos(n,intentos,rompe);



            cofres.Clear();
            llaves.Clear();
            break;
        //---------------------------------------------------------------------------------------------------------------------------------------------------FIN JUEGO
        case 2:
            Console.Clear();
            Console.WriteLine(Texto.titulo);
            Texto.instrucciones();
            break;
        case 3:
            int u = Texto.confirmar(ref n);
            if (u == 1)
            {
                exit = true;
                Texto.salir();
            }
            break;

    }
}
