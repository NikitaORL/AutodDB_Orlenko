using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace AutodDB_Orlenko
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // Получаем сохранённый язык из настроек
            string lang = Properties.Settings.Default.UserLanguage;
            if (string.IsNullOrWhiteSpace(lang))
                lang = "et-EE"; // по умолчанию эстонский

            Thread.CurrentThread.CurrentUICulture = new CultureInfo(lang);
            Thread.CurrentThread.CurrentCulture = new CultureInfo(lang);

            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}
