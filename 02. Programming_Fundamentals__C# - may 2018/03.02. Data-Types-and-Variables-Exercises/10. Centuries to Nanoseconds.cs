using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;

class test
{
    static void Main()
    {
        byte centuries = byte.Parse(Console.ReadLine());

        ushort years = (ushort)(centuries * 100);
        int days = (int)(years * 365.2422);
        int hours = days * 24;
        int min = hours * 60;
        long sec = min * 60L;
        long milisec = sec * 1000;
        BigInteger microsec = milisec * 1000;
        BigInteger nanosec = microsec * 1000;

        Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {min}" +
            $" minutes = {sec} seconds = {milisec} milliseconds = {microsec}" +
            $" microseconds = {nanosec} nanoseconds");
    }
}
