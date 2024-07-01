using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    [SerializeField] float maxTime = 500;
    [SerializeField] float actualTime;
    [SerializeField] bool activateTimer;
    [SerializeField] Slider slider;

    public GameManager manager;



    private void Start()
    {
        Activate();
    }


    void Update()
    {
        if (activateTimer)
            ChangeTimer();
    }



    void ChangeTimer()
    {
        actualTime -= Time.deltaTime * 10;


        if (actualTime >= 0)
            slider.value = actualTime;

        if (actualTime <= 0)
        {
            manager.Win();
            timerEstate(false);
        }
    }



    void Activate()
    {
        actualTime = maxTime;
        slider.maxValue = maxTime;

        timerEstate(true);
    }


    public void timerEstate(bool estado)
    {
        activateTimer = estado;
    }

}
