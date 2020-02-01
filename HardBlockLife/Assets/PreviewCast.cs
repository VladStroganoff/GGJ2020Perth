using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreviewCast : MonoBehaviour
{
    private Plane plane;
    public Camera myCamera;
    public float distanceFromCamera = 5f;
    public GameObject debugCube;

    // Start is called before the first frame update
    void Start()
    {
        if (!myCamera) Debug.LogError("No camera set on " + this.name);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 AbsoluteDistanceFromCamera = new Vector3(myCamera.transform.position.x, myCamera.transform.position.y, myCamera.transform.position.z - distanceFromCamera);
        plane = new Plane(myCamera.transform.forward, AbsoluteDistanceFromCamera);
    }

    public Vector3? RaycastOntoPreviewPlane()
    {
        Debug.Log("PreviewCasting");
        //Create a ray from the Mouse click position
        Ray ray = myCamera.ScreenPointToRay(Input.mousePosition);

        //Initialise the enter variable
        float enter = 0.0f;

        if (plane.Raycast(ray, out enter))
        {
            //Get the point that is clicked
            Vector3 hitPoint = ray.GetPoint(enter);

            //Move your cube GameObject to the point where you clicked
            if(debugCube)
            debugCube.transform.position = hitPoint;

            return hitPoint;
        }

        return null;
    }
}