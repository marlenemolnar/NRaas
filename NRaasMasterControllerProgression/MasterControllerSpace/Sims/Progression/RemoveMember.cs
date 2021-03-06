﻿extern alias SP;

using SimPersonality = SP::NRaas.StoryProgressionSpace.Personalities.SimPersonality;

using NRaas.CommonSpace.Helpers;
using NRaas.CommonSpace.Options;
using NRaas.CommonSpace.Selection;
using Sims3.Gameplay;
using Sims3.Gameplay.Abstracts;
using Sims3.Gameplay.Actors;
using Sims3.Gameplay.ActorSystems;
using Sims3.Gameplay.Autonomy;
using Sims3.Gameplay.CAS;
using Sims3.Gameplay.DreamsAndPromises;
using Sims3.Gameplay.Interactions;
using Sims3.Gameplay.Socializing;
using Sims3.Gameplay.Utilities;
using Sims3.SimIFace;
using Sims3.SimIFace.CAS;
using Sims3.UI;
using Sims3.UI.CAS;
using Sims3.UI.Hud;
using System;
using System.Collections.Generic;
using System.Text;

namespace NRaas.MasterControllerSpace.Sims.Progression
{
    public class RemoveMember : PersonalityBase
    {
        protected override int GetMaxSelection()
        {
            return 0;
        }

        protected override bool IsLeader
        {
            get { return false; }
        }

        protected override bool AutoApplyAll()
        {
            return true;
        }

        protected override bool CanApplyAll()
        {
            return true;
        }

        protected override bool Allow(SimDescription me, SimPersonality personality)
        {
            if (personality.Me == me) return false;

            return personality.IsMember(me);
        }

        protected override bool Run(SimDescription me, SimPersonality personality)
        {
            if (!ApplyAll)
            {
                if (!AcceptCancelDialog.Show(Common.Localize("RemoveMember:Prompt", personality.IsFemaleLocalization(), me.IsFemale, new object[] { personality.GetLocalizedName(), me })))
                {
                    return false;
                }
            }

            personality.RemoveFromClan(me);
            return true;
        }

        public class ListingOption : PersonalityListing<RemoveMember>
        {
            public override string GetTitlePrefix()
            {
                return "RemoveMember";
            }

            public override ITitlePrefixOption ParentListingOption
            {
                get { return null; }
            }
        }
    }
}
