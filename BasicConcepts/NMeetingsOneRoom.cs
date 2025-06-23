using System;
using System.Collections.Generic;

public class Meeting {
    public int start, end, index;
    public Meeting(int s, int e, int idx) {
        start = s;
        end = e;
        index = idx; // 1-based index
    }
}

public class NMeetingsOneRoom {
    // Comparator function to sort by end time
    public static int CompareMeetings(Meeting a, Meeting b) {
        return a.end.CompareTo(b.end);
    }

    public List<int> MaxMeetings(int[] start, int[] end)
    {
        int n = start.Length;
        List<Meeting> meetings = new List<Meeting>();
        List<int> selectedMeetings = new List<int>();

        for (int i = 0; i < n; i++)
        {
            // Using i + 1 as index to match 1-based indexing as in some interview questions
            meetings.Add(new Meeting(start[i], end[i], i + 1));
        }

        // Sort meetings by end time
        meetings.Sort(CompareMeetings);
        // meetings.Sort((a, b) => a.end.CompareTo(b.end)); //using lambda function

        int cnt = 0;
        int endTime = 0;

        foreach (var m in meetings)
        {
            if (m.start >= endTime)
            {
                selectedMeetings.Add(m.index); // Store the original index
                endTime = m.end;
                cnt++;
            }
        }

        return selectedMeetings;
        //return cnt; //if count is asked.
    }

    // Test
    public static void Main() {
        NMeetingsOneRoom sol = new NMeetingsOneRoom();
        int[] start = {1, 3, 0, 5, 8, 5};
        int[] end   = {2, 4, 6, 7, 9, 9};
        List<int> result = sol.MaxMeetings(start, end);
        Console.WriteLine("Meetings that can be scheduled (by original index):");
        foreach (int idx in result) {
            Console.Write(idx + " ");
        }
    }
}