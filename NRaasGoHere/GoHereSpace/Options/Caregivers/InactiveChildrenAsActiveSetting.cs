﻿using NRaas.CommonSpace.Options;
using Sims3.Gameplay.Abstracts;
using Sims3.Gameplay.Actors;
using Sims3.Gameplay.Autonomy;
using Sims3.Gameplay.CAS;
using Sims3.Gameplay.Interactions;
using Sims3.Gameplay.Utilities;
using Sims3.SimIFace;
using System;
using System.Collections.Generic;
using System.Text;

namespace NRaas.GoHereSpace.Options.Caregivers
{
    public class InactiveChildrenAsActiveSetting : BooleanSettingOption<GameObject>, ICaregiversOption
    {
        protected override bool Value
        {
            get
            {
                return GoHere.Settings.mInactiveChildrenAsActive;
            }
            set
            {
                GoHere.Settings.mInactiveChildrenAsActive = value;
            }
        }

        public override string GetTitlePrefix()
        {
            return "InactiveChildrenAsActive";
        }

        public override ITitlePrefixOption ParentListingOption
        {
            get { return null; } // Legacy Requirement new ListingOption(); }
        }
    }
}
