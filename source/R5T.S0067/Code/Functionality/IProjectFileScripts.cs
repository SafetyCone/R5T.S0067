using System;
using System.Threading.Tasks;

using R5T.T0132;
using R5T.T0172.Extensions;
using R5T.T0181.Extensions;


namespace R5T.S0067
{
    [FunctionalityMarker]
    public partial interface IProjectFileScripts : IFunctionalityMarker
    {
        /// <summary>
        /// Given a project file instance, identify and remedy variances and write the result to a separate output file.
        /// Allows comparison of (possible) modified and unmodified project files in Notepad++.
        /// </summary>
        public async Task StandardizeVariances()
        {
            /// Inputs.
            var inputProjectFilePath =
                @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.S0067\source\R5T.S0067\R5T.S0067.csproj"
                .ToProjectFilePath()
                ;
            var outputProjectFilePath =
                Instances.Paths.Sample_ProjectFilePath
                ;


            /// Run.
            await Instances.ProjectFileOperations.IdentifyAndRemedyVariances(
                inputProjectFilePath,
                outputProjectFilePath);

            Instances.NotepadPlusPlusOperator.Open(
                inputProjectFilePath.Value,
                outputProjectFilePath.Value);
        }

        public async Task Write_ProjectElement_ToFile()
        {
            /// Inputs.
            var outputProjectFilePath =
                Instances.Paths.Sample_ProjectFilePath
                ;
            var projectFileXmlText =
                //Instances.ProjectFileXmlTexts.R5T_Z0052_Z000_FromString
                await Instances.ProjectFileXmlTexts.R5T_Z0052_Z001_FromFile
                ;


            /// Run.
            var projectElement = Instances.ProjectElementOperator.From(projectFileXmlText);

            await Instances.ProjectElementOperator.To_File(
                outputProjectFilePath,
                projectElement);

            Instances.NotepadPlusPlusOperator.Open(outputProjectFilePath.Value);
        }

        public async Task Write_ProjectFileXmlText_ToFile()
        {
            /// Inputs.
            var outputProjectFilePath =
                Instances.Paths.Sample_ProjectFilePath
                ;
            var projectFileXmlText =
                //Instances.ProjectFileXmlTexts.R5T_Z0052_Z000_FromString
                await Instances.ProjectFileXmlTexts.R5T_Z0052_Z001_FromFile
                ;


            /// Run.
            await Instances.ProjectFileXmlOperator.Write_ToFile(
                outputProjectFilePath,
                projectFileXmlText);

            Instances.NotepadPlusPlusOperator.Open(outputProjectFilePath.Value);
        }

        /// <summary>
        /// It's a frequent question when developing in Visual Studio (VS), whether a particular project reference is in a private GitHub repository.
        /// In VS 2022, you can double-click a project in the solution explore and VS will show you the project file's contents.
        /// But there is no way in VS to easily see the GitHub repository information for the repository containing a project file.
        /// But putting a project property in the project file indicating the file is in a private GitHub repository, this information can be seen at a glance.
        /// </summary>
        public async Task Set_PrivateGitHubRepositoryProperty()
        {
            /// Inputs.
            var exampleInputProjectFilePath =
                Instances.Paths.Example_ProjectFilePath_InPrivateRepository
                //@""
                ;
            // Allow for a different output file path to allow for multiple runs.
            var sampleOutputProjectFilePath =
                //@""
                Instances.Paths.Sample_ProjectFilePath
                ;


            /// Run.
            await Instances.ProjectFileOperations.In_Modify_ProjectElementContext(
                exampleInputProjectFilePath,
                sampleOutputProjectFilePath,
                projectElement =>
                {
                    return Instances.ProjectElementOperations.Set_PrivateGitHubRepositoryProperty(
                        projectElement,
                        exampleInputProjectFilePath);
                });

            Instances.NotepadPlusPlusOperator.Open(sampleOutputProjectFilePath.Value);
        }

        public async Task Write_RecursiveProjectReferencesToFile()
        {
            /// Inputs.
            var projectFilePath =
                @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.S0060\source\R5T.S0060.S002\R5T.S0060.S002.csproj".ToProjectFilePath()
                ;
            var outputTextFilePath =
                Instances.Paths.OutputTextFilePath
                ;


            /// Run.
            await Instances.ProjectFileOperations.Write_RecursiveProjectReferencesTo(
                projectFilePath,
                outputTextFilePath.ToTextFilePath());

            Instances.NotepadPlusPlusOperator.Open(outputTextFilePath);
        }

        /// <summary>
        /// Test if a file is a Visual Studio project file by examining its contents.
        /// </summary>
        public void Test_Is_ProjectFile()
        {
            /// Inputs.
            var projectFilePath =
                @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.S0067\source\R5T.S0067\R5T.S0067.csproj"
                .ToProjectFilePath()
                ;


            /// Run.
            var isProjectFile = Instances.ProjectFileOperations.Is_ProjectFile(
                projectFilePath);

            Console.WriteLine($"{isProjectFile}: is project file based on file contents.\n\t{projectFilePath}");
        }
    }
}
