using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Extract : MonoBehaviour
{
    bool inZone = false;
    public bool extrct = false;
    public GameObject otherDummy;
    public GameObject dummy;
    public GameObject particles;

    void OnTriggerStay(Collider other)
    {
        //Debug.Log("inZone");
        if (other.tag == "Dummy")
        {
            inZone = true;
        }

        Debug.Log("zone" + inZone);
    }

    void OnTriggerExit(Collider other){
        if (other.tag == "Dummy")
        {
            inZone = false;
            Debug.Log("zone" + inZone);
        }
    }

    public void CheckDroppedInZone()
    {
        Debug.Log("CHECK");
        if(inZone == true)
        {
            Debug.Log("IN");
            extrct = true;
            otherDummy.transform.position = dummy.transform.position;
            otherDummy.transform.rotation = dummy.transform.rotation;

            otherDummy.SetActive(true);
            dummy.SetActive(false);
        }
    }

    public void ShowExtract()
    {
        particles.SetActive(true);
    }
    public void HideExtract()
    {
        particles.SetActive(false);
    }
}
