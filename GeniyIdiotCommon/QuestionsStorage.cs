using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace GeniyIdiot.Common
{
    public static class QuestionsStorage
    {
        public static string FileName = "Questions.json";

        public static List<Question> GetQuestions()
        {
            var questions = new List<Question>();

            if (FileProvider.Exists(FileName))
            {
                var fileData = FileProvider.Get(FileName);
                var results = JsonConvert.DeserializeObject<List<Question>>(fileData);
                return results;

            }
            else
            {
                questions.Add(new Question("Сколько будет два плюс два умноженное на два?",6));
                questions.Add(new Question("Бревно нужно распилить на 10 частей.Сколько распилов нужно сделать?",9));
                questions.Add(new Question("На двух руках 10 пальцев.Сколько пальцев на 5 руках?",25));
                questions.Add(new Question("Укол делают каждые полчаса.Сколько нужно минут, чтобы сделать три укола?",60));
                questions.Add(new Question("Пять свечей горело, две потухли. Сколько свечей осталось ?",2));

                Save(questions);
            }

            return questions;
        }

        public static void Save(List<Question> questions)
        {
            var jsonData = JsonConvert.SerializeObject(questions, Formatting.Indented);
            FileProvider.Write(FileName, jsonData);
                
        }

        public static void Add(Question question)
        {
            var questions = GetQuestions();
            questions.Add(question);
            Save(questions);
        }

        public static void Delete(int index)
        {
            var questions = GetQuestions();

            if (index > questions.Count - 1)
            {
                throw new Exception("Wrong question index");
            }
            questions.RemoveAt(index);

            Save(questions);
        }

        public static int FindByText(string text)
        {
            var questions = GetQuestions();
            for (int i = 0; i < questions.Count; i++)
            {
                if (questions[i].Text == text)
                {
                    return i;
                }
            }
            throw new Exception("Wrong question text");
        }

        
    }
}








