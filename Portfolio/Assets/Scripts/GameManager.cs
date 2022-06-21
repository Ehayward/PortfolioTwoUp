using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [Header("Coin 1 Info")]
    //Coin 1
    public GameObject coin1Parent;
    public Rigidbody coin1Rigidbody;
    public static Vector3 coin1Velocity;

    [Header("Coin 2 Info")]
    //Coin 2
    public GameObject coin2Parent;
    public Rigidbody coin2Rigidbody;
    public static Vector3 coin2Velocity;

    [Header("Coin 3 Info")]
    //Coin 3
    public GameObject coin3Parent;
    public Rigidbody coin3Rigidbody;
    public static Vector3 coin3Velocity;

    [Header("Buttons")]
    public GameObject flipButton;


    void Start()
    {


    }

    public void CoinFlipper()
    {
        if ((coin1Velocity[0] == 0) && (coin1Velocity[1] == 0) && (coin1Velocity[2] == 0) && (coin2Velocity[0] == 0) && (coin2Velocity[1] == 0) && (coin2Velocity[2] == 0) && (coin3Velocity[0] == 0) && (coin3Velocity[1] == 0) && (coin3Velocity[2] == 0))
        {
            float dirX1 = Random.Range(50, 500);
            float dirY1 = Random.Range(0, 500);
            float dirZ1 = Random.Range(50, 700);

            float dirX2 = Random.Range(0, 500);
            float dirY2 = Random.Range(0, 500);
            float dirZ2 = Random.Range(110, 500);

            float dirX3 = Random.Range(100, 500);
            float dirY3 = Random.Range(0, 500);
            float dirZ3 = Random.Range(110, 450);


            coin1Rigidbody.AddForce(transform.up * 750);
            coin2Rigidbody.AddForce(transform.up * 720);
            coin3Rigidbody.AddForce(transform.up * 700);

            coin1Rigidbody.AddTorque(dirX1, dirY1, dirZ1);
            coin2Rigidbody.AddTorque(dirX2, dirY2, dirZ2);
            coin3Rigidbody.AddTorque(dirX3, dirY3, dirZ3);
        }

    }

    void Update()
    {
        coin1Velocity = coin1Rigidbody.velocity;
        coin2Velocity = coin2Rigidbody.velocity;
        coin3Velocity = coin3Rigidbody.velocity;
    }
}
