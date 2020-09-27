using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace InterviewCodingQuestions
{
    public class Anagram
    {
        public static bool IsAnagramPair(string first, string second)
        {

            Regex reg = new Regex("[*'\",_&#^@.]");

            first = reg.Replace(first, string.Empty).ToLower();
            second = reg.Replace(second, string.Empty).ToLower();

            first = new string(first.ToCharArray().OrderBy(c => c)
                    .Where(c => !Char.IsWhiteSpace(c))
                    .ToArray());

            second = new string(second.ToCharArray().OrderBy(c => c)
                    .Where(c => !Char.IsWhiteSpace(c))
                    .ToArray());

            if (first.Length == second.Length && first == second)
            {
                return true;
            }
            return false;
        }
        public static IEnumerable<TestCase> GetTestCases()
        {
            yield return new TestCase { First = "add", Second = "dad", Expected = true };
            yield return new TestCase { First = "aad", Second = "dad", Expected = false };
            yield return new TestCase { First = "Astronomer", Second = "Moon starer", Expected = true };
            yield return new TestCase { First = "thorough", Second = "through", Expected = false };
            yield return new TestCase { First = "Jim Morrison", Second = "Mr. Mojo Risin'", Expected = true };
        }
    }
    public class TestCase
    {
        public string First { get; set; }
        public string Second { get; set; }
        public bool Expected { get; set; }
    }
}
