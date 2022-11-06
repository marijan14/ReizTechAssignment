using System;
using System.Collections.Generic;
using System.Linq;

namespace BranchHierarchy
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var sampleTree = new Branch 
            { 
                Branches = new List<Branch>
                {
                    new Branch(new List<Branch> { new Branch() }),
                    new Branch(
                        new List<Branch>
                        {
                            new Branch(new List<Branch> { new Branch() }),
                            new Branch(
                                new List<Branch>
                                {
                                    new Branch(new List<Branch> { new Branch() }),
                                    new Branch()
                                }),
                            new Branch()
                        })
                }
            };

            var depth = GetTreeDepth(sampleTree);
            Console.WriteLine($"The depth is: {depth}");
        }

        private static int GetTreeDepth(Branch tree)
        {
            static int GetTreeDepthInternal(List<Branch> branches, int depth = 1)
            {
                if (branches is null)
                {
                    return depth;
                }

                depth++;
                var results = new List<int>();
                foreach (var branch in branches)
                {
                    results.Add(GetTreeDepthInternal(branch.Branches, depth));
                }

                return results.Max();
            }

            return GetTreeDepthInternal(tree.Branches);
        }
    }
}
