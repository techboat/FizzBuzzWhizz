/*********************************************************
文件名：RuleEngineTests.cs
创建人：platobeing
创建时间：2014-5-1 17:20:11
描述：规则引擎 RuleEngine 单元测试，只包含了方法 GetReuslt 的测试。
修改记录：
 * 
*********************************************************/

namespace UnitTestProject
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using FizzBuzzWhizzLib;

    [TestClass]
    public class RuleEngineTests
    {
        /// <summary>
        /// 学生报数小于零，特殊数：3,5,7。
        /// </summary>
        [TestMethod]
        public void GetResultWithStudentNumberLessThanZero()
        {
            var ruleEngine = RuleEngineFactory.CreateRuleEngine();
            var specialNumber = new SpecialNumber(3, 5, 7);
            var studentNumber = -1;
            var expected = string.Empty;

            ruleEngine.SetSpecialNumber(specialNumber);
            var actual = ruleEngine.GetResult(studentNumber);

            Assert.AreEqual(expected, actual, "规则引擎没有正确计算报数 " + studentNumber + " 的输出");
        }

        /// <summary>
        /// 学生报数等于零，特殊数：3,5,7。
        /// </summary>
        [TestMethod]
        public void GetResultWithStudentNumberEqualsZero()
        {
            var ruleEngine = RuleEngineFactory.CreateRuleEngine();
            var specialNumber = new SpecialNumber(3, 5, 7);
            var studentNumber = 0;
            var expected = string.Empty;

            ruleEngine.SetSpecialNumber(specialNumber);
            var actual = ruleEngine.GetResult(studentNumber);

            Assert.AreEqual(expected, actual, "规则引擎没有正确计算报数 " + studentNumber + " 的输出");
        }

        /// <summary>
        /// 学生报数（3）包含第一个特殊数，特殊数：3,5,7。
        /// </summary>
        [TestMethod]
        public void GetResultWithStudentNumberContainsSpecialNumber1()
        {
            var ruleEngine = RuleEngineFactory.CreateRuleEngine();
            var specialNumber = new SpecialNumber(3, 5, 7);
            var studentNumber = 3;
            var expected = "Fizz";

            ruleEngine.SetSpecialNumber(specialNumber);
            var actual = ruleEngine.GetResult(studentNumber);

            Assert.AreEqual(expected, actual, "规则引擎没有正确计算报数 " + studentNumber + " 的输出");
        }

        /// <summary>
        /// 学生报数（13）包含第一个特殊数，特殊数：3,5,7。
        /// </summary>
        [TestMethod]
        public void GetResultWithStudentNumberContainsSpecialNumber2()
        {
            var ruleEngine = RuleEngineFactory.CreateRuleEngine();
            var specialNumber = new SpecialNumber(3, 5, 7);
            var studentNumber = 13;
            var expected = "Fizz";

            ruleEngine.SetSpecialNumber(specialNumber);
            var actual = ruleEngine.GetResult(studentNumber);

            Assert.AreEqual(expected, actual, "规则引擎没有正确计算报数 " + studentNumber + " 的输出");
        }

        /// <summary>
        /// 学生报数（35）包含第一个特殊数，特殊数：3,5,7。
        /// </summary>
        [TestMethod]
        public void GetResultWithStudentNumberContainsSpecialNumber3()
        {
            var ruleEngine = RuleEngineFactory.CreateRuleEngine();
            var specialNumber = new SpecialNumber(3, 5, 7);
            var studentNumber = 35;
            var expected = "Fizz";

            ruleEngine.SetSpecialNumber(specialNumber);
            var actual = ruleEngine.GetResult(studentNumber);

            Assert.AreEqual(expected, actual, "规则引擎没有正确计算报数 " + studentNumber + " 的输出");
        }

        /// <summary>
        /// 学生报数（6）是第一个特殊数的倍数，特殊数：3,5,7。
        /// </summary>
        [TestMethod]
        public void GetResultWithStudentNumberTimesFirstSpecialNumber()
        {
            var ruleEngine = RuleEngineFactory.CreateRuleEngine();
            var specialNumber = new SpecialNumber(3, 5, 7);
            var studentNumber = 6;
            var expected = "Fizz";

            ruleEngine.SetSpecialNumber(specialNumber);
            var actual = ruleEngine.GetResult(studentNumber);

            Assert.AreEqual(expected, actual, "规则引擎没有正确计算报数 " + studentNumber + " 的输出");
        }

        /// <summary>
        /// 学生报数（10）是第二个特殊数的倍数，特殊数：3,5,7。
        /// </summary>
        [TestMethod]
        public void GetResultWithStudentNumberTimesSecondSpecialNumber()
        {
            var ruleEngine = RuleEngineFactory.CreateRuleEngine();
            var specialNumber = new SpecialNumber(3, 5, 7);
            var studentNumber = 10;
            var expected = "Buzz";

            ruleEngine.SetSpecialNumber(specialNumber);
            var actual = ruleEngine.GetResult(studentNumber);

            Assert.AreEqual(expected, actual, "规则引擎没有正确计算报数 " + studentNumber + " 的输出");
        }

        /// <summary>
        /// 学生报数（14）是第三个特殊数的倍数，特殊数：3,5,7。
        /// </summary>
        [TestMethod]
        public void GetResultWithStudentNumberTimesThirdSpecialNumber()
        {
            var ruleEngine = RuleEngineFactory.CreateRuleEngine();
            var specialNumber = new SpecialNumber(3, 5, 7);
            var studentNumber = 14;
            var expected = "Whizz";

            ruleEngine.SetSpecialNumber(specialNumber);
            var actual = ruleEngine.GetResult(studentNumber);

            Assert.AreEqual(expected, actual, "规则引擎没有正确计算报数 " + studentNumber + " 的输出");
        }

        /// <summary>
        /// 学生报数（15）是第一个和第二个特殊数的倍数，特殊数：3,5,7。
        /// </summary>
        [TestMethod]
        public void GetResultWithStudentNumberTimesFirstSecondSpecialNumber()
        {
            var ruleEngine = RuleEngineFactory.CreateRuleEngine();
            var specialNumber = new SpecialNumber(3, 5, 7);
            var studentNumber = 15;
            var expected = "FizzBuzz";

            ruleEngine.SetSpecialNumber(specialNumber);
            var actual = ruleEngine.GetResult(studentNumber);

            Assert.AreEqual(expected, actual, "规则引擎没有正确计算报数 " + studentNumber + " 的输出");
        }

        /// <summary>
        /// 学生报数（21）是第一个和第三个特殊数的倍数，特殊数：3,5,7。
        /// </summary>
        [TestMethod]
        public void GetResultWithStudentNumberTimesFirstThirdSpecialNumber()
        {
            var ruleEngine = RuleEngineFactory.CreateRuleEngine();
            var specialNumber = new SpecialNumber(3, 5, 7);
            var studentNumber = 21;
            var expected = "FizzWhizz";

            ruleEngine.SetSpecialNumber(specialNumber);
            var actual = ruleEngine.GetResult(studentNumber);

            Assert.AreEqual(expected, actual, "规则引擎没有正确计算报数 " + studentNumber + " 的输出");
        }

        /// <summary>
        /// 学生报数（70）是第二个和第三个特殊数的倍数，特殊数：3,5,7。
        /// </summary>
        [TestMethod]
        public void GetResultWithStudentNumberTimesSecondThirdSpecialNumber()
        {
            var ruleEngine = RuleEngineFactory.CreateRuleEngine();
            var specialNumber = new SpecialNumber(3, 5, 7);
            var studentNumber = 70;
            var expected = "BuzzWhizz";

            ruleEngine.SetSpecialNumber(specialNumber);
            var actual = ruleEngine.GetResult(studentNumber);

            Assert.AreEqual(expected, actual, "规则引擎没有正确计算报数 " + studentNumber + " 的输出");
        }

        /// <summary>
        /// 学生报数（105）是第一个、第二个和第三个特殊数的倍数，特殊数：3,5,7。
        /// </summary>
        [TestMethod]
        public void GetResultWithStudentNumberTimesFirstSecondThirdSpecialNumber()
        {
            var ruleEngine = RuleEngineFactory.CreateRuleEngine();
            var specialNumber = new SpecialNumber(3, 5, 7);
            var studentNumber = 105;
            var expected = "FizzBuzzWhizz";

            ruleEngine.SetSpecialNumber(specialNumber);
            var actual = ruleEngine.GetResult(studentNumber);

            Assert.AreEqual(expected, actual, "规则引擎没有正确计算报数 " + studentNumber + " 的输出");
        }

        /// <summary>
        /// 学生报数（11）不满足任意一种特殊输出的情况，特殊数：3,5,7。
        /// </summary>
        [TestMethod]
        public void GetResultWithStudentNumberNothing()
        {
            var ruleEngine = RuleEngineFactory.CreateRuleEngine();
            var specialNumber = new SpecialNumber(3, 5, 7);
            var studentNumber = 11;
            var expected = "11";

            ruleEngine.SetSpecialNumber(specialNumber);
            var actual = ruleEngine.GetResult(studentNumber);

            Assert.AreEqual(expected, actual, "规则引擎没有正确计算报数 " + studentNumber + " 的输出");
        }
    }
}
