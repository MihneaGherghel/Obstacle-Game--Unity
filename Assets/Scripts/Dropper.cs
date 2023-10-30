using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    float timeToWait = 3f;
    MeshRenderer renderer;
    Rigidbody rigidBody;
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        rigidBody = GetComponent<Rigidbody>();

        renderer.enabled = false;
        rigidBody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > timeToWait)
        {
            renderer.enabled = true;
            rigidBody.useGravity = true;
        }
    }
}
