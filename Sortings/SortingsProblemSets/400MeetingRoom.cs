using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SortingsProblemSets
{
    public class MeetingRoom
    {
        public static bool FindIfAPersonCanAttendAllTheMeeting(List<int[]> arr)
        {
            arr = arr.OrderBy(x => x[0]).ThenBy(y=> y[1]).ToList();

            for (int i = 0; i < arr.Count() -1 -1; i++)
            {
                var start = arr[i];
                var next = arr[i + 1];
                if (start[1] > next[0])
                    return false;
            }
            return true;
        }

        public static int FindHowManyMeetingRooms(List<int[]> arr)
        {
            if (arr == null)
                return 0;

            arr = arr.OrderBy(x => x[0]).ThenBy(y => y[1]).ToList();
            int count = 1;
            for (int i = 0; i < arr.Count() - 1 - 1; i++)
            {
                var start = arr[i];
                var next = arr[i + 1];
                if (start[1] > next[0])
                {
                    count++;
                }
            }
            return count;
        }
    }
}
