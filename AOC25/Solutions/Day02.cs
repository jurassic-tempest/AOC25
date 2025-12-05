using AOC25;
using System.Numerics;

namespace AOC.Solutions {
    public class Day02 : IDay {
        private readonly string input;

        public Day02() {
            input = Utils.ReadInputRaw(2);
        }

        public string Part1() {
            long result = 0;

            string[] ids = input.Split(new char[] {','});

            foreach (var id in ids.ToList()) 
            {
                var firstId = id.Split(new char[] {'-'})[0];
                var lastId = id.Split(new char[] {'-'})[1];
                var firstIdInt = long.Parse(firstId);
                var lastIdInt = long.Parse(lastId);

                for (long i = firstIdInt; i <= lastIdInt; i++)
                {
                    if (i.ToString().Length % 2 != 0) continue;
                    if (IsInvalid(i)) result += i;
                } 
            }

            return result.ToString();
        }

        private bool IsInvalid(long id)
        {
            var idString = id.ToString();
            var length = idString.Length;

            var firstHalf = idString.Substring(0, length/2);
            var secondHalf = idString.Substring(length/2);
            //Console.WriteLine($"firstHalf: {firstHalf}, secondHalf: {secondHalf}");
            return firstHalf == secondHalf;
        }

        public string Part2() {
            // TODO: write your solution here
            BigInteger result = new BigInteger(0);

            string[] ids = input.Split(new char[] {','});

            foreach (var id in ids.ToList()) 
            {
                var firstId = id.Split(new char[] {'-'})[0];
                var lastId = id.Split(new char[] {'-'})[1];
                var firstIdInt = long.Parse(firstId);
                var lastIdInt = long.Parse(lastId);

                for (long i = firstIdInt; i <= lastIdInt; i++)
                {
                    if (i.ToString().Length % 2 != 0) continue;
                    if (IsInvalidTwo(i)) result = result + new BigInteger(i);
                } 
            }

            return result.ToString();
        }

        private bool IsInvalidTwo(long id)
        {
            string s = id.ToString();
            string doubled = s + s;

            return doubled.IndexOf(s, 1) != s.Length;
        }
    }
}
