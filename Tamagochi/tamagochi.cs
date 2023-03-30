using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagochi
{
    /// <summary>
    /// Класс <c>Tamagochi</c> в котором находится псевдографика и основные методы-просьбы
    /// </summary>
    class Tamagochi
	{
        public delegate void Request();

        public string Eat() { return "Feed me"; }
        public string Walk() { return "Let's go for a walk"; }
        public string Sleap() { return "I want to sleep"; }
        public string Heal() { return "Cure me"; }
        public string Play() { return "Let's play"; }
        public void Show()
        {
            Console.WriteLine("    /\\_____/\\");
            Console.WriteLine("   /  o   o  \\");
            Console.WriteLine("  ( ==  ^  == )");
            Console.WriteLine("   )         (");
            Console.WriteLine("  (           )");
            Console.WriteLine(" ( (  )   (  ) )");
            Console.WriteLine("(__(__)___(__)__)");
        }
        public void Death()
        {
            Console.WriteLine("           ___");
            Console.WriteLine("          (___)");
            Console.WriteLine("   ____");
            Console.WriteLine(" _\\___ \\  |\\_/|");
            Console.WriteLine("\\     \\ \\/ , , \\ ___");
            Console.WriteLine(" \\__   \\ \\ =\"= //|||\\");
            Console.WriteLine("  |===  \\/____)_)||||");
            Console.WriteLine("  \\______|    | |||||");
            Console.WriteLine("      _/_|  | | =====");
            Console.WriteLine("     (_/  \\_)_)");
            Console.WriteLine("  _________________");
            Console.WriteLine(" (                _)");
            Console.WriteLine("  (__   '          )");
            Console.WriteLine("    (___    _____)");
            Console.WriteLine("        '--'");
            Console.WriteLine("|=================|");
            Console.WriteLine("| The kitty died! |");
            Console.WriteLine("|=================|");
        }
        public void ShowWantEat()
        {
            Console.WriteLine(" |\\__/,|   (`\\");
            Console.WriteLine(" |_ _  |.--.) )");
            Console.WriteLine(" ( T   )     /");

            Console.WriteLine("|==============|");
            Console.WriteLine("|I want to eat!|");
            Console.WriteLine("|==============|");
        }
        public void ShowWantWalk()
        {
            Console.WriteLine("    |\\__/,|   (`\\");
            Console.WriteLine("  _.|o o  |_   ) )");
            Console.WriteLine("-(((---(((--------");
            Console.WriteLine("|====================|");
            Console.WriteLine("|Let's go for a walk!|");
            Console.WriteLine("|====================|");
        }
        public void ShowWantSleap()
        {
            Console.WriteLine("      |\\      _,,,---,,_");
            Console.WriteLine("ZZZzz /,`.-'`'    -.  ;-;;,_");
            Console.WriteLine("     |,4-  ) )-,_. ,\\ (  `'-'");
            Console.WriteLine("    '---''(_/--'  `-'\\_) ");
            Console.WriteLine("|==================|");
            Console.WriteLine("| I want to sleep! |");
            Console.WriteLine("|==================|");
        }
        public void ShowWantPlay()
        {
            Console.WriteLine("    /\\_/\\           ___");
            Console.WriteLine("   = o_o =_______    \\ \\");
            Console.WriteLine("   __^      __(  \\.__) )");
            Console.WriteLine("(@)<_____>__(_____)____/");
            Console.WriteLine("|=================|");
            Console.WriteLine("| I want to play! |");
            Console.WriteLine("|=================|");
        }
        public void ShowWantHeal()
        {
            Console.WriteLine("     _");
            Console.WriteLine("  |\'/-..--.");
            Console.WriteLine(" / _ _   ,  ;");
            Console.WriteLine("`~=`Y'~_<._./");
            Console.WriteLine("<`-....__.'");
            Console.WriteLine("|==========|");
            Console.WriteLine("| Cure me! |");
            Console.WriteLine("|==========|");
        }
        public void ShowWantGoodBye()
        {
            Console.WriteLine(" _._     _,-'\"\"`-._");
            Console.WriteLine("(,-.`._,'(       |\\`-/|");
            Console.WriteLine("    `-.-' \\ )-`( , o o)");
            Console.WriteLine("          `-    \\`_`\"'-");
            Console.WriteLine("|===============================|");
            Console.WriteLine("|   Goodbye! Let's play later!  |");
            Console.WriteLine("|===============================|");
        }
    }
}
