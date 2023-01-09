using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockHandCloneScript : MonoBehaviour
{
    [SerializeField] GameObject CenterObject;
    [SerializeField] GameObject CoinObject;

    bool CheckDirection = false;
    public int RandomSpeedLimit = 40;
    public int RandomSpeed = 0;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(-1.698048f, 2.18849f, 0);
        Instantiate(CoinObject, transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(CoinObject, transform.position, transform.rotation);
            CheckDirection = !CheckDirection;
            RandomSpeed = Random.Range(RandomSpeedLimit - 25, RandomSpeedLimit);
        }
        // Spin the object around the target at 20 degrees/second.
        if (!CheckDirection)
        {
            transform.RotateAround(CenterObject.transform.position, Vector3.back, RandomSpeed * Time.deltaTime);
        }
        else
        {
            transform.RotateAround(CenterObject.transform.position, Vector3.forward, RandomSpeed * Time.deltaTime);
        }
    }

}
