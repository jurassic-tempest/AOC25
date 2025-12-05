using AOC25;

namespace AOC.Solutions {
    public class Day03 : IDay {
        private readonly string[] input;

        public Day03() {
            input = Utils.ReadInput(3); // loads Inputs/day01.txt
        }

        public string Part1() {
            int result = 0;

            foreach (var line in input) {
                var bank = line.Select(c => c - '0').ToArray();
                int l = 0;
                int battery = 0;

                for (int r = 1; r < bank.Count(); r++) {
                    battery = Math.Max(battery, (bank[l] * 10) + bank[r]);
                    if (bank[l] < bank[r]) {
                        l = r;
                    }
                }
                result += battery;
            }
            return result.ToString();
            // sliding window
        }

        public string Part2() {
            // TODO: write your solution here
            int result = 0;

            return result.ToString();
        }
    }
}
