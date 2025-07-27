namespace NotatnikDesktop
{
    internal static class Program
    {
        public static Dictionary<string, string> LoginHaslo = new Dictionary<string, string>();
        public static Dictionary<string, List<string>> Notatki = new Dictionary<string, List<string>>();

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            bazaLogin.WczytanieLogow();
            bazaNotatek.WczytajNotatki();
            ApplicationConfiguration.Initialize();
            Application.Run(new StronaStartowa());
            bazaLogin.Zapislogow();
            bazaNotatek.ZapiszNotatki();
        }
    }
}