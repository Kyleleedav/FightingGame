using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFocalPoint : MonoBehaviour
{
    public GameObject player1;
    public GameObject player2;

    float centerFocalPointX, centerFocalPointY, centerFocalPointZ;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        UpdateFocalPointPosition();       
    }

    void UpdateFocalPointPosition()
    {
        centerFocalPointX = (player1.transform.position.x + player2.transform.position.x) / 2;
        centerFocalPointY = (player1.transform.position.y + player2.transform.position.y) / 2;
        centerFocalPointZ = (player1.transform.position.z + player2.transform.position.z) / 2;

        gameObject.transform.position = new Vector3(centerFocalPointX, centerFocalPointY, centerFocalPointZ);
    }
}
