namespace DataStructuresTutorials.Arrays
{
    public class Array
    {
        private int Capacity;
        private int count;
        private int[] items;

        public Array(int capacity)
        {
            count = 0;
            Capacity = capacity;
            items = new int[Capacity];
        }

        public void RemoveAt(int index)
        {
            if (index > Capacity || index >= count) return;

            for(int i = index; i<count; i++)
            {
                items[i] = items[i + 1];
            }
            count--;
        }

        public void Insert(int item)
        {
            if(count == Capacity)
            {
                int[] newItems = new int[Capacity * 2];
                count = 0;
                for(int i = 0; i<items.Length; i++)
                {
                    newItems[i] = items[i];
                    count++;
                }

                items = newItems;
                items[count++] = item;
                Capacity = Capacity * 2;
                return;
            }

            items[count++] = item;
        }

        public int IndexOf(int item)
        {
            for(int i = 0; i<items.Length; i++)
            {
                if (items[i] == item) return i;
            }
            return -1;
        }

        public void Print()
        {
            for(int i = 0; i<count; i++)
            {
                System.Console.WriteLine(items[i]);
            }
        }
    }
}
