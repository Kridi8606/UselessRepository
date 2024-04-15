using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public static class Direction
{
    public static readonly Vector2Int Up = new Vector2Int(0, 1);
    public static readonly Vector2Int Down = new Vector2Int(0, -1);
    public static readonly Vector2Int Left = new Vector2Int(-1, 0);
    public static readonly Vector2Int Right = new Vector2Int(1, 0);

    public static bool IsBasic(this Vector2Int direction)
    {
        if (direction == Up || direction == Down || direction == Left || direction == Right)
        {
            return true;
        }
        return false;
    }
}
