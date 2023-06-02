using System;


namespace R5T.S0067
{
    public class ProjectFileScripts : IProjectFileScripts
    {
        #region Infrastructure

        public static IProjectFileScripts Instance { get; } = new ProjectFileScripts();


        private ProjectFileScripts()
        {
        }

        #endregion
    }
}
