using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Tamagochi
{
    /// <summary>
    /// Класс <c>Text</c> для создания файла .txt
    /// </summary> 
    internal class Text
    {
        /// <summary>
        ///  Метод <c>File</c> создает и добавляет записи в текстовый файл
        /// </summary>
        /// <param name="moves">
        /// Счетчик для количества ходов
        /// <see cref="int"/> указывает тип значения
        public void File(int moves)
        {
            //запись в файл число, сделанных ходов
            string path = @"C:\Users\nysic\Downloads\C-Sharp_tamagotchi-main\C-Sharp_tamagotchi-main\Tamagochi\Text.txt";
            using (FileStream file = new FileStream(path, FileMode.Append))
                {
                    using (StreamWriter stream = new StreamWriter(file))
                    {
                        stream.WriteLine(moves);
                    }
                }
        }
    }
}
