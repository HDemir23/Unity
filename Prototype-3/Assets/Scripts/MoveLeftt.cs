using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeftt : MonoBehaviour
{
    private PlayerController playerControllerScript;
    private float speed = 20;
    private float leftBound = -15;
    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {


        if (playerControllerScript.gameOver == false)
        {
            if (playerControllerScript.dash)
            {
                transform.Translate(Vector3.left * Time.deltaTime * 40);
            }
            else
            {
                transform.Translate(Vector3.left * Time.deltaTime * speed);
            }
        }

        if (transform.position.x < leftBound && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }

    }
}
