/* Author: Brian Calderon
*/

using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the Mindfulness Project.");

        GoalManager goalManager = new GoalManager();
        goalManager.Start();

    }
}