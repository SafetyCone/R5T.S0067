using System;


namespace R5T.S0067
{
    public class ProjectFileGenerationScripts : IProjectFileGenerationScripts
    {
        #region Infrastructure

        public static IProjectFileGenerationScripts Instance { get; } = new ProjectFileGenerationScripts();


        private ProjectFileGenerationScripts()
        {
        }

        #endregion
    }
}
