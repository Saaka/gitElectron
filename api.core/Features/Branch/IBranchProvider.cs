﻿using System.Collections.Generic;

namespace Core.Features.Branch
{
    public interface IBranchProvider
    {
        void Create(string branchName);

        IEnumerable<Branch> GetAllBranches();
    }
}
