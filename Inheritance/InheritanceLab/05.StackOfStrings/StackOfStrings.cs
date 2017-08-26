namespace _05.StackOfString
{
    using System.Collections.Generic;
    using System.Linq;

    public class StackOfStrings
    {
        private List<string> data;

        public void Push(string item)
        {
            this.data.Add(item);
        }

        public string Pop()
        {
            var item = this.data.Last();
            this.data.Remove(item);

            return item;
        }

        public string Peek()
        {
            var item = this.data.Last();

            return item;
        }

        public bool IsEmpty()
        {
            if (this.data.Count != 0)
            {
                return false;
            }

            return true;
        }
    }
}