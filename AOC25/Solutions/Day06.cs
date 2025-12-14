using AOC25;

namespace AOC.Solutions {
    public class Day06 : IDay {
        private readonly string[] input;

        public Day06() {
            input = Utils.ReadInput(6); 
        }

        public string Part1() {
            long result = 0;
            var lineCount = Utils.GetLinesCount(6);
            List<List<int>> numbers = BuildNumbersArrays(lineCount, input);
            List<string> operators = GetOperators();
            var largestLength = numbers.Select(x => x.Count).Max();

            for (int i = 0; i < largestLength; i++)
            {
                var op = operators[i];
                var nums = numbers.Select(x => x[i]);
                if (op == "*")
                {
                    long current = 1;
                    foreach(var num in nums)
                    {
                        current = current * num;
                    }
                    result += current;
                }
                else
                {
                    long current = 0;
                    foreach(var num in nums)
                    {
                        current = current + num;
                    }
                    result += current;
                }
            }

            return result.ToString();
        }

        private List<List<int>> BuildNumbersArrays(int lineCount, string[] input)
        {
            List<List<int>> result = new List<List<int>>();

            for(int i = 0; i < lineCount-1; i++)
            {
                // split multiple spaces
                var arr = input[i].Split((char[])null, StringSplitOptions.RemoveEmptyEntries);
                result.Add(arr.Select(int.Parse).ToList());
            }
            return result;
        }

        private List<string> GetOperators()
        {
            var operators = Utils.ReadLastLine(6);
            var ops = operators.Split((char[])null, StringSplitOptions.RemoveEmptyEntries).ToList();
            Console.WriteLine($"ops: {ops}");
            return ops;
        }

        public string Part2() {
            // TODO: write your solution here
            int result = 0;

            return result.ToString();
        }
    }
}
