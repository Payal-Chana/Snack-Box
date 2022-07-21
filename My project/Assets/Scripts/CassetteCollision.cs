using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CassetteCollision : MonoBehaviour
{
    public bool isCollided = false;
    public GameObject CassetteSlot;
    public bool isTheme1Playing;
    public bool isTheme2Playing;
    public bool isTheme3Playing;
    public AudioSource Theme1Audio;
    public AudioSource Theme2Audio;
    public AudioSource Theme3Audio;

    private void Start()
    {
        isTheme1Playing = true;
    }

    private void Update()
    {
        if (isCollided == true)
        {
            this.gameObject.transform.position = CassetteSlot.transform.position;

            if (isTheme1Playing == true)
            {
                Theme1Audio.volume = 1f;;
                Theme2Audio.volume = 0f;
                Theme3Audio.volume = 0f;

            }
            else if (isTheme2Playing == true)
            {
                Theme1Audio.volume = 0f;;
                Theme2Audio.volume = 1f;
                Theme3Audio.volume = 0f;
            }
            else if (isTheme3Playing == true)
            {
                Theme1Audio.volume = 0f;;
                Theme2Audio.volume = 0f;
                Theme3Audio.volume = 1f;
            }
        }
        
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Cassette Player")
        {
            if (this.gameObject.name == "Theme Song 1")
            {
                isTheme1Playing = true;
                isTheme2Playing = false;
                isTheme3Playing = false;
            }
            else if (this.gameObject.name == "Theme Song 2")
            {
                isTheme1Playing = false;
                isTheme2Playing = true;
                isTheme3Playing = false;
            }
            else if (this.gameObject.name == "Theme Song 3")
            {
                isTheme1Playing = false;
                isTheme2Playing = false;
                isTheme3Playing = true;
            }
            
            isCollided = true;
        }
    }

}
