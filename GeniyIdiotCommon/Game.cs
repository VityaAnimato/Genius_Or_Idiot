using System;
using System.Collections.Generic;

namespace GeniyIdiot.Common
{
    public class Game
    {
        public User User;
        List<Question> questions;
        public Question CurrentQuestion;
        int questionNumber = 0;
        public int CountQuestions;

        public Game(User user)
        {
            User = user;
            questions = QuestionsStorage.GetQuestions();
            CountQuestions = questions.Count;

        }

        public Question GetNextQuestion()
        {
            var random = new Random();
            var randomQuestionIndex = random.Next(0, questions.Count);
            CurrentQuestion = questions[randomQuestionIndex];

            questionNumber++;

            return CurrentQuestion;
        }

        public void AcceptAnswer(int userAnswer)
        {
            var rightAnswer = CurrentQuestion.Answer;
            if (rightAnswer == userAnswer)
            {
                User.LastQtyRightAnswers++;
            }

            questions.Remove(CurrentQuestion);
        }

        public void RejectAnswer()
        {
            questions.Remove(CurrentQuestion);
        }

        public string GetQuestionNumberText()
        {
            return $"Вопрос #{questionNumber}";
        }

        public void GetDiagnose()
        {
            User.LastDiagnose = DiagnoseCalc.GetDiagnose(User.LastQtyRightAnswers, CountQuestions);
        }

        public bool End()
        {
            return questions.Count == 0;
        }
    }
}
