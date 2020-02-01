using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct Vector3Int
{

    public int x;
    public int y;
    public int z;


    public Vector3Int(int _x, int _y, int _z)
    {
        x = _x;
        y = _y;
        z = _z;
    }

    public Vector3Int(Vector3 vector)
    {
        x = Mathf.RoundToInt(vector.x);
        y = Mathf.RoundToInt(vector.y);
        z = Mathf.RoundToInt(vector.z);
    }

}
