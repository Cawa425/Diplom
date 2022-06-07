using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class UsableByRange : MonoBehaviour
{
    public GameObject objectFromHide;
    public GameObject objectToHide;
    public float hideDistance;
    
    private void Update()
    {
        objectToHide.SetActive(Vector3.Distance(objectFromHide.transform.position, objectToHide.transform.position) <
                               hideDistance);
    }
}
