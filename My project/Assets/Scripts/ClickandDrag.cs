using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickandDrag : MonoBehaviour
{
    public bool isCollided = false;
    private Vector3 mOffset;
    private float mZCoord;
    public GameObject CassetteSlot;
    public AudioSource CassetteTheme1;

    private void Update()
    {
        if (isCollided == true)
        {
            this.gameObject.transform.position = CassetteSlot.transform.position;
        }
    }
    private void OnMouseDown()
    {
        mZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;

        //mOffset = gameObject world pos - OnMouseDown world pos
        mOffset = gameObject.transform.position - GetMouseWorldPos();
    }

    private void OnMouseDrag()
    {
        transform.position = GetMouseWorldPos() + mOffset;
    }

    private Vector3 GetMouseWorldPos()
    {
        //pixel coordinates (x,y)
        Vector3 mousePoint = Input.mousePosition;

        //z coordinate of game object of screen
        mousePoint.z = mZCoord;

        return Camera.main.ScreenToWorldPoint(mousePoint);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Cassette Player")
        {
            isCollided = true;
            CassetteTheme1.Play();
            //this.gameObject.transform.position = CassetteSlot.transform.position;
            Debug.Log("It works!");
            //SceneManager.LoadScene("Organisation");
        }
    }

}
