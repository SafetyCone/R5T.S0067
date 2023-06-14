using System;
using System.Linq;
using System.Threading.Tasks;

using R5T.T0141;
using R5T.T0172.Extensions;
using R5T.T0179.Extensions;


namespace R5T.S0067
{
    [DemonstrationsMarker]
    public partial interface IProjectFileDemonstrations : IDemonstrationsMarker
    {
        /// <summary>
        /// Demonstrates how to get the package references of a file.
        /// </summary>
        /// <returns></returns>
        public async Task Get_PackageReferences()
        {
            /// Inputs.
            var projectFilePath =
                Instances.Paths.With_PackageReference.ToProjectFilePath()
                ;
            var outputTextFilePath =
                Instances.Paths.OutputTextFilePath
                ;


            /// Run.
            var packageReferences = await Instances.ProjectFileOperations.Get_PackageReferences(projectFilePath);

            var lines = packageReferences
                .Select(packageReference => $"{packageReference.Identity} - {packageReference.Version}")
                ;

            await Instances.FileOperator.WriteLines(
                outputTextFilePath,
                lines);

            Instances.NotepadPlusPlusOperator.Open(outputTextFilePath);
        }

        public async Task Get_TopLevelProjectReferences()
        {
            /// Inputs.
            var projectFilePath =
                // Has only one reference: R5T.F0000
                @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.S0060\source\R5T.S0060.S002\R5T.S0060.S002.csproj".ToProjectFilePath()
                ;
            var outputTextFilePath =
                Instances.Paths.OutputTextFilePath
                ;


            /// Run.
            // First get all recursive project file paths.
            var recursiveProjectFilePaths = await Instances.ProjectFileOperations.Get_RecursiveProjectReferences(
                projectFilePath);

            // Then get the top-level project references.
            var topLevelProjectReferences = await Instances.ProjectFileOperations.Get_TopLevelProjectReferences(
                recursiveProjectFilePaths);

            await Instances.FileOperator.WriteLines(
                outputTextFilePath,
                topLevelProjectReferences.Get_Values().OrderAlphabetically());

            // Should contain only one reference: R5T.F0000
            Instances.NotepadPlusPlusOperator.Open(outputTextFilePath);
        }

        public async Task Get_RecursiveProjectReferences_InDependencyOrder()
        {
            /// Inputs.
            var projectFilePath =
                // Has only one reference: R5T.F0000
                @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.S0060\source\R5T.S0060.S002\R5T.S0060.S002.csproj".ToProjectFilePath()
                ;
            var outputTextFilePath =
                Instances.Paths.OutputTextFilePath
                ;


            /// Run.
            // First get all recursive project file paths.
            var recursiveProjectFilePaths = await Instances.ProjectFileOperations.Get_RecursiveProjectReferences_InDependencyOrder(
                projectFilePath);

            await Instances.FileOperator.WriteLines(
                outputTextFilePath,
                // Do not order alphabetically, keep dependency order.
                recursiveProjectFilePaths.Get_Values());

            // Should contain only one reference: R5T.F0000
            Instances.NotepadPlusPlusOperator.Open(outputTextFilePath);
        }
    }
}
