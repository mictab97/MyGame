using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public static int movespeed = 5;
    public Vector3 userDirection = Vector3.forward;
    // Start is called before the first frame update
    public void Start()
    {

    }

    // Update is called once per frame
    public void Update()
    {
        transform.Translate(Vector3.forward * movespeed * Time.deltaTime);
    }
}