using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField]
    GameObject prefab;

    Vector3 position;    

    public void Spwan()
    {
        position = new Vector3(Random.Range(-8, 8), Random.Range(-3.5f, 3.5f), 0f);

        Instantiate(prefab, position, Quaternion.identity);
    }
}
