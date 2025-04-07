using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;

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
            PreloadDotnetDependenciesFromSubdirectoryManually();
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

        static void PreloadDotnetDependenciesFromSubdirectoryManually()
        {
            // https://www.lostindetails.com/articles/Native-Bindings-in-CSharp
            // https://www.meziantou.net/load-native-libraries-from-a-dynamic-location.htm
            // None of the above worked but approach is inspired by it.
            // First, ensure sub-directory with native libraries is 
            // added to dll directories
            var dllDirectory = Path.Combine(AppContext.BaseDirectory,
                Environment.Is64BitProcess ? "win-x64" : "win-x86");
            var r = AddDllDirectory(dllDirectory);
            Trace.WriteLine($"AddDllDirectory {dllDirectory} {r}");

            // Then, try manually loading the .NET 6 WPF 
            // native library dependencies
            TryManuallyLoad("D3DCompiler_47_cor3");
            TryManuallyLoad("e_sqlite3");
            TryManuallyLoad("PenImc_cor3");
            TryManuallyLoad("PresentationNative_cor3");
            TryManuallyLoad("vcruntime140_cor3");
            TryManuallyLoad("wpfgfx_cor3");
        }

        [DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        static extern int AddDllDirectory(string NewDirectory);

        static void TryManuallyLoad(string libraryName)
        {
            // NOTE: For the native libraries we load here, 
            //       we do not care about closing the library 
            //       handle since they live as long as the process.
            var loaded = NativeLibrary.TryLoad(libraryName,
                Assembly.GetExecutingAssembly(),
                DllImportSearchPath.SafeDirectories |
                DllImportSearchPath.UserDirectories,
                out var handle);
            if (!loaded)
            {
                Trace.WriteLine($"Failed loading {libraryName}");
            }
            else
            {
                Trace.WriteLine($"Loaded {libraryName}");
            }
        }

        public static MainDbContext MainDb { get; set; }
    }
}