using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ClockHandScript : MonoBehaviour
{
    [SerializeField] GameObject MainObject;
    MainScript mainScript;
    GameObject CoinTouched;
    bool CheckDirection = false;
    bool GetPoint = false;
    public int RandomSpeedLimit = 30;
    public int RandomSpeed = 0;
    // Start is called before the first frame update
    void Start()
    {
        mainScript = MainObject.GetComponent<MainScript>();
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) 
        {
            CheckDirection = !CheckDirection;
            RandomSpeed = Random.Range(RandomSpeedLimit - 5, RandomSpeedLimit + 5);
            if(GetPoint)
            {
                Destroy(CoinTouched);
                mainScript.addScore();
            }
        }
        // Spin the object around the target at 20 degrees/second.
        if (!CheckDirection)
        {
            transform.RotateAround(MainObject.transform.position, Vector3.forward, RandomSpeed * Time.deltaTime);
        }
        else
        {
            transform.RotateAround(MainObject.transform.position, Vector3.back, RandomSpeed * Time.deltaTime);
        }

    }

    void OnCollisionEnter2D(Collision2D col)
    {
        GetPoint = true;
        CoinTouched = col.gameObject;
    }

    void OnCollisionExit2D(Collision2D col)
    {
        GetPoint = false;
    }
}
