using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class hari : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="Player")
        {
            Destroy(collision.gameObject, 0.1f);
            SceneManager.LoadScene("ステージ１");
        }
        else if(transform.position.y<-8)
        {
            SceneManager.LoadScene("ステージ１");
        }
    }
}
