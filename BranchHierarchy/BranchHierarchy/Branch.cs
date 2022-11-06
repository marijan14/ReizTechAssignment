using System;
using System.Collections.Generic;

namespace BranchHierarchy
{
    internal class Branch
    {
        public Branch()
        {
        }

        public Branch(List<Branch> branches)
        {
            if (branches.Count == 0)
            {
                throw new InvalidOperationException($"{nameof(branches)} cannot be empty");
            }

            Branches = branches;
        }

        public List<Branch> Branches { get; set; }
    }
}
