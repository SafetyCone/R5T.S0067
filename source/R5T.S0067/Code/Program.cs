using System;
using System.Threading.Tasks;


namespace R5T.S0067
{
    class Program
    {
        static async Task Main()
        {
            //await ProjectFileGenerationScripts.Instance.Create_ConsoleProjectFile();
            await ProjectFileGenerationScripts.Instance.Create_WebServerForBlazorClientProjectFile();

            //ProjectFileScripts.Instance.Test_Is_ProjectFile();
        }
    }
}