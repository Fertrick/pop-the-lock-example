using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CoinScript : MonoBehaviour
{
    bool checkCollision = false;

    // Update is called once per frame
    void Update()
    {
        if(checkCollision)
        {
            SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
        }
    }

    void OnCollisionExit2D(Collision2D col)
    {
        checkCollision = true;
    }
}
