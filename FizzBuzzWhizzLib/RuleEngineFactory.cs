/*********************************************************
文件名：RuleEngineFactory.cs
创建人：platobeing
创建时间：2014-5-1 17:20:11
描述：规则引擎 RuleEngine 工厂方法类。
修改记录：
 * 
*********************************************************/

namespace FizzBuzzWhizzLib
{
    public sealed class RuleEngineFactory
    {
        /// <summary>
        /// 创建一个 RuleEngine 实例。
        /// </summary>
        /// <returns>新创建的 RuleEngine 实例，并表示成接口 IRuleEngine 的形式。</returns>
        public static IRuleEngine CreateRuleEngine()
        {
            return new RuleEngine();
        }
    }
}
