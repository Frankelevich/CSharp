using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Pruebas
{
    internal class Texto
    {
        public static void instrucciones()
        {
            Console.WriteLine("*Esto es un juego de abrir cofres.");
            Thread.Sleep(2200);
            Console.WriteLine("*Se elige la cantidad y se adivina que llave pertenece a cual cofre");
            Thread.Sleep(3000);
            Console.WriteLine("*Si adivinás, puedes pasar al siguiente nivel.");
            Thread.Sleep(2700);
            Console.WriteLine("*Hay una o más chances para romper los cofres dependiendo de la cantidad que se elijan...");
            Thread.Sleep(5000);
            Console.WriteLine("Pulse Enter para seguir");
            Console.ReadLine();
        }

        public static int confirmar(ref int x)
        {
            String menu = "Seguro que desea salir? \n\n1) Si\n2) No";
            x=Mecanicas.menúSelección(0, 3, menu);
            return x;
        }

        public static void salir()
        {
            Console.Clear();
            Thread.Sleep(800);
            Console.Write("B");
            Thread.Sleep(100);
            Console.Write("a");
            Thread.Sleep(100);
            Console.Write("i");
            Thread.Sleep(100);
            Console.Write(".");
            Thread.Sleep(100);
            Console.Write(".");
            Thread.Sleep(100);
            Console.Write(".");
            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine("     .*(#%%%%%%%%%%%%&&&&&&&&&&&&&&&&&&&&&&&&&%%%%%%%%%%%%%%%#(*    . \r\n" +
                "     .,/##%%%%%%%%%%%&&&&&&&&&&&&&&&&&&&&&&&&&&%%%%%%%%%%%%%%#/,.     \r\n" +
                "      ,*(###%%%%%%%%%%%%&&&&&&&&&&&&&&&&&&&&&&&&%%%%%%%%%%%%##(* .    \r\n" +
                "      .*/(##%%%%%%%%%%%%%&&&&&&&&&&&&&&&&&&&&&&&&&%%%%%%%%%%%%#(.     \r\n" +
                "      .,/(###%%%%%%%%%%%%&&&&&&&&&&&&&&&&&&&&&&%%%%%%%%#%%%%%%%#(.    \r\n" +
                "     .**/((##%%%%%%%%%%%%&&&&&&&&&&&&&&&&&&&%#(*,,.,,/(/*,((%%%##*.   \r\n" +
                "     .////(####%%%%%%%%%%%%%%%%%%&&&&%%%%%#(*,,,/##%##%####((##%%(,   \r\n" +
                ".    ,*//****,*. .   .. ..,/#%%%%&%&&%%%(((#/.#%#(#%%#(.*######%%#*. .\r\n" +
                "..   .*/*...,,,**,,,,..  .,***/#%%&&&%%%#%%#(##,**.,#**,(###%%%%%%/. /\r\n" +
                ",..  .*/*,,***... *..,/./%,/%#((#%&&&&%%%&&%%%%%#%%%####%%%%%%%%%%**((\r\n" +
                ".,,. .,/**///*/,,*/(##%%%%%%%%%##%&&&%%%%%%%%%%%%%%%%%%%%%%%%%%%%%(/%%\r\n" +
                ",.*.  ,//(###%%%%##%%%%%%%%%%%%##%%&&&%%%%%%%&&&%%%%%&&&&%%%%%%%%#(##%\r\n" +
                "*.,,.,.//(##%%%%%%%%%%%%%%%%%%####%&&&%%%%%%&&&&&&&&&&&&%%%%%%%%##/%%%\r\n" +
                "**..*,.,*/(#%%%%%%%%%%%%%%%%%%###%%%&&&%%%%%%&&&&&&&&&&&%%%%%%%####%%%\r\n" +
                ".,,.,**.,/(##%%%%%%%%%%%%%%%%####%%%&&&%%%%%%%%&&&&&&&%%%%%%%%%##(*#**\r\n" +
                "  .,.**,.*/###%%%%%%%%%%%%%%%#%%%%%&&&&&%%%%%%&&&&&&&&%%%%%%%%%##/ .*(\r\n" +
                "     . ...*/(#%%%%%%%%%%%%%%#*///*/#%%%#,.*,#%&&&&&&&&%%%%%%%%%%#(,/((\r\n" +
                "        ..**/(#%%%%%%%%%%%%%%#/,,,,*///((#%&%&%&%%%%%%%%%%%%%%%%%#***,\r\n" +
                "          *///((#%%%%%%%%%%%%%%%%%%####%%%%%%%&%&&%%%%%%%%%%%%%%%#.   \r\n" +
                "          ,/(((((###%%%%%%%%%%%%%%%%&&&%%%%%%#%(*#%%%%%%%%%%%%%%%(   .\r\n" +
                "           /(#(#(((#%%%%%#(,,.,*,*****/(###%%%%%%%%%%%%%%%%%%%%%#,   .\r\n" +
                "..         ./((###((#%%%%%%%%%%%%%%&%%%%%%%%%%%%%%%%%%%%%%%%%%%#(...,*\r\n" +
                "//,..        */(###((##%%%%%%%%%%######%%%%%%%%%%%%%%%%%%%%%%#(/(%/((#\r\n" +
                "%%%%#/.       .//####(##%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%(/*/(*%%#%%\r\n" +
                "%%%%%%##/,       .*/((###%%%%%%%%%%&&&&&&&&&%%%%%%%%%%%##/,**/(/%%%%%%\r\n" +
                "%%%%%%%#(*          .*/((##%%%%%%%%&&&%&&&&&%%%%%%%%%#(*,,*///(%%%%%%%\r\n" +
                "%%%%%%%#(,        .   ..*//(##%%%%%%%%%%%%%%%%%%%%#(*,,**//*%%%%%%%%%%\r\n" +
                "%%%%%%%%,         ...      ,*/(##%%%%%%%%%%%%%#(/,...,,*/#%%%&%%%%%%%%");
            Thread.Sleep(500);
            Console.Clear();

        }
    }
}
