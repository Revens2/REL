namespace REL
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            Connexion mainForm = new Connexion();
            mainForm.FormClosed += (s, e) => Environment.Exit(0); // Ferme proprement quand la fenêtre se ferme

            Application.Run(mainForm);
        }
    }
}