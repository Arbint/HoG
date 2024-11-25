using UnityEngine;

public static class GameplayStatics 
{
    private static GameObject _earth;
    private static Walkman _walkMan; 

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
}
