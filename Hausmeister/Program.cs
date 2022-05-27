using System;

class Program
{
    static bool InArray(int[] arr, int target)
    {
        foreach (int el in arr)
        {
            if (el == target)
            {
                return true;
            }
        }

        return false;
    }

    static void ShowListElements(List<int> ls)
    {
        Console.Write("die noch nicht vollständig ausgestattet Räume: { ");

        foreach (int el in ls)
        {
            if (el != ls.Last())
            {
                Console.Write(el + ", ");
            }
            else
            {
                Console.Write(el);
            }
        }

        Console.Write(" }");
    }

    static void AddElementToList(int[] allRooms, int[] suppliedRooms, List<int> rooms)
    {
        foreach (int room in allRooms)
        {
            bool isInArray = InArray(suppliedRooms, room);

            if (!isInArray)
            {
                rooms.Add(room);
            }
        }

    }

    static void Main(string[] args)
    {
        int[] suppliedRooms = { 101, 103, 147, 245, 246, 0, 0, 0, 0, 0, 0, 0 };
        int[] allRooms = { 101, 102, 103, 145, 146, 147, 201, 202, 203, 245, 246, 247};

        List<int> rooms = new();

        AddElementToList(allRooms, suppliedRooms, rooms);

        ShowListElements(rooms);

    }
}
