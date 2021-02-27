using System;
using System.Data.SqlClient;

namespace Alif_bank_projekt
{
    class AlifSystemBank
    {
        AlifDataBasa User = new AlifDataBasa();
        public AlifSystemBank()
        {
            Console.SetWindowSize(100, 25);
            Console.Title = "Alif Bank";
            Console.ForegroundColor = ConsoleColor.White;
        }
        private string Text(int probeladd, string nadp, string ment = "R")
        {
            if (ment == "L")
                nadp = nadp.PadLeft(probeladd + nadp.Length);
            else
            {
                nadp = nadp.PadLeft(probeladd + nadp.Length);
                nadp = nadp.PadRight((98 - nadp.Length) + nadp.Length);
            }
            return nadp;
        }
        private static void Center(string soobsheniya)
        {
            int spaces = 50 + (soobsheniya.Length / 2);
            Console.WriteLine(soobsheniya.PadLeft(spaces));
        }
        private int GlavMenu()
        {

        }
        private int AccauntMenu()
        {

        }
        private void Registr()
        {

        }
        private void Help()
        {

        }
        private void AddMoney()
        {

        }
        private void WithdrawMoney()
        {

        }
        private void UpBalance()
        {

        }
        private void ShowAccaunt()
        {

        }
        private void Exitt()
        {

        }
        private void VhodAccaunt()
        {

        }
        private void Passbook()
        {

        }
        static void Main(string[] args)
        {

        }
    }
}
