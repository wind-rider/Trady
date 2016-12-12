﻿using Trady.Analysis.Indicator;
using Trady.Analysis.Pattern.Helper;
using Trady.Core;

namespace Trady.Analysis.Pattern.Indicator
{
    public class MovingAverageConvergenceDivergenceCrossover : AnalyticBase<IsMatchedMultistateResult<Trend?>>
    {
        private MovingAverageConvergenceDivergence _macdIndicator;

        public MovingAverageConvergenceDivergenceCrossover(Equity equity, int emaPeriodCount1, int emaPeriodCount2, int demPeriodCount) : base(equity)
        {
            _macdIndicator = new MovingAverageConvergenceDivergence(equity, emaPeriodCount1, emaPeriodCount2, demPeriodCount);
        }

        public override IsMatchedMultistateResult<Trend?> ComputeByIndex(int index)
        {
            if (index < 1)
                return new IsMatchedMultistateResult<Trend?>(Equity[index].DateTime, null, null);

            var latest = _macdIndicator.ComputeByIndex(index);
            var secondLatest = _macdIndicator.ComputeByIndex(index - 1);

            return new IsMatchedMultistateResult<Trend?>(Equity[index].DateTime, 
                ResultExt.IsCrossOver(latest.Osc, secondLatest.Osc), ResultExt.IsTrending(latest.Osc));
        }
    }
}