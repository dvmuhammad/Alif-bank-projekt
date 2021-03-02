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
            Console.Clear();
            Center("**** Добро пожаловать в Alif Bank ****\n");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            
            Console.WriteLine("|{0}|", Text(0, ""));
            Console.WriteLine("|{0}|", Text(35, "1. Вход в аккаунт"));
            Console.WriteLine("|{0}|", Text(35, "2. Открыть новый счет"));
            Console.WriteLine("|{0}|", Text(35, "3. О нас"));
            Console.WriteLine("|{0}|", Text(35, "4. Выход"));
            Console.WriteLine("|{0}|", Text(0, ""));
            
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("\n{0}", Text(36, "Введите свой выбор : ", "L"));
            try {
                return (int.Parse(Console.ReadLine()));
            } catch (FormatException)
            {
                return 0;
            }
        }
        private int AccauntMenu()
        {
            Console.Clear();
            Center("**** Добро пожаловать в Alif Bank " + User.Title + ". " + User.Name + " ****\n");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            
            Console.WriteLine("|{0}|", Text(0, ""));
            Console.WriteLine("|{0}|", Text(37, "1. Внести Деньги"));
            Console.WriteLine("|{0}|", Text(37, "2. Вывод Денег"));
            Console.WriteLine("|{0}|", Text(37, "3. Моя Книжка"));
            Console.WriteLine("|{0}|", Text(37, "4. Показать данные моего аккаунта"));
            Console.WriteLine("|{0}|", Text(37, "5. Выход из системы"));
            Console.WriteLine("|{0}|", Text(0, ""));
            
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("\n{0}", Text(38, "Введите свой выбор : ", "L"));
            try
            {
                return (int.Parse(Console.ReadLine()));
            }catch(FormatException)
            {
                return 0;
            }
        }
        private void Registr()
        {
            Console.Clear();
            Center("**** Alif Bank | Регистрация ****\n");
            
            Console.Write("{0}",Text(30,"Ваше полное имя         : ","L"));
            User.Name = Console.ReadLine();
            
            Console.Write("{0}",Text(30,"Введите номер телефона (логин)  : ","L"));
            User.Password = Console.ReadLine();
                       
            Console.Write("{0}",Text(30,"Ваш пол[M/F]        : ","L"));
            char Gender = Console.ReadLine()[0]; 
            User.Title = (Gender == 'M' || Gender == 'm') ? "Mr" : "Ms";
            
            Console.Write("{0}",Text(20,"Семейное положение 1)Холост 2)Семеянин 3)Вразводе 4)Вдовец/вдов      : ","L"));
            char sem = Console.ReadLine()[0];
            
            Console.Write("{0}",Text(20,"Ваш возраст 1)до 25л  2)26-30л  3)36-62л  4)старше 63л  : ","L"));
            char age=Console.ReadLine()[0];

            Console.Write("{0}",Text(30,"Гражданство 1)Таджикистан 2)Зарубеж  : ","L"));
            char citizen=Console.ReadLine()[0];
            
            Console.Write("{0}",Text(10,"Сумма кредита от общего дохода 1)до 80%  2)80%-150%  3)150%-250%  4)свыше 250%  : ","L"));
            char credit_dohod=Console.ReadLine()[0];

            Console.Write("{0}",Text(7,"Кредитная история 1)более 3-ёх закр. кредитов  2)1-2 закр. кредита  3)нет кред. история : ","L"));
            char cred_history=Console.ReadLine()[0];

            Console.Write("{0}",Text(8,"Просрока в кредитной истории   1)свыше 7 раз    2)5-7 раз   3)4 раза  4)до 3 раза    : ","L"));
            char cred_prosrok=Console.ReadLine()[0];

            Console.Write("{0}",Text(15,"Цель кредита   1)бытовая техника     2)ремонт   3)телефон  4)прочее    : ","L"));
            char cred_sel=Console.ReadLine()[0];

            Console.Write("{0}",Text(15,"Срок кредита   1)более 12м   2)до 12м    : ","L"));
            char cred_time=Console.ReadLine()[0];


            int input=0;
            if (Gender=='M') input+=1;     
            if (Gender=='F') input+=2;
            if (sem=='1') input+=1;
            if (sem=='2') input+=2;    
            if (sem=='3') input+=1;
            if (sem=='4') input+=2;
            if (age=='1') input+=0;
            if (age=='2') input+=1;
            if (age=='3') input+=2;
            if (age=='4') input+=1;
            if (citizen=='1') input+=1;
            if (citizen=='2') input+=0;
            if (credit_dohod=='1') input +=4;
            if (credit_dohod=='2') input +=3;
            if (credit_dohod=='3') input +=2;
            if (credit_dohod=='4') input +=1;
            if (cred_history=='1') input +=2;
            if (cred_history=='2') input +=1;
            if (cred_history=='3') input -=1;
            if (cred_prosrok=='1') input -=3;
            if (cred_prosrok=='2') input -=2;
            if (cred_prosrok=='3') input -=1;
            if (cred_prosrok=='4') input +=0;
            if (cred_sel=='1') input+=2;
            if (cred_sel=='2') input+=1;
            if (cred_sel=='3') input+=0;
            if (cred_sel=='4') input-=1;
            if (cred_time=='1') input+=1;
            if (cred_time=='2') input+=1;

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\n");
            
            
            if (input>11)
            {
                Console.Write("{0}",Text(30,"Введите сумму депозита : ","L"));
                User.Total_Balance = UInt32.Parse(Console.ReadLine());

                Console.WriteLine("|{0}|",Text(13,"Спасибо за банковское обслуживание с нами | Ваш сгенерированный номер счета " + User.GenerateAccountNumber()));
                User.WriteToDatabase(2);
                User.UpdatePassbook(User.Total_Balance, "Deposit");
                
                Console.WriteLine("\n");
                Console.BackgroundColor = ConsoleColor.Black;
                Center("Пожалуйста, запишите номер вашего счета и логина!");
            }
            else
            {
                System.Console.WriteLine("Ошибка");
                
            }
            
        }
        private void Help()
        {
            Console.Clear();
            Center("**** Alif Bank | О нас ****\n");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            
            Console.WriteLine("|{0}|", Text(0, ""));
            Console.WriteLine("|{0}|", Text(34, "Алиф Банк — финансово-технологическая  "));
            Console.WriteLine("|{0}|", Text(35, "компания, основанная в 2014 году и"));
            Console.WriteLine("|{0}|", Text(35, "преобразованная в банк в 2020 году"));
            Console.WriteLine("|{0}|", Text(35, "Адрес: ул. Фотеха, Ниёзи 51, Душанбе"));
            Console.WriteLine("|{0}|", Text(34, "Телефон: 90 090 9080"));
            Console.WriteLine("|{0}|", Text(0, ""));
            
            Console.BackgroundColor = ConsoleColor.Black;
        }
        private void AddMoney()
        {
            Console.Clear();
            Center("**** Alif Bank | Внести Деньги ****\n");
            
            Console.Write("{0}",Text(30,"Введите сумму, которую вы хотите внести : ","L"));
            Double DepositAmount = Double.Parse(Console.ReadLine());
            User.Total_Balance += DepositAmount;
            Console.WriteLine("\n");
            Center("Сумма, внесенная на ваш счет успешно!");
            User.UpdatePassbook(DepositAmount, "Deposit");
            UpBalance();
        }
        private void WithdrawMoney()
        {
            Console.Clear();
            Center("**** Alif Bank | Вывод Денег ****\n");
            
            Console.Write("{0}",Text(30,"Введите сумму, которую вы хотите вывести : ","L"));
            Double WithDrawalAmount = Double.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            if (WithDrawalAmount <= User.Total_Balance)
            {
                User.Total_Balance -= WithDrawalAmount;
                Center("Вывод суммы с вашего счета прошел успешно!");
                User.UpdatePassbook(WithDrawalAmount, "Withdrawal");
                UpBalance();
            }
            else
                Center("У вас нет достаточного баланса на вашем счете, чтобы завершить эту транзакцию!");
        }
        private void UpBalance()
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\n");
            
            Console.WriteLine("|{0}|", Text(25, "Обновленный баланс на вашем счете составляет Tj. " + User.Total_Balance));
            
            Console.BackgroundColor = ConsoleColor.Black;
        }
        private void ShowAccaunt()
        {
            Console.Clear();
            Center("**** Alif Bank | Реквизиты счета ****\n");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            
            Console.WriteLine("|{0}|",Text(0, ""));
            Console.WriteLine("|{0}|",Text(25, "Номер счета            :  " + User.Account_Number));
            Console.WriteLine("|{0}|",Text(25, "Имя владельца счета     :  " + User.Title + ". " + User.Name));
            Console.WriteLine("|{0}|",Text(25, "Общий остаток на счете  :  " + "Tj. " + User.Total_Balance));
            Console.WriteLine("|{0}|",Text(25, "Последние Данные для Входа в систему        :  " + User.LastLoginDetails));
            Console.WriteLine("|{0}|",Text(0, ""));
            
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("\n");
            Center("Нажмите любую клавишу, чтобы вернуться в предыдущее меню!");
        }
        private void Exitt()
        {
            User.WriteToDatabase(3);
            Console.WriteLine("\n");
            Center("Спасибо, что воспользовались нашим сервисом!");
            Center("Вы успешно вышли из системы!");
            Center("Нажмите любую клавишу, чтобы вернуться в главное меню!");
        }
        
        private void VhodAccaunt()
        {
            Console.Clear();
            Center("**** Alif Bank | Входа в систему ****\n");
            
            Console.Write("{0}",Text(27,"Введите номер своего счета   :  ","L"));
            User.Account_Number = UInt32.Parse(Console.ReadLine());
            if (User.ReadFromDatabase())
            {
                Console.Write("{0}", Text(27,"Введите логин своей учетной записи :  ","L"));
                string UserPassword = Console.ReadLine();
                
                if (UserPassword == User.Password)
                {
                    bool sput = true;
                    while (sput)
                    {
                        switch (AccauntMenu())
                        {
                            case 1: AddMoney();
                                    break;
                            case 2: WithdrawMoney();
                                    break;
                            case 3: Passbook();
                                    break;
                            case 4: ShowAccaunt();
                                    break;
                            case 5: Exitt();
                                    sput = false;
                                    break;
                            default:Console.WriteLine("\n");
                                    Center("Неверный Вариант | Попробуйте Еще Раз!");
                                    break;
                        }
                        if (sput)
                            Console.ReadKey();
                    }
                }
                else
                    Center("Логин, который вы ввели, неверен");
            }
            else
            {
                Center("Извините но номер счета : " + User.Account_Number + " не существует в нашей базе данных");
                Center("Пожалуйста, проверьте номер счета и повторите попытку!");
            }
        }

        private void Passbook()
        {
            Console.Clear();
            Center("**** Alif Bank | Моя Книжка ****\n");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            
            Console.WriteLine("|{0}|",Text(5,"Сумма Сделки    |" + "    Время и Дата совершения сделки    |" + "    Описание транзакции"));
            
            Console.WriteLine("|{0}|", Text(0, "|".PadLeft(28) + "|".PadLeft(37)));
            System.Data.SqlClient.SqlDataReader dataReader = User.ReadPassbook();
            while (dataReader.Read())
            {
                int Length = dataReader.GetValue(1).ToString().Length;
                int DescLength = dataReader.GetValue(3).ToString().Length;
                string Amount = dataReader.GetValue(1).ToString(), DateAndTime = dataReader.GetValue(2).ToString().PadLeft(27).PadRight(36), Description = dataReader.GetValue(3).ToString().PadLeft(DescLength + 8);
                Console.WriteLine("|{0}|",Text(9,"Tj. " + Amount.PadRight(((14-Length)+Length)) + "|" + DateAndTime + "|" + Description));
            }
            Console.WriteLine("|{0}|", Text(0, "|".PadLeft(28) + "|".PadLeft(37)));
            
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("\n");
            Center("Нажмите любую клавишу, чтобы вернуться в предыдущее меню!");
            dataReader.Close();
        }

        static void Main(string[] args)
        {
            AlifSystemBank syst = new AlifSystemBank();
            while(true)
            {
                switch (syst.GlavMenu())
                {
                    case 1: syst.VhodAccaunt();
                            break;
                    case 2: syst.Registr();
                            break;
                    case 3: syst.Help();
                            Console.WriteLine("\n");
                            Center("Нажмите любую клавишу, чтобы вернуться в главное меню!");
                            break;
                    case 4: Console.WriteLine("\n");
                            Center("Спасибо, что воспользовались нашим сервисом!");
                            Center("Нажмите любую клавишу, чтобы закрыть консоль!");
                            Console.ReadKey();
                            Environment.Exit(0);
                            break;
                    default:Console.WriteLine("\n");
                            Center("Неверный Вариант | Попробуйте Еще Раз!");
                            break;
                }
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
