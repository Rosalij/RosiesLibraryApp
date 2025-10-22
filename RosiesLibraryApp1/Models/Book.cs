﻿namespace RosiesLibraryApp.Models;

public class Book
{
    public int Id { get; set; }
    public string Title { get; set; } = "";
    public string Author { get; set; } = "";
    public string ISBN { get; set; } = "";
    public int Year { get; set; }
    public int Copies { get; set; } = 1;
}