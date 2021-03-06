﻿using NRaas.CommonSpace.Options;
using NRaas.OverwatchSpace.Interfaces;
using NRaas.OverwatchSpace.Loadup;
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

namespace NRaas.OverwatchSpace.Settings
{
    public class CompressFamilyLevelSetting : IntegerOption
    {
        public override string GetTitlePrefix()
        {
            return "CompressFamilyLevelSetting";
        }

        protected override bool Allow(GameHitParameters<GameObject> parameters)
        {
            if (!Common.kDebugging) return false;

            return base.Allow(parameters);
        }

        public override ITitlePrefixOption ParentListingOption
        {
            get { return new NRaas.OverwatchSpace.Settings.ListingOption(); }
        }

        protected override int Value
        {
            get
            {
                return NRaas.Overwatch.Settings.mCompressFamilyLevel;
            }
            set
            {
                NRaas.Overwatch.Settings.mCompressFamilyLevel = value;
            }
        }
    }
}
