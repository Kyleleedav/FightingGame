using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GameManager : MonoBehaviour
{
    public GameObject UIManager;
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

    void Awake()
    {
        controls = new PlayerControls();

        controls.Gameplay.LightPunch.performed += ctx => DisplayInput();
        controls.Gameplay.LightKick.performed += ctx => DisplayInput();
        controls.Gameplay.MediumPunch.performed += ctx => DisplayInput();
        controls.Gameplay.MediumKick.performed += ctx => DisplayInput();
    }

    //Method for input display testing.
    void DisplayInput()
    {
        UIManager.GetComponent<UIManager>().DisplayInputs();
    }

    private void OnEnable()
    {
        controls.Gameplay.Enable();
    }

    private void OnDisable()
    {
        controls.Gameplay.Disable();
    }


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
