﻿namespace ConsoleApp1;

public struct Point
{
    private int _x;
    private int _y;
    
    public int X
    {
        get => _x;
        set => _x = value;
    }

    public int Y
    {
        get => _y;
        set => _y = value;
    }

   
    public Point(int x, int y)
    {
        _x = x;
        _y = y;
    }

    public override string ToString()
    {
        return $"x:{_x} y:{_y}";
    }
}