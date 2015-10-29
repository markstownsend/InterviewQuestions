using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace Path
{
    public class Pathc
    {
        public string CurrentPath { get; private set; }

        private class PathQueue
        {
            private Stack<String> _stack;
            public PathQueue() { _stack = new Stack<string>(); }

            public void Add(string toAddOrRemove)
            {
                if (String.IsNullOrEmpty(toAddOrRemove)) return;
                if(toAddOrRemove == "..")
                {
                    try
                    {
                        string result = _stack.Pop();
                        if (_stack.Count == 0) _stack.Push("/"); // put the root back
                    }
                        catch (Exception )
                        {
                            // put the root back at the start of the stack
                            _stack.Push("/");
                        }
                } else
                {
                    // don't push a duplicate
                    try {
                        if (_stack.Peek() != toAddOrRemove)
                            _stack.Push(toAddOrRemove);
                    }
                    catch (InvalidOperationException)
                    {
                        _stack.Push(toAddOrRemove);
                    }
                }
            }

            public override string ToString()
            {
                var current = _stack.ToArray();
                StringBuilder sb = new StringBuilder();
                for (int i = current.Length -1; i > 0; i--)
                {
                    sb.Append(current[i]);
                }
                return sb.ToString();
            }
        }

        private PathQueue _pq = new PathQueue();

        public Pathc(string path)
        {
            Cd(path);

        }

        public Pathc Cd(string newPath)
        {
            if (newPath.Contains("/"))
            {
                var steps = newPath.Split('/');
                foreach(string step in steps)
                {
                    _pq.Add("/");
                    _pq.Add(step);
                }
            }
            else
            {
                // single operation
                _pq.Add(newPath);
            }
            this.CurrentPath = _pq.ToString();
            return this;
        }

        public static void Main(string[] args)
        {
            Pathc path = new Pathc("/a/b/c/d");
            Console.WriteLine(path.Cd("../x").CurrentPath);
        }
    }
}
