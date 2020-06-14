namespace src.FM
{
    public class CopyTaskFactory : IGeneratorTaskFactory
    {
        public IGeneratorTask CreateGeneratorTask()
        {
            return new CopyTask();
        }
    }
}