using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultithreadingDemo2
{
    public class threadDemo
    {
        
        public void First()
        {
            lock (this)
            {
                for (int i = 1; i <= 6; i++)
                {
                    Console.WriteLine(i);
                    Thread.Sleep(2000);
                }
            }

        }
       /* public void Second()
        {
            for (int i = 6; i <= 10; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(2000);
            }
        }*/
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            threadDemo first = new threadDemo();
            Thread t1 = new Thread(new ThreadStart(first.First));
            Thread t2=new Thread(new ThreadStart(first.First));
           // t2.Priority = ThreadPriority.Highest;
            //t1.Priority = ThreadPriority.AboveNormal;
            t1.Start();
           // t1.Join(1000);
            t2.Start();
            
            

        }
    }
}
