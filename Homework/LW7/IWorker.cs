using System;
using System.Collections.Generic;
using System.Text;
namespace LW7
{
    public interface IWorker<T>
    {
        void AddValueToList(T value);
        int GetIndexByValue(T value);
    }
}