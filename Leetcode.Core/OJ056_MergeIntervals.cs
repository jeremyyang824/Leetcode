using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Core
{
    /*
     * Given a collection of intervals, merge all overlapping intervals.
     * For example,
     * Given [1,3],[2,6],[8,10],[15,18],
     * return [1,6],[8,10],[15,18].
     */
    public class OJ056_MergeIntervals
    {
        public IList<Interval> Merge(IList<Interval> intervals)
        {
            Interval[] intervalArr = intervals.ToArray();
            Array.Sort(intervalArr, new Comparison<Interval>(comparerInterval));

            if (intervalArr.Length < 1)
                return intervalArr;

            IList<Interval> result = new List<Interval>();
            Interval current = intervalArr[0];
            for (int i = 1; i < intervalArr.Length; i++)
            {
                Interval next = intervalArr[i];

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

        private int comparerInterval(Interval a, Interval b)
        {
            if (a.start > b.start)
                return 1;
            else if (a.start < b.start)
                return -1;
            else
                return 0;
        }
    }

    public class Interval
    {
        public int start;
        public int end;
        public Interval() { start = 0; end = 0; }
        public Interval(int s, int e) { start = s; end = e; }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            if (System.Object.ReferenceEquals(this, obj))
                return true;

            Interval other = obj as Interval;
            if (other == null)
                return false;

            return (this.start == other.start) && (this.end == other.end);
        }

        public override int GetHashCode()
        {
            return start ^ end;
        }

        public static bool operator ==(Interval a, Interval b)
        {
            if (((object)a == null) || ((object)b == null))
                return false;
            return a.Equals(b);
        }

        public static bool operator !=(Interval a, Interval b)
        {
            return !(a == b);
        }
    }
}
