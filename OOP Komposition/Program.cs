using System;

namespace OOP_Komposition
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tilknytning

            //Supplier s = new(1, "Ølbutikken)", null); //
            //ContactInfo CI = new(1, "Lasse@CopyPaste.dk", "911");
            //ContactInfo CI2 = new(2, "Philip Flamingo", //"1-800-273-8255");
            //ContactInfo CI3 = new(1, "Asbjørn@DetFeminineKrænkelsesMinisteriet.dk", "Børnetelefonen . . .");
            //s.ContactInfo = CI;
            //s.ContactInfo = CI2;
            //s.ContactInfo = CI3;



            //Injection
            ContactInfo CI = new(1, "lasse@pastor.dk", "911");
            Supplier s = new(1, "Ølbutikken", CI);
        }
    }
}
