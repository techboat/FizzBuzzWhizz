/*********************************************************
文件名：IPrinter.cs
创建人：platobeing
创建时间：2014-5-1 17:20:11
描述：定义了一个打印接口，包含一个打印方法。
修改记录：
 * 
*********************************************************/

namespace FizzBuzzWhizzLib
{
    public interface IPrinter
    {
        /// <summary>
        /// 打印消息。
        /// </summary>
        /// <param name="msg">消息内容。</param>
        void Print(string msg);
    }
}
