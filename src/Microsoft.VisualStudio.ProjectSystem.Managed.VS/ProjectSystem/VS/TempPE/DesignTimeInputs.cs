﻿// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using System.Collections.Generic;
using System.Collections.Immutable;

namespace Microsoft.VisualStudio.ProjectSystem.VS.TempPE
{
    internal class DesignTimeInputs
    {
        public readonly ImmutableHashSet<string> Inputs;
        public readonly ImmutableHashSet<string> SharedInputs;

        public DesignTimeInputs(IEnumerable<string> inputs, IEnumerable<string> sharedInputs)
        {
            Inputs = ImmutableHashSet.CreateRange(StringComparers.Paths, inputs);
            SharedInputs = ImmutableHashSet.CreateRange(StringComparers.Paths, sharedInputs);
        }
    }
}
