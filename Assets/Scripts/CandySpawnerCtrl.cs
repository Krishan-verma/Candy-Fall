using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandySpawnerCtrl : MonoBehaviour
{
    public GameObject[] Candies;
    public static CandySpawnerCtrl instance;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update

    void Start()
    {
        InvokeRepeating("SpawnCandy", 7, 2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnCandy()
    {
        int rindex= Random.Range(0,5);
        float randomX = Random.Range(-4,4);
        transform.position= new Vector3(randomX,transform.position.y,transform.position.z);
        Instantiate(Candies[rindex],transform.position,Quaternion.identity);
    }

    public void StopSpawnCandy()
    {
        CancelInvoke("SpawnCandy");
    }
}
