using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public static class GameplayStatics 
{
    private static GameObject _earth;
    private static Walkman _walkMan;
    private static Player _player;

    public static GameObject GetEarth()
    {
        if(_earth == null)
        {
            _earth = GameObject.FindGameObjectWithTag("Earth");
        }

        return _earth;
    }

    public static Walkman GetWalkman()
    {
        if(_walkMan == null)
        {
            _walkMan = GameObject.FindFirstObjectByType<Walkman>();
        }

        return _walkMan;
    }

    internal static Player GetPlayer()
    {
        if(_player == null)
        {
            _player = GameObject.FindFirstObjectByType<Player>();
        }

        return _player;
    }
}
