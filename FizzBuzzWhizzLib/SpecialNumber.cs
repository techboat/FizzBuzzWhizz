/*********************************************************
文件名：SpecialNumber.cs
创建人：platobeing
创建时间：2014-5-1 17:20:11
描述：定义了一个特殊数结构体，包含三个字段 S1，S2，S3，分别代表三个特殊数。
修改记录：
 * 
*********************************************************/
namespace FizzBuzzWhizzLib
{
    public struct SpecialNumber
    {
        /// <summary>
        /// 第一个特殊数。
        /// </summary>
        public int S1 { get; set; }
        /// <summary>
        /// 第二个特殊数。
        /// </summary>
        public int S2 { get; set; }
        /// <summary>
        /// 第三个特殊数。
        /// </summary>
        public int S3 { get; set; }

        /// <summary>
        /// 构造函数。
        /// </summary>
        /// <param name="s1">第一个特殊数。</param>
        /// <param name="s2">第二个特殊数。</param>
        /// <param name="s3">第三个特殊数。</param>
        public SpecialNumber(int s1, int s2, int s3) : this()
        {
            S1 = s1;
            S2 = s2;
            S3 = s3;
        }
    }
}
