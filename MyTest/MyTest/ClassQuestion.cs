using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTest
{
    public class ClassQuestion
    {
        
        public string textQuestion; //Текст вопроса
        public string typeQuestion; //Тип вопроса
        public string answers; //Строка ответов

        List<ClassQuestion> listQuestion = new List<ClassQuestion>();

        public ClassQuestion(string textQ, string typeQ, string ans)
        {
            textQuestion = textQ;
            typeQuestion = typeQ;
            answers = ans;
        }
    }
}
