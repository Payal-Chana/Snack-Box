using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CassetteSound : MonoBehaviour
{
    public bool isCollided = false;
    public GameObject CassetteSlot;
    public Animator CassetteAnim1;
    public Animator CassetteAnim2;
    public bool audioPlaying;
    
    private void Start()
    {
        CassetteAnim1.SetBool("isTurning", false);
        CassetteAnim2.SetBool("isTurning2", false);
    }
    
    private void Update()
    {
        if (isCollided == true)
        {
            this.gameObject.transform.position = CassetteSlot.transform.position;

        }
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Cassette Player")
        {
            //Sound for cassette player
            FindObjectOfType<MusicManager>().Play("CassettePlayer");
            isCollided = true;
            audioPlaying = true;
            CassetteAnim1.SetBool("isTurning", true);
            CassetteAnim2.SetBool("isTurning2", true);
            

            StartCoroutine("waitBeforeNextScene");
        }
    }

    IEnumerator waitBeforeNextScene()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("Organisation");
    }
}
