using System;
using System.Threading.Tasks;

using R5T.F0000;
using R5T.T0132;
using R5T.T0172;
using R5T.T0187;
using R5T.T0198;


namespace R5T.S0067
{
    [FunctionalityMarker]
    public partial interface IProjectFileGenerationScripts : IFunctionalityMarker
    {
        public async Task Create_BlazorClientProjectFile()
        {
            /// Inputs.
            var projectFilePath = Instances.Paths.Sample_ProjectFilePath;
            var projectDescription = Instances.Values.Sample_ProjectDescription;
            var repositoryUrl = new IsSet<IRepositoryUrl>();


            /// Run.
            Instances.FileSystemOperator.DeleteFile_OkIfNotExists(
                projectFilePath.Value);

            await Instances.ProjectFileGenerationOperations.Create_BlazorClient(
                projectFilePath,
                projectDescription,
                repositoryUrl);

            Instances.NotepadPlusPlusOperator.Open(
                projectFilePath.Value);
        }

        public async Task Create_WebServerForBlazorClientProjectFile()
        {
            /// Inputs.
            var projectFilePath = Instances.Paths.Sample_ProjectFilePath;
            var projectDescription = Instances.Values.Sample_ProjectDescription;
            var repositoryUrl = new IsSet<IRepositoryUrl>();
            var clientProjectFilePath = Instances.Paths.Example_ProjectFilePath;


            /// Run.
            Instances.FileSystemOperator.DeleteFile_OkIfNotExists(
                projectFilePath.Value);

            await Instances.ProjectFileGenerationOperations.Create_WebServerForBlazorClient(
                projectFilePath,
                projectDescription,
                repositoryUrl,
                clientProjectFilePath);

            Instances.NotepadPlusPlusOperator.Open(
                projectFilePath.Value);
        }

        public async Task Create_ConsoleProjectFile()
        {
            /// Inputs.
            var projectFilePath = Instances.Paths.Sample_ProjectFilePath;
            var projectDescription = Instances.Values.Sample_ProjectDescription;
            var repositoryUrl = new IsSet<IRepositoryUrl>();


            /// Run.
            Instances.FileSystemOperator.DeleteFile_OkIfNotExists(
                projectFilePath.Value);

            await Instances.ProjectFileGenerationOperations.Create_ConsoleProjectFile(
                projectFilePath,
                projectDescription,
                repositoryUrl);

            Instances.NotepadPlusPlusOperator.Open(
                projectFilePath.Value);
        }
    }
}
