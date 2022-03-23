using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArrayImplementation.Repository
{
    public class ArrayRepo : IArrayRepo
    {
        private List<int> _arr;

        public ArrayRepo()
        {
            _arr = new List<int>();
        }

        public string AddElements(List<int> item)
        {
            _arr.AddRange(item);
            return this.ToString();
        }

        public override string ToString()
        {
            string temp = "";
            for (int i = 0; i < _arr.Count; i++)
            {
                temp += _arr[i] + " ";
            }
            return temp + "";
        }
    }
}
