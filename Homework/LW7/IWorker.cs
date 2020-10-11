using System;
using System.Collections.Generic;
using System.Text;
namespace LW7
{
    public interface IWorker<T>
    {
        public void AddValueToList(T value);
        public int GetIndexByValue(T value);
    }
}