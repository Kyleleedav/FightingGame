using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    //Icons for InputDisplayer.
    public GameObject LightPunchButtonIcon;

    public GameObject timerText;
    public GameObject HealthBarplayer1;
    public GameObject HealthBarplayer2;
    public int timeRounded = 99;
    public float lastTimeUpdate = 0;

    // Start is called before the first frame update
    void Start()
    {
        timeRounded = 99;
    }

    // Update is called once per frame
    void Update()
    { 
        if (timeRounded > 0 && Time.time - lastTimeUpdate > 1)
        {
            timeRounded -= 1;
            timerText.GetComponent<UILabel>().text = timeRounded.ToString();
            lastTimeUpdate = Time.time;
        }

        if (timeRounded <= 0)
        {
            //Debug.Log("Time is" + Time.time);
            Debug.Log("End of round");
            StartCoroutine(CheckVictor());
        }
    }

    IEnumerator CheckVictor()
    {
        if (1 > 2)
        {
            Debug.Log("Player1 Wins");
        }

        else if (2 > 1)
        {
            Debug.Log("Player1 Wins");
        }

        else if (1 == 2)
        {
            Debug.Log("Draw");
        }
        yield return new WaitForSeconds(1);
    }


    public void DisplayInputs()
    {
        LightPunchButtonIcon.SetActive(true);
    }
}

