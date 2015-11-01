using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Core
{
    /*
     * Given a set of non-overlapping intervals, insert a new interval into the intervals (merge if necessary).
     * You may assume that the intervals were initially sorted according to their start times.
     * 
     * Example 1:
     * Given intervals [1,3],[6,9], insert and merge [2,5] in as [1,5],[6,9].
     * 
     * Example 2:
     * Given [1,2],[3,5],[6,7],[8,10],[12,16], insert and merge [4,9] in as [1,2],[3,10],[12,16].
     * This is because the new interval [4,9] overlaps with [3,5],[6,7],[8,10].
     */
    public class OJ057_InsertInterval
    {
        public IList<Interval> Insert(IList<Interval> intervals, Interval newInterval)
        {
            IList<Interval> result = new List<Interval>();

            int i = 0;
            Interval current = null;
            for (; i < intervals.Count; i++)
            {
                current = intervals[i];
                if (newInterval.start <= current.end)
                    break;
                result.Add(current);
                current = intervals[i];
            }

            if (i == intervals.Count)
            {
                result.Add(newInterval);
                return result;
            }

            if(newInterval.end <= current.start)
            {
                current = newInterval;
            }
            else
            {
                current.start = Math.Min(current.start, newInterval.start);
                current.end = Math.Max(current.end, newInterval.end);
                i++;
            }

            for (; i < intervals.Count; i++)
            {
                Interval next = intervals[i];

                if (next.start > current.end)
                {
                    result.Add(current);
                    current = next;
                }
                else
                {
                    current.end = Math.Max(current.end, next.end);
                }
            }
            result.Add(current);
            return result;
        }
    }
}
