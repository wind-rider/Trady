﻿using System;
using System.Collections.Generic;
using Trady.Analysis.Infrastructure;

namespace Trady.Analysis.Pattern.Candlestick
{
    /// <summary>
    /// Reference: http://stockcharts.com/school/doku.php?id=chart_school:chart_analysis:candlestick_pattern_dictionary
    /// </summary>
    public class UpsideGapTwoCrows : AnalyzableBase<(decimal Open, decimal High, decimal Low, decimal Close), bool?>
    {
        public UpsideGapTwoCrows(IList<(decimal Open, decimal High, decimal Low, decimal Close)> inputs) : base(inputs)
        {
        }

        protected override bool? ComputeByIndexImpl(int index)
        {
            throw new NotImplementedException();
        }
    }
}