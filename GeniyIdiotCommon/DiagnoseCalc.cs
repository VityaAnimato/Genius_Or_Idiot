using System.Collections.Generic;

namespace GeniyIdiot.Common
{
    public class DiagnoseCalc
    {
        public static string GetDiagnose(int countRightAnswers, int countQuestions)
        {
            var diagnoses = new List<string>();
            diagnoses.Add("идиот");
            diagnoses.Add("кретин");
            diagnoses.Add("дурак");
            diagnoses.Add("нормальный");
            diagnoses.Add("талант");
            diagnoses.Add("гений");

            var percentageOfCorrectSolutions = countRightAnswers * 100 / countQuestions;
            return diagnoses[percentageOfCorrectSolutions / 20];
        }
    }
}








