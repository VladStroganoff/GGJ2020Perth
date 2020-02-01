using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneCheck : MonoBehaviour
{
    private Plane negZPlane = new Plane(Vector3.back, new Vector3(0,0,0));
    private Plane posZPlane = new Plane(Vector3.back, new Vector3(0, 0, 0));
    private Plane negXPlane = new Plane(Vector3.back, new Vector3(0, 0, 0));
    private Plane posXPlane = new Plane(Vector3.back, new Vector3(0, 0, 0));
    private Plane plane = new Plane(Vector3.back, new Vector3(0, 0, 0));
    public GameObject debugCube;

    void Start()
    {
        
    }

    void ConstructPlane(Vector3 inNormal, Vector3 inPoint)
    {
   //    Debug.pla
    }

    private void Update()
    {
        //Detect when there is a mouse click
        if (Input.GetMouseButton(0))
        {
            //Create a ray from the Mouse click position
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            //Initialise the enter variable
            float enter = 0.0f;

            if (plane.Raycast(ray, out enter))
            {
                //Get the point that is clicked
                Vector3 hitPoint = ray.GetPoint(enter);
                Debug.Log("hit at " + hitPoint);

                //Move your cube GameObject to the point where you clicked
                debugCube.transform.position = hitPoint;
            }
        }
    }
}
