/*********************************************************
文件名：IGymTeacher.cs
创建人：platobeing
创建时间：2014-5-1 17:20:11
描述：为体育老师定义的接口，包含一个方法，用于解析用户的输入。
修改记录：
 * 
*********************************************************/
namespace FizzBuzzWhizzLib
{
    public interface IGymTeacher
    {
        /// <summary>
        /// 尝试解析用户输入。
        /// </summary>
        /// <param name="input">用户输入。</param>
        /// <returns>解析成功时返回 ture，失败时返回 false。</returns>
        bool TryParseInput(string input);
    }
}
