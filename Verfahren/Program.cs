// See https://aka.ms/new-console-template for more information
using System.Diagnostics;
using Verfahren.Reihen;

var time = new Stopwatch();
time.Start();
double res = HeronVerfahren.Heron(6, 3, 5);
time.Stop();

Console.WriteLine(res+ " in " + time.ElapsedMilliseconds.ToString() +" seconds");
