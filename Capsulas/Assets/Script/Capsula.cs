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
    GameObject prefab, canvas, spawn;

    float timer = 0;
    float time;
    float timeLeft;
    float minTime = 1f;
    float maxTime = 10f;
    float timeSpawn;

    Vector3 position;
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
        timer += Time.deltaTime;
        timeLeft = time - timer;
        sliderTime.value = timeLeft;
        textTime.text = timeLeft.ToString();
        
        if(timeLeft <= 0)
        {
            position = gameObject.transform.position;
            Destroy(gameObject);
            spawn.GetComponent<Spawn>().Spawner();
        }

    }

}
