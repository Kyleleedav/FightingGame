using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GameManager : MonoBehaviour
{
    //public bool wasPressedThisFrame
    public GameObject UIManager;
    public GameObject PlayerOne;
    public GameObject roundTimerText;
    public GameObject HealthBarBackgroundplayer1;
    public GameObject HealthBarForegroundplayer1;
    public GameObject HealthBarplayer2;
    public int timeRounded;
    public float healthComparisonBar = 0.5f;
    public float healthPointsPlayer1;
    public float healthPointsPlayer2;
    public float lastTimeUpdate = 0;



    private bool roundStillActive;

    //Unity controller plugin.
    private PlayerControls controls;
    public bool upButtonPressed;
    public bool leftButtonPressed;
    public bool rightButtonPressed;
    public bool squareButtonPressed;
    public bool crossButtonPressed;
    public bool circleButtonPressed;
    public bool triangleButtonPressed;
    public bool rightShoulderButtonPressed;
    public bool rightTriggerButtonPressed;
    public bool leftShoulderButtonPressed;
    public bool leftTriggerButtonPressed;

    // Start is called before the first frame update
    void Start()
    {
        roundStillActive = true;
        //timeRounded = 99;
        healthPointsPlayer1 = 100;
        healthPointsPlayer2 = 100;
        PopulateHud();
    }

    // Update is called once per frame
    void Update()
    {
        //Player button inputs
        upButtonPressed = Gamepad.current.dpad.up.wasPressedThisFrame;
        PlayerOne.GetComponent<PlayerMovement>().Jump();

        leftButtonPressed = Gamepad.current.dpad.left.wasPressedThisFrame;
        PlayerOne.GetComponent<PlayerMovement>().MoveLeft();

        rightButtonPressed = Gamepad.current.dpad.right.wasPressedThisFrame;
        PlayerOne.GetComponent<PlayerMovement>().MoveRight();

        squareButtonPressed = Gamepad.current.squareButton.wasPressedThisFrame;
        UIManager.GetComponent<UIManager>().CheckLightPunchButtonPressed();

        crossButtonPressed = Gamepad.current.crossButton.wasPressedThisFrame;
        UIManager.GetComponent<UIManager>().CheckLightKickButtonPressed();

        triangleButtonPressed = Gamepad.current.triangleButton.wasPressedThisFrame;
        UIManager.GetComponent<UIManager>().CheckMediumPunchButtonPressed();

        circleButtonPressed = Gamepad.current.circleButton.wasPressedThisFrame;
        UIManager.GetComponent<UIManager>().CheckMediumKickButtonPressed();

        rightShoulderButtonPressed = Gamepad.current.rightShoulder.wasPressedThisFrame;
        UIManager.GetComponent<UIManager>().CheckHeavyPunchButtonPressed();

        rightTriggerButtonPressed = Gamepad.current.rightTrigger.wasPressedThisFrame;
        UIManager.GetComponent<UIManager>().CheckHeavyKickButtonPressed();

        leftShoulderButtonPressed = Gamepad.current.leftShoulder.wasPressedThisFrame;
        UIManager.GetComponent<UIManager>().CheckTagButtonOnePressed();

        leftTriggerButtonPressed = Gamepad.current.leftTrigger.wasPressedThisFrame;
        UIManager.GetComponent<UIManager>().CheckTagButtonTwoPressed();
        //

        if (timeRounded > 0 && Time.time - lastTimeUpdate > 1)
        {
            timeRounded -= 1;
            roundTimerText.GetComponent<UILabel>().text = timeRounded.ToString();
            lastTimeUpdate = Time.time;
        }

        if (timeRounded <= 0 && roundStillActive == true)
        {
            Debug.Log("End of round");
            StartCoroutine(CheckVictor());
        }
    }

    void PopulateHud()
    {
        HealthBarForegroundplayer1.GetComponent<UISlider>().value = 0.5f;
        HealthBarBackgroundplayer1.GetComponent<UISlider>().value = 0.75f;
    }

    IEnumerator CheckVictor()
    {
        if (healthComparisonBar > 0.5)
        {
            roundStillActive = false;
            Debug.Log("Player1 Wins");
        }

        else if (healthComparisonBar < 0.5)
        {
            roundStillActive = false;
            Debug.Log("Player2 Wins");
        }

        else if (healthComparisonBar == 0.5)
        {
            roundStillActive = false;
            Debug.Log("Draw");
        }
        yield return new WaitForSeconds(1);
    }
}
