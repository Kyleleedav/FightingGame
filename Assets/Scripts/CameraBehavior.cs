using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehavior : MonoBehaviour
{
    public GameObject levelCamera;
    public GameObject cameraFocalPoint;

    private Transform[] playerTransforms;
    public float yOffset;

    private float cameraClosestDistanceFromPlayers = 2.0f;
    private float camerafurthestDistanceFromPlayers = 3.0f;
    private float xMin, xMax, yMin, yMax;

    // Start is called before the first frame update
    void Start()
    {
        GameObject[] allPlayers = GameObject.FindGameObjectsWithTag("Player");
        playerTransforms = new Transform[allPlayers.Length];
        for (int i = 0; i < allPlayers.Length; i++)
        {
            playerTransforms[i] = allPlayers[i].transform;
        }
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void LateUpdate()
    {
        if(playerTransforms.Length == 0)
        {
            Debug.Log("Have not found a player, make sure the player tag is on");
            return;
        }

        xMin = xMax = playerTransforms[0].position.x;
        yMin = yMax = playerTransforms[0].position.y;

         for (int i = 1; i < playerTransforms.Length; i++ )
        {
            if (playerTransforms[i].position.x < xMin)
                xMin = playerTransforms[i].position.x;

            if (playerTransforms[i].position.x > xMax)
                xMax = playerTransforms[i].position.x;

            if (playerTransforms[i].position.y < yMin)
                yMin = playerTransforms[i].position.x;

            if (playerTransforms[i].position.y > yMax)
                yMax = playerTransforms[i].position.x;
        }

        float xMiddle = (xMin + xMax) / 2;
        float yMiddle = (yMin + yMax) / 2;
        float distance = xMax - xMin;

        if (distance < cameraClosestDistanceFromPlayers)
        {
            distance = cameraClosestDistanceFromPlayers;
            //Set the Orthographic Camera to its smallest size.
            gameObject.GetComponent<Camera>().orthographicSize = 1.3f;
        }

        if (distance >= camerafurthestDistanceFromPlayers)
        {
            distance = camerafurthestDistanceFromPlayers;
            //Set the Orthographic Camera to its largest size.
            gameObject.GetComponent<Camera>().orthographicSize = 1.5f;
        }

        transform.position = new Vector3(xMiddle, cameraFocalPoint.transform.position.y + yOffset, -distance);


    }
}
