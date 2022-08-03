using System;

namespace GeniyIdiot.Common
{
    public class User
    {

        public string Name { get; set; }
        public int LastQtyRightAnswers { get; set; }
        public string LastDiagnose { get; set; }

        public User()
        {

        }

        public User(string name)
        {
            Name = name;
        }
    }
}








