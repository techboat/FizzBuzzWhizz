/*********************************************************
文件名：Program.cs
创建人：platobeing
创建时间：2014-5-1 17:20:11
描述：该控制台程序接受用户输入以英文逗号分隔的三个特殊数，并按顺序打印出 100 个学生相应的输出结果。
修改记录：
 * 
*********************************************************/
namespace Test
{
    using FizzBuzzWhizzLib;
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            var gymTeacher = new GymTeacher();
            var ruleEngine = RuleEngineFactory.CreateRuleEngine();
            var students = initStudents(100, ruleEngine);
            
            while (true)
            {
                Console.Write("请输入三个不同的个位数，用英文逗号分隔：");
                var input = Console.ReadLine();

                if (!gymTeacher.TryParseInput(input))
                {
                    Console.WriteLine("输入有误，请重新输入");
                    continue;
                }

                foreach (var s in students)
                {
                    s.SetSpecialNumber(gymTeacher.SpecialNumber);
                    var result = s.GetResult();
                    s.Print(result);
                }
            }
        }

        /// <summary>
        /// 初始化学生数组。
        /// </summary>
        /// <param name="count">要初始化的学生个数。</param>
        /// <param name="ruleEngine">规则引擎接口。</param>
        /// <returns>学生数组。</returns>
        private static Student[] initStudents(int count, IRuleEngine ruleEngine)
        {
            var students = new Student[count];
            for (int i = 0; i < count; i++)
            {
                students[i] = new Student(i + 1, ruleEngine);
            }
            return students;
        }
    }
}
