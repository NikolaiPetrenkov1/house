using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Dom
{
    class House : IPart
    {
        string str = "ДомПостроен!";
        public string house()
        {
            return str;
        }
    }
    interface IPart
    {
        string house();
    }
    class Basement : IPart
    {
        string str;
        public string basement()
        {
            return "==========";
        }
    }
    class Walls : IPart
    {
        string str;
        public string walls()
        {
            return "|\n|\n|\n";
        }
    }
    class Door : IPart
    {
        string str;
        public string door()
        {
            return "===\n|\t|\n===";
        }
    }
    class Window : IPart
    {
        string str;
        public string window()
        {
            return "---\n|\t|\n---";
        }
    }
    class Roof : IPart
    {
        string str;
        public string roof()
        {
            return "-----------";
        }
    }
    class Worker : IWorker
    {

    }
    class TeamLeader : IWorker
    {

    }
    class Team : IWorker
    {

    }
    interface IWorker
    {

    }
    interface IPart
    {
        string house();
        string basement();
        string walls();
        string door();
        string window();
        string roof();
    }
    class Program
    {
        static void Main()
        {
            Basement A = new Basement();
            A.basement();
        }
    }
}
