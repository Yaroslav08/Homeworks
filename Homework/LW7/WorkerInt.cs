using System;
using System.Collections.Generic;
using System.Text;
namespace LW7
{
    public class WorkerInt : IWorker<int>
    {
        private List<int> listOfInts;

        public WorkerInt()
        {
            listOfInts = new List<int>();
        }

        public WorkerInt(List<int> ints)
        {
            if (ints == null || ints.Count == 0)
                throw new ArgumentNullException($"{nameof(ints)} can`t be null");
            listOfInts = ints;
        }

        public List<int> Ints => listOfInts;

        public void AddValueToList(int value)
        {
            listOfInts.Add(value);
        }

        public int GetIndexByValue(int value)
        {
            return listOfInts.IndexOf(value);
        }
    }
}