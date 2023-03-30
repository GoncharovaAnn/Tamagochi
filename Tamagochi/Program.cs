using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Tamagochi
{
    /// <summary>
    /// Класс <c>Program</c> в котором инициализируется запуск игры
    /// </summary> 
    internal class Program
    {
        public delegate string Delegate();
        static void Main(string[] args)
        {
            SoundPlayer player = new SoundPlayer("music.wav");
            player.Load();
            player.PlayLooping();

            STart sTart = new STart();
            sTart.Start();
        }
        /// <summary>
        ///  Метод <c>GameStart</c> является основным для запуска игры
        /// </summary>
        public void GameStart()
        {
            Console.OutputEncoding = Encoding.Unicode;
            
            Random random = new Random();
            List<int> list = new List<int>();

            //Сколько жизней у питомца
            int life = 3;
            //Продолжительность жизни тамагочи в милях секундах (1мин = 60 000 миллисекунд)
            int lifeLenght = 60000;

            int moves = 1;

            //Количество команд
            int count = 25;
            string name = "Tamagotchi";

            Tamagochi kitty = new Tamagochi();
            //Таймер
            Stopwatch lifeCycle = new Stopwatch();

            Stopwatch st = new Stopwatch();
            Stopwatch st0 = new Stopwatch();

            Delegate[] d = new Delegate[]
            {
                kitty.Eat,
                kitty.Play,
                kitty.Sleap,
                kitty.Walk,
                kitty.Heal
            };
            Delegate method = null;

            int temp = random.Next(d.Length);
            list.Add(temp);

            //Генерация желаний питомца
            while (list.Count < count)
            {
                temp = random.Next(d.Length);
                if (temp != list[0])
                {
                    temp = random.Next(d.Length);
                    list.Add(temp);
                }
            }

            lifeCycle.Start();
            while (life > 0 && lifeCycle.ElapsedMilliseconds < lifeLenght)
            {
                int it  = 0;
                Console.Clear();
                kitty.Show();

                while (life > 1 && lifeCycle.ElapsedMilliseconds < lifeLenght)
                {
                    Thread.Sleep(800);
                    Console.Clear();

                    int index = list[it];

                    method = d[index];
                    string message = method();

                    if (message == kitty.Eat()) { kitty.ShowWantEat(); moves++; }
                    else if (message == kitty.Walk()){ kitty.ShowWantWalk(); moves++; }
                    else if (message == kitty.Sleap()){ kitty.ShowWantSleap(); moves++; }
                    else if (message == kitty.Play()){ kitty.ShowWantPlay(); moves++; }
                    else if (message == kitty.Heal()){ kitty.ShowWantHeal(); moves++; }

                    st.Start();
                    var result = MessageBox.Show(message, name, MessageBoxButtons.OKCancel);
                    if (result == DialogResult.OK) 
                    {
                        st.Stop();
                        if (st.ElapsedMilliseconds > 10000)
                        {
                            life--;
                            Console.WriteLine("While you were thinking. The kitten is sick.");
                        }
                        else
                            MessageBox.Show("Thank you!", name, MessageBoxButtons.OK);
                        st.Reset();
                    }
                    else
                    {
                        life--;
                        st.Stop();
                        Console.WriteLine("While you were thinking. The kitten is sick.");
                        MessageBox.Show(":(", name, MessageBoxButtons.OK);
                        st.Reset();
                        Thread.Sleep(800);
                    }

                    it++;

                    if (it >= list.Count) 
                        it = 0; 
                }
                if(life < 3)
                {
                    Console.Clear();
                    kitty.ShowWantHeal();
                    st0.Start();
                    var needHeal = MessageBox.Show(d[4](), name, MessageBoxButtons.OKCancel);
                    if (needHeal == DialogResult.OK)
                    {
                        st0.Stop();
                        if (st0.ElapsedMilliseconds > 5000)
                        {
                            life = 0;
                            Console.Clear();
                            kitty.Death();
                            Console.WriteLine($"{name} died while you were thinking...");
                            break;
                        }

                        MessageBox.Show("Oh thank you!", name, MessageBoxButtons.OK);
                        if (life < 3)
                           life++;
                        st0.Reset();
                    }
                    else
                    {
                        st0.Stop();
                        life = 0;
                        Console.Clear();
                        Console.WriteLine("Kitten died.");
                        kitty.Death();
                        Console.ReadKey();
                    }
                    st0.Reset();
                }
                Text text = new Text();
                text.File(moves);
            }
            lifeCycle.Stop();
            if (lifeCycle.ElapsedMilliseconds >= lifeLenght)
            {
                Console.Clear();
                kitty.ShowWantGoodBye();
                MessageBox.Show("Kitten lived a happy life with you!", name, MessageBoxButtons.OK);
            }
        }
    }
}
