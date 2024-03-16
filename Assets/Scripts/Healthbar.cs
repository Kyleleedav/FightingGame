 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Healthbar : MonoBehaviour
{
    public GameObject healthbarBackground;
    public GameObject healthbarForeground;
    public float maximumHealthValue = 150f;
    public float currentMaxHealthValue = 0f;

    private float onePercentHealthSlidervalue;

    // Start is called before the first frame update
    void Start()
    {
        currentMaxHealthValue = maximumHealthValue;
        onePercentHealthSlidervalue = 1 / maximumHealthValue;
        Debug.Log("HealthSlider is " + onePercentHealthSlidervalue);
        FillHealthBarStart();
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void FillHealthBarStart()
    {
        healthbarForeground.GetComponent<UISlider>().value = onePercentHealthSlidervalue * maximumHealthValue;
    }

    private void UpdateHealthBar()
    {
        healthbarForeground.GetComponent<UISlider>().value = onePercentHealthSlidervalue * currentMaxHealthValue;
    }

    private void TakeDamage(float damage)
    {
        currentMaxHealthValue -= damage;
        Debug.Log("Damage Taken at this value " + damage);
        Debug.Log("currentMaxHealthValue is" + currentMaxHealthValue);
        if (currentMaxHealthValue <= 0)
        {
            currentMaxHealthValue = 0;
            Debug.Log("Dead!");
        }
        UpdateHealthBar();
    }
}
