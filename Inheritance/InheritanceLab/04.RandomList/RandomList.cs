namespace _04.RandomList
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class RandomList : ArrayList
    {
        private Random rnd;
        private List<string> list;

        public RandomList()
        {
            this.list = new List<string>();
        }

        public string RandomString()
        {
            var element = this.rnd.Next(0, this.list.Count - 1);
            var str = this.list[element];
            this.list.Remove(str);

            return str;
        }
    }
}