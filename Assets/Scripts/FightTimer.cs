using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FightTimer : MonoBehaviour
{
    public GameObject timerText;
    public int timeRounded = 99;
    public float lastTimeUpdate = 0;

    private void Awake()
    {
        //timerText.GetComponent<UILabel>().text = timeRounded.ToString();
    }

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
        }
    }
}
