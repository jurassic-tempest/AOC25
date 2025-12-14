using System.Collections.Immutable;
using AOC25;
using Microsoft.VisualBasic;

namespace AOC.Solutions {
    public class Day07 : IDay {
        private readonly string[] input;

        public Day07() {
            input = Utils.ReadInput(7); 
        }

        public string Part1() {
            long result = 0;
            List<List<int>> beamIndices = new List<List<int>>();
            var maxIndex = input.First().Length;
            Console.WriteLine($"maxIndex: {maxIndex}");

            foreach (var line in input)
            {
                if (line.Contains('S'))
                {
                    Console.WriteLine($"index of S: {line.IndexOf('S')}");
                    beamIndices.Add(new List<int> {line.IndexOf('S') + 1});
                    continue;
                }
                if (!line.Contains('^')) continue;

                List<int> splitterIndices = new List<int>();
                for (int i = 0; i < line.Length; i++)
                {
                    if (line[i] == '^')
                    {
                        splitterIndices.Add(i+1);
                    }
                }
                // compare splitter and latestbeamIndices
                var latestBeamIndices = beamIndices.Last();
                var newBeamIndices = new List<int>();
                foreach(var i in latestBeamIndices)
                {
                    if (splitterIndices.Contains(i))
                    {
                        result++;
                        if ((i - 1) > 0) newBeamIndices.Add(i - 1);
                        if ((i + 1) < maxIndex) newBeamIndices.Add(i+1);
                    }
                    else
                    {
                        newBeamIndices.Add(i);
                    }
                }
                
                beamIndices.Add(newBeamIndices.Distinct().ToList());
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
