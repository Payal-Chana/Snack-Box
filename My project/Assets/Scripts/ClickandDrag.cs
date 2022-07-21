using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ClickandDrag : MonoBehaviour
{
    private Vector3 mOffset;
    private float mZCoord;

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

}
