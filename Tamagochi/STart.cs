using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Tamagochi
{
    /// <summary>
    /// Класс <c>STart</c> запускает начальный экран
    /// </summary>
    class STart
    {
        public void Start()
        {
            Title = "Tamagochi - The Game!";
            RunMainMenu();
        }
        /// <summary>
        ///  Метод <c>RunMainMenu</c> запускает главное меню
        /// </summary>
        private void RunMainMenu()
        {
            string prompt = @"
 _____                                       _     _  
/__   \__ _ _ __ ___   __ _  __ _  ___   ___| |__ (_) 
  / /\/ _` | '_ ` _ \ / _` |/ _` |/ _ \ / __| '_ \| | 
 / / | (_| | | | | | | (_| | (_| | (_) | (__| | | | | 
 \/   \__,_|_| |_| |_|\__,_|\__, |\___/ \___|_| |_|_| 
                            |___/                     
Welcome to the Tamagochi Simulator. What would you like to do?
(Use the arrow keys to cycle thought options and press enter to select an option.)";

            string[] options = { "Play", "About", "Exit" };
            Menu mainMenu = new Menu(prompt, options) ;
            int selectedIndex = mainMenu.Run();

            switch (selectedIndex)
            {
                case 0:
                    RunFirstChoise();
                    break;
                case 1:
                    DisplayAboutInfo();
                    break;
                case 2:
                    ExitGame();
                    break;
            }
        }
        private void ExitGame()
        {
            WriteLine("\nPress any key to exit...");
            ReadKey(true);
            Environment.Exit(0);
        }
        private void DisplayAboutInfo() 
        {
            Clear();
            WriteLine("This game demo created by Goncharova Anna.");
            WriteLine("it uses assets from https://patorjk.com/software/taag; https://freesound.org.");
            WriteLine("--------------------------------------------------------------------------------");
            WriteLine("«Тамагочи». Жизненный цикл персонажа — 1-2 минуты. Персонаж случайным образом выдаёт просьбы (но подряд одна и та же просьба не выдаётся)." +
                "\nПросьбы могут быть следующие: Покормить, Погулять, Уложить спать, Полечить, Поиграть. Если просьбы не удовлетворяются его полечить. В случае отказа — «умирает». " +
                "\nПерсонаж отображается в консольном окне при помощи псевдографики. Диалог с персонажем осуществляется посредством вызова метода Show() класса MessageBox из пространства имен System.Windows.Forms. ");
            WriteLine("--------------------------------------------------------------------------------");
            WriteLine("Press any key to return to the menu.");
            ReadKey(true);
            RunMainMenu();
        }
        /// <summary>
        /// Класс <c>RunFirstChoise</c> запускает игру при выборе ее в меню
        /// </summary>
        private void RunFirstChoise()
        {
            Program program = new Program();
            program.GameStart();
            ExitGame();
        }
    }
}
