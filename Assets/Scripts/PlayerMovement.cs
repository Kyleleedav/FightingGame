using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public GameObject gameManager;

    public float playerSpeed = 2f;  //Temp movement speed.
    public float jumpVelocity = 5f; //Temp jump value.


    // Start is called before the first frame update

    void Awake()
    {
        //Load in character stats
    }

    void Start()
    {  
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void MoveLeft()
    {
        if (gameManager.GetComponent<GameManager>().leftButtonPressed == true)
        {
            GetComponent<Rigidbody>().velocity = Vector3.left * playerSpeed;
        }
    }

    
    public void MoveRight()
    {
        if (gameManager.GetComponent<GameManager>().rightButtonPressed == true)
        {
            GetComponent<Rigidbody>().velocity = Vector3.right * playerSpeed;
        }
    }

    public void Jump()
    {
        if (gameManager.GetComponent<GameManager>().upButtonPressed == true)
        {
            GetComponent<Rigidbody>().velocity = Vector3.up * jumpVelocity;
        }
    }
}
