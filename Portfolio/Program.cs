// <copyright file="Program.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Portfolio;

using Portfolio.Helpers;

/// <summary>
/// The main entry point for the Portfolio application.
/// </summary>
public class Program
{
    private static void Main(string[] args)
    {
        SortingHelper.BubbleSort([1, 4, 5, 7, 8, 9, 0, 23, 54, 3, 6]);
        SortingHelper.BubbleSortWhile([1, 4, 5, 7, 8, 9, 0, 23, 54, 3, 6]);
    }
}