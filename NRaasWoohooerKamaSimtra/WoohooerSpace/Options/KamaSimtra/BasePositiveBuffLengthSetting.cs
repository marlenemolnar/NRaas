﻿using NRaas.CommonSpace.Options;
using NRaas.WoohooerSpace.Skills;
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

namespace NRaas.WoohooerSpace.Options.KamaSimtra
{
    public class BasePositiveBuffLengthSetting : IntegerSettingOption<GameObject>, IKamaSimtraOption
    {
        protected override int Value
        {
            get
            {
                return Skills.KamaSimtra.Settings.mBasePositiveBuffLength;
            }
            set
            {
                Skills.KamaSimtra.Settings.mBasePositiveBuffLength = value;
            }
        }

        public override string GetTitlePrefix()
        {
            return "BasePositiveBuffLength";
        }

        public override ITitlePrefixOption ParentListingOption
        {
            get { return new ListingOption(); }
        }
    }
}
