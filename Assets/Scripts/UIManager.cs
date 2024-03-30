using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject gameManager;

    //Icons for InputDisplayer.
    public GameObject HeavyPunchButtonIcon;
    public GameObject MediumPunchButtonIcon;
    public GameObject LightPunchButtonIcon;

    public GameObject HeavyKickButtonIcon;
    public GameObject MediumKickButtonIcon;
    public GameObject LightKickButtonIcon;

    public GameObject TagButtonOneIcon;
    public GameObject TagButtonTwoIcon;
    public GameObject TagButtonThreeIcon;

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

    public void CheckLightPunchButtonPressed()
    {
        if (gameManager.GetComponent<GameManager>().squareButtonPressed == true)
        {
            LightPunchButtonIcon.SetActive(true);
            Debug.Log("Lightpunch");
        }
        else
        {
            LightPunchButtonIcon.SetActive(false);
        }
    }

    public void CheckMediumPunchButtonPressed()
    {
        if (gameManager.GetComponent<GameManager>().triangleButtonPressed == true)
        {
            MediumPunchButtonIcon.SetActive(true);
        }

        else
        {
            MediumPunchButtonIcon.SetActive(false);
        }
    }

    public void CheckHeavyPunchButtonPressed()
    {
        if (gameManager.GetComponent<GameManager>().rightShoulderButtonPressed == true)
        {
            HeavyPunchButtonIcon.SetActive(true);
        }

        else
        {
            HeavyPunchButtonIcon.SetActive(false);
        }
    }

    public void CheckLightKickButtonPressed()
    {
        if (gameManager.GetComponent<GameManager>().crossButtonPressed == true)
        {
            LightKickButtonIcon.SetActive(true);
        }
        else
        {
            LightKickButtonIcon.SetActive(false);
        }
    }

    public void CheckMediumKickButtonPressed()
    {
        if (gameManager.GetComponent<GameManager>().circleButtonPressed == true)
        {
            MediumKickButtonIcon.SetActive(true);
        }

        else
        {
            MediumKickButtonIcon.SetActive(false);
        }
    }

    public void CheckHeavyKickButtonPressed()
    {
        if (gameManager.GetComponent<GameManager>().rightTriggerButtonPressed == true)
        {
            HeavyKickButtonIcon.SetActive(true);
        }

        else
        {
            HeavyKickButtonIcon.SetActive(false);
        }
    }

    public void CheckTagButtonOnePressed()
    {
        if (gameManager.GetComponent<GameManager>().leftShoulderButtonPressed == true)
        {
            TagButtonOneIcon.SetActive(true);
        }

        else
        {
            TagButtonOneIcon.SetActive(false);
        }
    }

    public void CheckTagButtonTwoPressed()
    {
        if (gameManager.GetComponent<GameManager>().leftTriggerButtonPressed == true)
        {
            TagButtonTwoIcon.SetActive(true);
        }

        else
        {
            TagButtonTwoIcon.SetActive(false);
        }
    }
}

