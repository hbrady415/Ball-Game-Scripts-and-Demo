using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lastCollider : MonoBehaviour
{
    public Collider lastEntered;
    public Collider lastExited;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        lastEntered = other;
    }

    private void OnTriggerExit(Collider other)
    {
        lastExited = other;
    }
}
