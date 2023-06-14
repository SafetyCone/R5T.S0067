using System;


namespace R5T.S0067
{
    public class ProjectFileDemonstrations : IProjectFileDemonstrations
    {
        #region Infrastructure

        public static IProjectFileDemonstrations Instance { get; } = new ProjectFileDemonstrations();


        private ProjectFileDemonstrations()
        {
        }

        #endregion
    }
}
