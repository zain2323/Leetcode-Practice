namespace Leetcode_Practice
{
    class DynamicArray
    {
        private int[] arr;
        private int length;
        private int capacity;

        public DynamicArray(int capacity)
        {
            if (capacity <= 0) throw new Exception("Capacity must be greater than 0");
            this.capacity = capacity;
            this.arr = new int[capacity];
            this.length = 0;
        }

        public int get(int i)
        {
            return arr[i];
        }

        public void insert(int i, int n)
        {
            arr[i] = n;
            length++;
        }

        public void pushback(int n)
        {
            if (length == capacity)
            {
                resize();
            }
            arr[length] = n;
            length++;
        }

        public int popback()
        {
            int el = arr[length];
            length--;
            return el;
        }

        private void resize()
        {
            int[] newArr = new int[2 * capacity];
            for (int i = 0; i < length; i++)
            {
                newArr[i] = arr[i];
            }
            this.arr = newArr;
        }

        public int getSize()
        {
            return this.length;
        }

        public int getCapacity()
        {
            return this.capacity;
        }
    }
}
