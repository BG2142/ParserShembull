using System.Reflection;

namespace Parser
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            // MVC pattern
            // ParserView is split into two partial Classes and files because of VS Windows form designer.

            Model model = new Model();
            Controller controller = new Controller(model);
          
            Form view = new MainParserForm(controller);
            Application.Run(view);
        }
    }
}