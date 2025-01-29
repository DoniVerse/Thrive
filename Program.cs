namespace thrive
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

            Application.Run(new LoginForm());
            //Application.Run(new MoodForm());
            // Application.Run(new RegForm());

            //Application.Run(new Mymp3player());
            //Application.Run(new MediaPlayer());

            //Application.Run(new MoodForm());
            //Application.Run(new RegForm());

            //Application.Run(new DashFr());
            //Application.Run(new practice());

        }
    }
}