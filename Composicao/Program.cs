﻿using System;
using Composicao.Entities;

namespace Composicao
{
    class Program
    {
        static void Main(string[] args)
        {
            Comment c1 = new Comment("Have a nice trip");
            Comment c2 = new Comment("Wow that's awesome!");

            Post p1 = new Post(
                DateTime.Parse("21/06/2018 13:05:44"),
                "Traveling to new Zealand",
                "I'm  going to visit this wonderfull country!",
                12
                );
            p1.AddComment(c1);
            p1.AddComment(c2);

            Comment c3 = new Comment("Good nigth");
            Comment c4 = new Comment("May the Force be with you");

            Post p2 = new Post(
                DateTime.Parse("28/06/2018 23:14:19"),
                "Good nigth guys",
                "See you tomorrow",
                5
                );
            p1.AddComment(c1);
            p1.AddComment(c2);

            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }
    }
}
