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

namespace NRaas.DresserSpace.Options.Settings.Rotation
{
    public class AffectActiveSetting : BooleanSettingOption<GameObject>, IRotationOption
    {
        protected override bool Value
        {
            get
            {
                return Dresser.Settings.mRotationAffectActive;
            }
            set
            {
                Dresser.Settings.mRotationAffectActive = value;
            }
        }

        public override string GetTitlePrefix()
        {
            return "AffectActive";
        }

        public override ITitlePrefixOption ParentListingOption
        {
            get { return new ListingOption(); }
        }
    }
}
