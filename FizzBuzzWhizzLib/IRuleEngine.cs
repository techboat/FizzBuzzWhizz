/*********************************************************
文件名：IRuleEngine.cs
创建人：platobeing
创建时间：2014-5-1 17:20:11
描述：为规则引擎定义的接口，包含两个方法，一个用于设置特殊数，一个用于接收学生报数并输出计算结果。
修改记录：
 * 
*********************************************************/
namespace FizzBuzzWhizzLib
{
    public interface IRuleEngine
    {
        /// <summary>
        /// 设置特殊数。
        /// </summary>
        /// <param name="specialNumber">特殊数。</param>
        void SetSpecialNumber(SpecialNumber specialNumber);
        /// <summary>
        /// 接收学生报数，获取计算结果。
        /// </summary>
        /// <param name="studentNumber">学生报数。</param>
        /// <returns>根据规则计算出的结果。</returns>
        string GetResult(int studentNumber);
    }
}
