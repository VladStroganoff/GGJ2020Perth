using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WillBreakOnStart : MonoBehaviour
{
    public void Start()
    {
        Break();
    }
    public void Break()
    {
        var rigidBody = gameObject.AddComponent<Rigidbody>();
        rigidBody.AddExplosionForce(500f, transform.parent.transform.position, 1000f);
        Time.

    }
}
