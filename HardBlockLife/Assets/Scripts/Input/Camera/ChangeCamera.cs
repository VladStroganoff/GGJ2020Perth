using UnityEngine;
using UnityEngine.EventSystems;

public class ChangeCamera : MonoBehaviour
{
     public int CurrentCamera = 0;
     public int LastCamera = 3;
     public Camera[] CameraArray; 

     public void Rotate(int delta)
     {
          CurrentCamera += delta;
          if(CurrentCamera < 0)
               CurrentCamera = 3;
          if(CurrentCamera > 3)
               CurrentCamera = 0;
          EnableCamera(CurrentCamera);
     }

     public void Start()
     {
          EnableCamera(CurrentCamera);
     }

     public void EnableCamera(int cameraNumber)
     {
          CameraArray[LastCamera].GetComponent<Camera>().enabled = false;
          CameraArray[cameraNumber].GetComponent<Camera>().enabled = true;
          LastCamera = CurrentCamera;
     }
}