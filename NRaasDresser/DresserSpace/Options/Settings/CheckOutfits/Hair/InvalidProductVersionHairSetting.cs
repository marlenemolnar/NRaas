﻿using NRaas.CommonSpace.Options;
using Sims3.Gameplay.Abstracts;
using Sims3.Gameplay.Actors;
using Sims3.Gameplay.Autonomy;
using Sims3.Gameplay.CAS;
using Sims3.Gameplay.Interactions;
using Sims3.Gameplay.Utilities;
using Sims3.SimIFace;
using Sims3.SimIFace.CAS;
using System;
using System.Collections.Generic;
using System.Text;

namespace NRaas.DresserSpace.Options.Settings.CheckOutfits.Hair
{
    public class InvalidProductVersionSetting : ProductVersionSetting<GameObject>, IHairOption
    {
        protected override Proxy GetList()
        {
            return new ListProxy(Dresser.Settings.mInvalidProductVersionHair);
        }

        public override string GetTitlePrefix()
        {
            return "InvalidProductVersionHair";
        }

        public override ITitlePrefixOption ParentListingOption
        {
            get { return new ListingOption(); }
        }
    }
}
