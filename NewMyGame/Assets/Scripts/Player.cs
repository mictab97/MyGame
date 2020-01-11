using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Transform myTransform;

    public int playerSpeed = 5;
    // Start is called before the first frame update
    void Start()
    {
        myTransform = transform;

        //spawn point
        //position to be at 0, -1.67, 0

        myTransform.position = new Vector3(0, -1.67f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        //move the player left and right
        myTransform.Translate(Vector3.right * playerSpeed * Input.GetAxis("Horizontal") * Time.deltaTime);
    }
    
}