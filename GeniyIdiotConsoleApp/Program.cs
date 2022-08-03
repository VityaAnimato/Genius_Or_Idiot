using System;
using GeniyIdiot.Common;

namespace GeniyIdiotConsoleApp
{
    public static class Program
    {
        static void Main(string[] args)
        {
            var user = new User(GetUserName());

            Console.WriteLine("\nНачинаем тестирование!\n");
           
            do
            {
                var game = new Game(user);

                while (!game.End())
                {
                    var currentQuestion = game.GetNextQuestion();
                    Console.WriteLine(game.GetQuestionNumberText());
                    Console.WriteLine(currentQuestion.Text);

                    game.AcceptAnswer(GetNumber());
                }
                
                game.GetDiagnose();

                UsersResultStorage.Append(user);

                Console.WriteLine($"\n{user.Name}, ваш диагноз: {user.LastDiagnose}\n");
            } while (GetYesOrNo("Хотите ли Вы повторить тест?\n"));


            if (GetYesOrNo("\nХотите ли Вы посмотреть предыдущие результаты тестирования?\n"))
            {
                ShowResults();
            }

            while (GetYesOrNo("\nХотите ли Вы добавить новый вопрос?\n"))
            {
                var newQuestion = ValidateQuestion();
                QuestionsStorage.Add(newQuestion);
            }

            Console.WriteLine("\nУдачи!\n");
        }

        public static int GetNumber()

        {
            int number;
            while (!UserInput.TryParseNumber(Console.ReadLine(), out number, out string errorMessage))
            {
                Console.WriteLine(errorMessage);
            }
            return number;
        }

        public static bool GetYesOrNo(string consoleMessage)
        {
            Console.WriteLine(consoleMessage);

            while (true)
            {
                var userReply = Console.ReadLine();
                if (userReply.ToLower() == "да")
                {
                    return true;
                }
                else if (userReply.ToLower() == "нет")
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("введите -да- или -нет-");
                }
            }
        }

        public static string GetUserName()
        {
            Console.WriteLine("Введи ваше Имя:");
            while (true)
            {
                var userName = Console.ReadLine();
                if (UserInput.ValidateUserName(userName))
                {
                    return userName;
                }
                Console.WriteLine("Введите имя еще раз. Оно должно иметь не менее 1 и не более 15 символов");
            }
        }

        public static Question ValidateQuestion()
        {
            var question = new Question();
            Console.WriteLine("Введите вопрос...");

            while (true)
            {
                question.Text = Console.ReadLine();

                if (!UserInput.ValidateUserQuestion(question.Text))
                {
                    Console.WriteLine("Введите непустой вопрос! Не менее 10 символов."); ;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine("Введите ответ...");

            int number;
            while (!UserInput.TryParseNumber(Console.ReadLine(), out number, out string errorMessage))
            {
                Console.WriteLine(errorMessage);
            }
            question.Answer = number;

            return question;
        }

        public static void ShowResults()
        {
            Console.WriteLine($"|| {"ФИО",-15} || {"кол-во правильных ответов",15} || {"Диагноз",15} ||");

            if (FileProvider.Exists(UsersResultStorage.FileName))
            {
                var value = FileProvider.Get(UsersResultStorage.FileName);
                var lines = value.Split("\r\n", StringSplitOptions.RemoveEmptyEntries);
                foreach (var line in lines)
                {
                    var values = line.Split('#');

                    Console.WriteLine($"|| {values[0],-15} || {values[1],25} || {values[2],15} ||");
                }
            }
            else
            {
                Console.WriteLine("Результатов нет");
            }
        }
    }
}








