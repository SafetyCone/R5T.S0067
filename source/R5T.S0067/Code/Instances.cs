using System;


namespace R5T.S0067
{
    public static class Instances
    {
        public static F0000.IFileOperator FileOperator => F0000.FileOperator.Instance;
        public static F0000.IFileSystemOperator FileSystemOperator => F0000.FileSystemOperator.Instance;
        public static F0033.INotepadPlusPlusOperator NotepadPlusPlusOperator => F0033.NotepadPlusPlusOperator.Instance;
        public static IPaths Paths => S0067.Paths.Instance;
        public static L0032.IProjectElementOperator ProjectElementOperator => L0032.ProjectElementOperator.Instance;
        public static O0025.IProjectElementOperations ProjectElementOperations => O0025.ProjectElementOperations.Instance;
        public static L0033.IProjectFileContextOperations ProjectFileContextOperations => L0033.ProjectFileContextOperations.Instance;
        public static L0033.IProjectFileContextOperator ProjectFileContextOperator => L0033.ProjectFileContextOperator.Instance;
        public static O0009.IProjectFileGenerationOperations ProjectFileGenerationOperations => O0009.ProjectFileGenerationOperations.Instance;
        public static O0006.IProjectFileOperations ProjectFileOperations => O0006.ProjectFileOperations.Instance;
        public static L0032.IProjectFileXmlOperator ProjectFileXmlOperator => L0032.ProjectFileXmlOperator.Instance;
        public static Z0052.IProjectFileXmlTexts ProjectFileXmlTexts => Z0052.ProjectFileXmlTexts.Instance; 
        public static IValues Values => S0067.Values.Instance;
    }
}