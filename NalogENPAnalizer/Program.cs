using Microsoft.EntityFrameworkCore;

namespace NalogENPAnalizer
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
            MainDb = new MainDbContext();
            MainDb.Kbk.Load();
            MainDb.Kpp.Load();
            MainDb.DocOsn.Load();
            MainDb.Oktmo.Load();
            MainDb.Pokazatels.Load();
            Application.Run(new Form1());
        }

        public static MainDbContext MainDb { get; set; }
    }
}