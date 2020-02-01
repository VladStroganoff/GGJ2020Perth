using UnityEngine;

internal class BrickPlacement
{
    public float XPosition, YPosition, ZPosition, XRotation, YRotation, ZRotation;
    public BrickPlacement()
    {
        XPosition = YPosition = ZPosition = XRotation = YRotation = ZRotation = 0f;
    }
    public BrickPlacement(float xpos, float ypos, float zpos, float xrot, float yrot, float zrot)
    {
        XPosition = xpos;
        YPosition = ypos;
        ZPosition = zpos;
        XRotation = xrot;
        YRotation = yrot;
        ZRotation = zrot;
    }

    public Vector3 GetPostion()
    {
        return new Vector3(XPosition, YPosition, ZPosition);
    }

    public Vector3 GetRotationEuler()
    {
        return new Vector3(XRotation, YRotation, ZRotation);
    }
}