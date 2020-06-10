namespace AbstractClassTest
{
    public abstract class BaseImport : IFileBasedImport
    {
        public void Import()
        {
            // doe iets
            int i = 0;
            i++;

            SaveMessage(i);
        }

        public abstract void SaveMessage(int i);
    }
}
