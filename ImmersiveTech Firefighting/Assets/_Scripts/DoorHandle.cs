using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorHandle : MonoBehaviour
{
    public Transform target;
    Rigidbody rb;
    Rigidbody rbdoor;
    public GameObject grabbableHandle;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        rbdoor = grabbableHandle.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.MovePosition(target.transform.position);
    }

    public void HandleUngrabbed()
    {
        rbdoor.velocity = new Vector3 (0,0,0);
        grabbableHandle.transform.position = this.transform.position;
    }
}
