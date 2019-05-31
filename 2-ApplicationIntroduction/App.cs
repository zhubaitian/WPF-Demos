using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace StartApplicationByCode
{
    class App
    {
        [STAThread]

        static void Main()

        {

            // 定义Application对象作为整个应用程序入口  

            Application app = new Application();

            // 方法一：调用Run方法 ,这种方式跟winform的调用一样

            MainWindow win = new MainWindow();

            app.Run(win);
        }
    }
}
