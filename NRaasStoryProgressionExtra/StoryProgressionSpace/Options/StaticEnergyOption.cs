using NRaas.StoryProgressionSpace.Interfaces;
using NRaas.StoryProgressionSpace.Managers;
using NRaas.StoryProgressionSpace.Scenarios.Romances;
using Sims3.Gameplay.Actors;
using Sims3.Gameplay.Autonomy;
using Sims3.Gameplay.CAS;
using Sims3.Gameplay.Core;
using Sims3.Gameplay.UI;
using Sims3.Gameplay.Utilities;
using Sims3.SimIFace;
using Sims3.UI;
using System;
using System.Collections.Generic;

namespace NRaas.StoryProgressionSpace.Options
{
    public class StaticEnergyOption : StaticMotiveOption
    {
        public StaticEnergyOption()
        { }

        public override string GetTitlePrefix()
        {
            return "StaticEnergy";
        }

        public override bool ShouldDisplay()
        {
            if (Manager.SimDescription != null)
            {
                if (Manager.SimDescription.IsMummy) return false;
            }

            return base.ShouldDisplay();
        }
    }
}

