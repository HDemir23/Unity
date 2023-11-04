using System.Collections;
using System.Collections.Generic;
using Palmmedia.ReportGenerator.Core.Parser.Analysis;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{

    private Vector3 startPos;
    private float bgRepeatLength;
    // Start is called before the first frame update
    void Start()
    {

        startPos = transform.position;
        bgRepeatLength = GetComponent<BoxCollider>().size.x / 2;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < startPos.x - bgRepeatLength)
        {
            transform.position = startPos;
        }
    }
}
