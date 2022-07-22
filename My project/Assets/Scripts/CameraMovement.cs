using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public GameObject theCamera;
    public GameObject startPos;
    public GameObject endPos;
    public float speed = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        theCamera.transform.position = startPos.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, endPos.transform.position, speed * Time.deltaTime);
        

        if (theCamera.transform.position == endPos.transform.position)
        {
            theCamera.transform.position = startPos.transform.position;
        }
    }
}
