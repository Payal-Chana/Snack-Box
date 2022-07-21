using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionController : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Cassette")
        {
            Debug.Log("It works!");
            //SceneManager.LoadScene("Organisation");
        }
    }


}
