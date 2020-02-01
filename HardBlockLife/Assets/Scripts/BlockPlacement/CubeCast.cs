using UnityEngine;

public class CubeCast : MonoBehaviour
{

    public GameObject debugCube;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            GetCubeCoordinates();
        }
    }

    private void GetCubeCoordinates()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            Vector3 hitPoint = ray.GetPoint(hit.distance);
            Debug.Log(hitPoint);
            Debug.Log(hit.collider.gameObject);

            if(debugCube)
                debugCube.transform.position = hitPoint;
        }
    }
}
