﻿using NRaas.CommonSpace.Booters;
using NRaas.CommonSpace.Helpers;
using Sims3.Gameplay;
using Sims3.Gameplay.Abstracts;
using Sims3.Gameplay.Actors;
using Sims3.Gameplay.ActorSystems;
using Sims3.Gameplay.Autonomy;
using Sims3.Gameplay.Core;
using Sims3.Gameplay.EventSystem;
using Sims3.Gameplay.Interactions;
using Sims3.Gameplay.Objects.Toys;
using Sims3.Gameplay.Skills;
using Sims3.Gameplay.Utilities;
using Sims3.SimIFace;
using Sims3.UI;
using Sims3.UI.Hud;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace NRaas.HybridSpace.Interactions
{
    public class SummonSharkEx : Common.IPreLoad, Common.IAddInteraction
    {
        static InteractionDefinition sOldSingleton;

        public void OnPreLoad()
        {
            Tunings.Inject<Sim, OccultMermaid.SummonShark.Definition, Definition>(false);

            sOldSingleton = OccultMermaid.SummonShark.Singleton;
            OccultMermaid.SummonShark.Singleton = new Definition();
        }

        public void AddInteraction(Common.InteractionInjectorList interactions)
        {
            interactions.Replace<Sim, OccultMermaid.SummonShark.Definition>(OccultMermaid.SummonShark.Singleton);
        }

        public class Definition : OccultMermaid.SummonShark.Definition
        {
            public Definition()
            { }

            public override string GetInteractionName(Sim actor, Sim target, InteractionObjectPair iop)
            {
                return base.GetInteractionName(actor, target, new InteractionObjectPair(sOldSingleton, target));
            }

            public override bool Test(Sim a, Sim target, bool isAutonomous, ref GreyedOutTooltipCallback greyedOutTooltipCallback)
            {
                if (!OccultTypeHelper.HasType(a, OccultTypes.Mermaid)) return false;

                return base.Test(a, target, isAutonomous, ref greyedOutTooltipCallback);
            }
        }
    }
}
