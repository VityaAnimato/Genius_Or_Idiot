namespace GeniyIdiot.Common
{
    public class Question
    {
        public string Text;
        public int Answer;

        public Question()
        {
            Text = "Вопрос не определён";
            Answer = 0;
        }

        public Question(string text, int answer)
        {
            Text = text;
            Answer = answer;
        }
    }
}








