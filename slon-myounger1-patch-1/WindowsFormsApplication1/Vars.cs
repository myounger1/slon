using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    /// <summary>
    /// Важные переменные общие для всех форм
    /// </summary>
    public class Vars
    {
        public static String avaway;

        //public static String LOGIN = "Укажите имя";
        public static String LOGIN;
        public static String PASSWORD = "Укажите пароль";

        public static int NOMER_TOVARA = 0;
        /// <summary>
        /// Задается в TorgPlatForm возле 120 строки
        /// </summary>
        public static int COORDINATA_TOVARA_Y;
        /// <summary>
        /// Задается в TorgPlatForm возле 120 строки
        /// </summary>
        public static int COORDINATA_TOVARA_X;

        public const int VYSOTA_TOVARA = 250;
    }
}
