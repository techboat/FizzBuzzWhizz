/*********************************************************
文件名：RuleEngine.cs
创建人：platobeing
创建时间：2014-5-1 17:20:11
描述：规则引擎 RuleEngine ，实现了接口 IRuleEngine。
修改记录：
 * 
*********************************************************/
namespace FizzBuzzWhizzLib
{
    public sealed class RuleEngine : IRuleEngine
    {
        private SpecialNumber _specialNumber;

        /// <summary>
        /// 设置特殊数。
        /// </summary>
        /// <param name="specialNumber">特殊数。</param>
        public void SetSpecialNumber(SpecialNumber specialNumber)
        {
            _specialNumber = specialNumber;
        }
        /// <summary>
        /// 接收学生报数，获取计算结果。
        /// </summary>
        /// <param name="studentNumber">学生报数。</param>
        /// <returns>根据规则计算出的结果。</returns>
        public string GetResult(int studentNumber)
        {
            if (studentNumber <= 0)
            {
                return string.Empty;
            }
            if (studentNumber.ToString().Contains(_specialNumber.S1.ToString()))
            {
                return "Fizz";
            }
            if (0 != studentNumber % _specialNumber.S1 &&
                0 != studentNumber % _specialNumber.S2 && 
                0 != studentNumber % _specialNumber.S3)
            {
                return studentNumber.ToString();
            }
            var result = string.Empty;
            if (0 == studentNumber % _specialNumber.S1)
            {
                result += "Fizz";
            }

            if (0 == studentNumber % _specialNumber.S2)
            {
                result += "Buzz";
            }

            if (0 == studentNumber % _specialNumber.S3)
            {
                result += "Whizz";
            }

            return result;
        }
    }
}
