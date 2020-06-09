using System;
using System.Text;

namespace EasyTextEncyption
{
   
    internal class Program
    {
        private static byte[] Encyption(byte[] data)
        {
            Console.Write(" Debug >> :");
            for (int i = 0; i < data.Length; i++)
            {
                data[i] ^= 0x11;
               
                Console.Write(" {0} ",data[i]);
            }
            
            return data;
        }
        private static byte[] Decyption(byte[] data)
        {
            for (int i = 0; i < data.Length; i++)
            {
                data[i] ^= 0x11;
            }
            
            return data;
        }
        public static void Main(string[] args)
        {
            string RawText;
            Console.WriteLine("-- Easy Binary File Encoder --");
            Console.Write("Enter Your Raw Text:");

            string CaseType;
           
            RawText = Console.ReadLine();
            Console.Write("Please Enter Case to encypt or decypt | 1 Encpytion , 2 Decyption: ");
            CaseType = Console.ReadLine();
            byte[] RawTextByte;
            byte[] getEncode;
            string Encoded;
            switch (CaseType)
            {
                case "1":
                    RawTextByte = Encoding.ASCII.GetBytes(RawText);
                    getEncode = Encyption(RawTextByte);
                    Encoded = Encoding.ASCII.GetString(getEncode);
                    using (System.IO.StreamWriter file =
                        new System.IO.StreamWriter("MyText.etb", true))
                    {
                        file.WriteLine(Encoded);
                    }
                    break;
                case "2":
                        RawTextByte = Encoding.ASCII.GetBytes(RawText);
                        getEncode = Decyption(RawTextByte);
                        Encoded = Encoding.ASCII.GetString(getEncode);
                        break;
                default:
                    return;
                
            }
            
            Console.WriteLine("Raw Text: {0}",RawText);
            Console.WriteLine("Encoding Text: {0}",Encoded);
        }
    }
}