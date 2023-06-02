using System;

using R5T.T0132;
using R5T.T0172.Extensions;


namespace R5T.S0067
{
    [FunctionalityMarker]
    public partial interface IProjectFileScripts : IFunctionalityMarker
    {
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
