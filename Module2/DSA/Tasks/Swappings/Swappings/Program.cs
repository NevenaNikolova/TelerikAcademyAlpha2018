using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Swappings
{
    class Program
    {   
        // [1 2] 3 [4 5 6] -> [4 5 6] 3 [1 2]
        class ListNode : IEnumerable<int>
        {
            private int value;
            public ListNode Left { get; private set; }
            public ListNode Right { get; private set; }
            
            public ListNode(int v)
            {
                this.value = v;
                this.Left = null;
                this.Right = null;
            }
            public void Link(ListNode r)
            {
                Right = r;
                r.Left = this;
            }
            public void Detach()
            {
                if (this.Left != null)
                {
                    this.Left.Right = null;
                }
                if (this.Right != null)
                {
                    this.Right.Left = null;
                }
                this.Left = null;
                this.Right = null;
            }

            public IEnumerator<int> GetEnumerator()
            {
                var node = this;
                while (node != null)
                {
                    yield return node.value;
                    node = node.Right;
                }
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var nodes = Enumerable.Range(0, n + 1)
                .Select(x => new ListNode(x))
                .ToArray();

            for (int i = 1; i < n; i++)
            {
                nodes[i].Link(nodes[i + 1]);
            }

            var first = nodes[1];
            var last = nodes[n];

            Console.ReadLine()
                  .Split()
                  .Select(int.Parse)
                  .ToList()
                  .ForEach(num =>
                  {
                      var newLast = nodes[num].Left;
                      var newFirst = nodes[num].Right;

                      nodes[num].Detach();

                      if (first != nodes[num])
                      {
                          nodes[num].Link(first);
                      }
                      else
                      {
                          newLast = nodes[num];
                      }

                      if (last != nodes[num])
                      {
                          last.Link(nodes[num]);
                      }
                      else
                      {
                          newFirst = nodes[num];
                      }
                      first = newFirst;
                      last = newLast;
                  });
            Console.WriteLine(string.Join(" ", first));
        }
    }
}
