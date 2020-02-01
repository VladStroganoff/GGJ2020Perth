using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Relaxor : MonoBehaviour
{
    // Start is called before the first frame update

    public Slider slider;

    void Start()
    {
        Invoke("Relax", 30f);
    }


    // Update is called once per frame
    public void Relax()
    {
        BoxCollider[] allObjectsWithColliders = Object.FindObjectsOfType<BoxCollider>();

        MeshCollider[] allAllOthers = Object.FindObjectsOfType<MeshCollider>();

        foreach (BoxCollider collider in allObjectsWithColliders)
        {
            if (collider.transform.name == "enviplane")
                return;

            if(collider.gameObject.GetComponent<Rigidbody>() != null)
            {
                Debug.Log(collider.gameObject.name + " should be updated");
                collider.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
            }
        }

        foreach (MeshCollider collider in allAllOthers)
        {
            if (collider.transform.name == "enviplane")
                return;

            if (collider.gameObject.GetComponent<Rigidbody>() != null)
            {
                Debug.Log(collider.gameObject.name + " should be updated");
                collider.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
            }
        }
    }
}
