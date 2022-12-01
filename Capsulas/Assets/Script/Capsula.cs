using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Capsula : MonoBehaviour
{
    [SerializeField]
    Slider sliderTime;   
    

    float iniTime = 0;
    float time;
    float minTime = 10f;
    float maxTime = 30f;
    // Start is called before the first frame update
    void Start()
    {
        time = Random.Range(minTime, maxTime);       

        sliderTime.maxValue = time;
        

        Debug.Log("Tiempo aleatorio: " + time);
    }

    // Update is called once per frame
    void Update()
    {
        iniTime += 1f * Time.deltaTime;
        sliderTime.value = time - iniTime;
        
        if(iniTime >= time)
        {
            Destroy(gameObject);
        }

        Debug.Log("Tiempo: " + iniTime);
    }
}
