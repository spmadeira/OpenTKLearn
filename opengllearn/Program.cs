using System;

namespace opengllearn
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Window window = new(800, 600, "Window"))
            {
                window.Run(60.0);
            }
        }
    }
}