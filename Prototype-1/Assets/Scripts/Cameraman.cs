using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameraman : MonoBehaviour
{
    public GameObject player1;
    private Vector3 offset = new Vector3(0, 8, 5);


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player1.transform.position + offset;
    }
}
