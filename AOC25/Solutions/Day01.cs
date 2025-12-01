using AOC25;

namespace AOC.Solutions {
    public class Day01 : IDay {
        private readonly string[] input;
        private readonly List<string> directions = new List<string>(){"l", "r"};

        public Day01() {
            input = Utils.ReadInput(1); // loads Inputs/day01.txt
        }

        public string Part1() {
            int result = 0;
            int start = 50;

            foreach (var line in input) {
                if (string.IsNullOrEmpty(line)) continue;
                var direction = line.Substring(0,1).ToLower();
                var movement = int.Parse(line.Substring(1));
                if (!directions.Contains(direction)) throw new Exception("Unsure which direction to go in...");
                
                bool goRight = direction == "r";
                start = goRight ? (start + movement) % 100 : (start - movement) % 100;
                if (start < 0) start += 100;
                
                //// Works on the sample (answer = 3 but not on the real data)
                // if (direction == "l")
                // {
                //     if (movement > start)
                //     {
                //         var total = movement - start;
                //         if (total <= 99)
                //         {
                //             start = 100 - total;
                //         }
                //         else
                //         {
                //             start = 100 - (Math.Abs(total) % 100);
                //         }
                //     }
                //     else
                //     {
                //         start = start-movement;
                //     }
                // }
                // else if (direction == "r")
                // {
                //     var total = movement+start;
                //     if (total > 99)
                //     {
                //         start = (movement+start) % 100;
                //     }
                //     else
                //     {
                //         start = total;
                //     }
                // }
                Console.WriteLine($"The dial is rotated {line} to point at {start}.");
                if (start == 0) result++;
            }

            return result.ToString();
        }


        public string Part2() {
            // TODO: write your solution here
            int result = 0;

            return result.ToString();
        }
    }
}
