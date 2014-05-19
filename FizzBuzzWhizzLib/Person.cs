/*********************************************************
文件名：Person.cs
创建人：platobeing
创建时间：2014-5-1 17:20:11
描述：表示人类这个类，实现了 IPrinter 打印接口。
修改记录：
 * 
*********************************************************/

namespace FizzBuzzWhizzLib
{
    using System;
    public class Person : IPrinter
    {
        /// <summary>
        /// 将输入的消息打印到控制台。
        /// </summary>
        /// <param name="msg">要打印的消息。</param>
        public virtual void Print(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
