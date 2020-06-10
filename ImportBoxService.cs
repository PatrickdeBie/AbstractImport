using System;

namespace AbstractClassTest
{
    public class ImportBoxService : BaseImport
    {
        public override void SaveMessage(int i)
        {
            Console.WriteLine("Getalletje: " + i);
        }
    }
}
