using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresTutorials
{
    public class StackWithArray
    {
        int originalCapacity;
        int[] items;
        int count;

        public StackWithArray(int originalCapacity)
        {
            this.originalCapacity = originalCapacity;
            items = new int[this.originalCapacity];
        }

        public void Push(int item)
        {
            if(count == this.originalCapacity)
            {
                int[] newItems = new int[this.originalCapacity * 2];
                Array.Copy(items, newItems, this.originalCapacity);
                
                this.originalCapacity = this.originalCapacity * 2;
                
                items = newItems;
            }
            
            items[count] = item;
            count++;
        }

        public int Pop()
        {
            if(count == 0)
            {
                throw new Exception("The stack is empty.");
            }

            var item = items[count-1];
            items[count - 1] = 0;
            count--;

            return item;
        }

        public int Peek()
        {
            if (count == 0)
            {
                throw new Exception("The stack is empty.");
            }

            return items[count - 1];
        }

        public bool IsEmpty()
        {
            return count == 0;
        }

        public override string ToString()
        {
            StringBuilder listOfItems = new StringBuilder();
            for(int i = 0; i<count; i++)
            {
                listOfItems.Append(items[i]);
            }

            return listOfItems.ToString();
        }
    }
}
