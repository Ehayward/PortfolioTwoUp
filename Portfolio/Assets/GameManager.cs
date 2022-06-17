using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("Coin Parents")]
    //Coin 1
    public GameObject coin1Parent;
    static Rigidbody coin1rigidbody;
    public static Vector3 coin1Velocity;

    //Coin 2
    public GameObject coin2Parent;
    static Rigidbody coin2rigidbody;
    public static Vector3 coin2Velocity;

    //Coin 3
    public GameObject coin3Parent;
    static Rigidbody coin3rigidbody;
    public static Vector3 coin3Velocity;

    void Start()
    {
        coin1rigidbody = GetComponent<Rigidbody>();
        coin2rigidbody = GetComponent<Rigidbody>();
        coin3rigidbody = GetComponent<Rigidbody>();

        CoinFlipper();
    }

    void CoinFlipper()
    {
        if ((coin1Velocity[0] == 0) && (coin1Velocity[1] == 0) && (coin1Velocity[2] == 0) && (coin2Velocity[0] == 0) && (coin2Velocity[1] == 0) && (coin2Velocity[2] == 0) && (coin3Velocity[0] == 0) && (coin3Velocity[1] == 0) && (coin3Velocity[2] == 0))
        {
            float dirX = Random.Range(0, 500);
            float dirY = Random.Range(0, 500);
            float dirZ = Random.Range(110, 300);

            transform.rotation = Quaternion.identity;

            coin1rigidbody.AddForce(transform.up * 700);
            coin2rigidbody.AddForce(transform.up * 1000);
            coin3rigidbody.AddForce(transform.up * 750);

            coin1rigidbody.AddTorque(dirX, dirY, dirZ);
            coin2rigidbody.AddTorque(dirX, dirY, dirZ);
            coin3rigidbody.AddTorque(dirX, dirY, dirZ);

        }
    }

    void Update()
    {
        coin1Velocity = coin1rigidbody.velocity;
        coin2Velocity = coin2rigidbody.velocity;
        coin3Velocity = coin3rigidbody.velocity;
    }
}
