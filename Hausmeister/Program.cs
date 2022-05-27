using System;

class Program
{

    public static bool InArray(int[] arr, int target)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == target)
            {
                return true;
            }
        }
        return false;
    }

    static void Main(string[] args)
    {
        int[] suppliedRooms = { 101, 103, 147, 245, 246, 0, 0, 0, 0, 0, 0, 0 };
        int[] allRooms = { 101, 102, 103, 145, 146, 147, 201, 202, 203, 245, 246, 247};

        List<int> rooms = new List<int>();

        foreach(int room in allRooms)
        {
            bool isInArray = InArray(suppliedRooms, room);

            if(!isInArray)
            {
                rooms.Add(room);
            }
        }

        foreach(int ro in rooms)
        {
            Console.WriteLine(ro);
        }



    }
}
