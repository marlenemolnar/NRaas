﻿using NRaas.CommonSpace.Booters;
using NRaas.CommonSpace.Helpers;
using Sims3.Gameplay.Abstracts;
using Sims3.Gameplay.Interfaces;
using Sims3.Gameplay.Objects;
using Sims3.Gameplay.Utilities;
using Sims3.SimIFace;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace NRaas.ErrorTrapSpace.Dereferences
{
    public class DerefValidatePlacementDelegate : Dereference<ValidatePlacementDelegate>
    {
        protected override DereferenceResult Perform(ValidatePlacementDelegate reference, FieldInfo field, List<ReferenceWrapper> objects)
        {
            return DereferenceResult.Continue;
        }
    }
}
