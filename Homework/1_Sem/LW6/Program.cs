using System;
using System.Threading;

namespace LW6
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new WorkData();
            data.Reverse(12453654);
            data.Reverse("Some string");
            data.Reverse(new string[] { "Some", "body", "was", "told", "me" });
            data.Reverse(1235.235);
        }
    }
}