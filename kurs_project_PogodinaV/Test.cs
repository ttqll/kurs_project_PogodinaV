using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kurs_project_PogodinaV
{
    public class Test
    {

        /*Без подключения к бд мало что получится сделать. В бд будут хранится правильные ответы на вопросы, а в методе CheckAnswer() 
       будет проверяться правильноссть данного ответа, и начисляться баллы. В методе GetResults() ссравниваются результат и максимальный 
        возможный результат и формируетсся диаграмма правильности выполнения. Все ошибки пользователя запоминаются и идут в формирование
        теста по частым ошибкам*/

        public List<string> section;
        public string theme;
        public int result;
        private const int _scoreA1 = 1;
        private const int _scoreB1 = 2;
        private const int _scoreC1 = 3;

        public static class UserAnswer
        {

        }

        public int CountMaxScore(int countA1, int countB1, int countC1)
        {
            return countA1 + countB1 * _scoreB1 + countC1 * _scoreC1;
        }



        public Test(List<string> section, string theme)
        {
            this.section = section;
            this.theme = theme;
            
           
        }
    }
}
