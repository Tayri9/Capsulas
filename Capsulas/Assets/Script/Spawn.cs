using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField]
    GameObject prefab, particles;

    GameObject capsule;

    Vector3 position;
    /*
    float time, timer;

    private void Update()
    {
        timer += Time.deltaTime;
        Debug.Log("timer spawn: " + timer);
    }
    */
    public void Spawner()
    {
        //timer = 0f;
       // time = Random.Range(0f, 5f);
        //Debug.Log("time spawn: " + time);
        position = new Vector3(Random.Range(-8, 8), Random.Range(-3.5f, 3.5f), 0f);

        //if (timer >= time)
        //{
            capsule = Instantiate(prefab, position, Quaternion.identity);
            Instantiate(particles, position, Quaternion.identity);

            LeanTween.scale(capsule, Vector3.zero, 0f).setOnComplete(() =>
            {
                LeanTween.scale(capsule, Vector3.one, 0.5f);
            });
        //}

        
        
    }
}
