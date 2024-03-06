using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    public Transform objetoASeguir;

    // Update is called once per frame
    void Update()
    {
        transform.position = objetoASeguir.position;
    }
}
