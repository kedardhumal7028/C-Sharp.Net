using System;

namespace Encapsulation_OOP_Example
{
    class Program
    {

        public class MedicineCapsule
        {
            private string Chemical;

            public void SetChemical(string value)
            {
                Chemical = value;
            }

            public string GetChemical()
            {
                return Chemical;
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            MedicineCapsule obj = new MedicineCapsule();

            obj.SetChemical("Paracetamol");

            string result = obj.GetChemical();

            Console.WriteLine("Medicine Inside a Capsule : " + result);
        }
    }
}
