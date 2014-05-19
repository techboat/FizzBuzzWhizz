/*********************************************************
文件名：GymTeacher.cs
创建人：platobeing
创建时间：2014-5-1 17:20:11
描述：表示体育老师的类，继承自 Teacher 类，并实现了接口 IGymTeacher。
修改记录：
 * 
*********************************************************/

namespace FizzBuzzWhizzLib
{
    using System;

    /// <summary>
    /// 体育老师类。
    /// </summary>
    public class GymTeacher : Teacher, IGymTeacher
    {
        private SpecialNumber _specialNumber;

        /// <summary>
        /// 特殊数。
        /// </summary>
        public SpecialNumber SpecialNumber
        {
            get { return _specialNumber; }
        }

        public GymTeacher()
        {
            _specialNumber = new SpecialNumber();
        }

        /// <summary>
        /// 尝试解析用户输入。
        /// </summary>
        /// <param name="input">用户输入。</param>
        /// <returns>解析成功时返回 ture，失败时返回 false。</returns>
        public bool TryParseInput(string input)
        {

            int a, b, c;
            try
            {
                var splits = input.Split(new[] { ',' });
                if (splits.Length != 3)
                {
                    return false;
                }

                if (!Int32.TryParse(splits[0], out a) ||
                    !Int32.TryParse(splits[1], out b) ||
                    !Int32.TryParse(splits[2], out c))
                {
                    return false;
                }

                if (a <= 0 || a >= 10 || b <= 0 || b >= 10 || c <= 0 || c >= 10)
                {
                    return false;
                }

                if (a == b || a == c || b == c)
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
            _specialNumber.S1 = a;
            _specialNumber.S2 = b;
            _specialNumber.S3 = c;

            return true;
        }
    }
}
