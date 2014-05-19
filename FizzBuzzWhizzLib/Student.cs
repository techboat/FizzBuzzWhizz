/*********************************************************
文件名：Student.cs
创建人：platobeing
创建时间：2014-5-1 17:20:11
描述：表示学生这个类，继承自 Person。
修改记录：
 * 
*********************************************************/
namespace FizzBuzzWhizzLib
{
    public class Student : Person
    {
        /// <summary>
        /// 学生报数。
        /// </summary>
        private readonly int _studentNumber;
        /// <summary>
        /// 规则引擎接口。
        /// </summary>
        private readonly IRuleEngine _ruleEngine;

        /// <summary>
        /// 构造函数。
        /// </summary>
        /// <param name="studentNumber">学生报数。</param>
        /// <param name="ruleEngine">规则引擎接口。</param>
        public Student(int studentNumber, IRuleEngine ruleEngine)
        {
            _studentNumber = studentNumber;
            _ruleEngine = ruleEngine;
        }

        /// <summary>
        /// 设置特殊数。
        /// </summary>
        /// <param name="specialNumber">特殊数。</param>
        public void SetSpecialNumber(SpecialNumber specialNumber)
        {
            _ruleEngine.SetSpecialNumber(specialNumber);
        }

        /// <summary>
        /// 根据规则引擎和学生报数，计算输出结果。
        /// </summary>
        /// <returns>输出结果。</returns>
        public string GetResult()
        {
            return _ruleEngine.GetResult(_studentNumber);
        }
    }
}
