using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Capsula : MonoBehaviour
{
    [SerializeField]
    Slider sliderTime;

    [SerializeField]
    TextMeshProUGUI textTime;

    [SerializeField]
    GameObject prefab, canvas, spawn, particles;

    //float timer = 0;
    float time;
    //float timeLeft;
    float minTime = 10f;
    float maxTime = 30f;

    // Start is called before the first frame update
    void Start()
    {
        //time = Random.Range(minTime, maxTime);       

        //sliderTime.maxValue = time;  
    }

    private void OnEnable()
    {
        canvas.GetComponent<Canvas>().worldCamera = Camera.main;
        
        time = Random.Range(minTime, maxTime);

        sliderTime.maxValue = time;
    }

    // Update is called once per frame
    void Update()
    {
        /*
        timer += Time.deltaTime;
        timeLeft = time - timer;
        sliderTime.value = timeLeft;
        textTime.text = timeLeft.ToString();

        if(timeLeft <= 0)
        {
            DestroyCapsule();
        }
        */
        time -= Time.deltaTime;
        sliderTime.value = time;
        textTime.text = time.ToString();
         if(time <= 0)
         {
            DestroyCapsule();
         }
    }

    private void DestroyCapsule()
    {
        Instantiate(particles, gameObject.transform.position, Quaternion.identity);
        LeanTween.scale(gameObject, Vector3.zero, 0.5f).setOnComplete( () =>
        {
            
            Destroy(gameObject);
            spawn.GetComponent<Spawn>().Spawner();
        });        
    }
}
