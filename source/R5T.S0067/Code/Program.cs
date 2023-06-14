using System;
using System.Threading.Tasks;


namespace R5T.S0067
{
    class Program
    {
        static async Task Main()
        {
            await ProjectFileDemonstrations.Instance.Get_RecursiveProjectReferences_InDependencyOrder();
            //await ProjectFileDemonstrations.Instance.Get_TopLevelProjectReferences();
            //await ProjectFileDemonstrations.Instance.Get_PackageReferences();

            //await ProjectFileGenerationScripts.Instance.Create_ConsoleProjectFile();
            //await ProjectFileGenerationScripts.Instance.Create_WebServerForBlazorClientProjectFile();
            //await ProjectFileGenerationScripts.Instance.Create_BlazorClientProjectFile();

            //ProjectFileScripts.Instance.Test_Is_ProjectFile();
            //await ProjectFileScripts.Instance.Write_RecursiveProjectReferencesToFile();
        }
    }
}