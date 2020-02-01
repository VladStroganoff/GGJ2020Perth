using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Components : MonoBehaviour
{
    private bool set = false;
    public GameObject putDownFx;
    public AudioSource audioData;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     void OnCollisionEnter(Collision collision)
    {
        putDownFx = GameObject.Find("PutDownSound");
        audioData = putDownFx.GetComponent<AudioSource>();
        audioData.Play();

        foreach( Transform child in transform )
        if (child.gameObject.tag == "FX")
        {
        child.gameObject.SetActive( false );
        }
    }
}
