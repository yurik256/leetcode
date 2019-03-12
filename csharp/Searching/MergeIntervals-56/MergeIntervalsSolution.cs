using System;
using System.Collections.Generic;
using System.Linq;

namespace Solutions.Searching
{
    // 56. Merge Intervals
    // https://leetcode.com/problems/merge-intervals/
    public class MergeIntervalsSolution
    {
        public IList<Interval> Merge(IList<Interval> intervals)
        {
            var intervalsList = new List<Interval>(intervals);
            intervalsList.Sort(CompareIntervalsByIntervalStart);


            if (intervalsList.Count == 1)
            {
                return intervals;
            }

            var result = new List<Interval>();

            for (var i = 0; i < intervalsList.Count; i++)
            {
                var currentInterval = intervalsList[i];
                if (result.Count > 0)
                {
                    var latestInterval = result[result.Count - 1];
                    if (OverlapsWith(latestInterval, currentInterval))
                    {
                        result[result.Count - 1].end = Math.Max(currentInterval.end, latestInterval.end);
                    }
                    else
                    {
                        result.Add(currentInterval);
                    }

                }
                else
                {
                    result.Add(currentInterval);
                }
            }

            return result;

        }

        private static int CompareIntervalsByIntervalStart(Interval x, Interval y)
        {
            if (x.start == y.start)
            {
                return 0;
            }
            return (x.start < y.start) ? -1 : 1;
        }

        private bool OverlapsWith(Interval x, Interval y)
        {
            return x.end >= y.start;
        }
    }

    public class Interval
    {
        public int start;
        public int end;
        public Interval() { start = 0; end = 0; }
        public Interval(int s, int e) { start = s; end = e; }
    }
}