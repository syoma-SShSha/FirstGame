using UnityEngine;
using System.Collections.Generic;
using System.Linq.Expressions;

public class Spawner : MonoBehaviour
{
    public int waveCount = 1;
    public int killCount = 0;
    public List<GameObject> wave1 = new List<GameObject>();
    public List<GameObject> wave2 = new List<GameObject>();
    public List<GameObject> wave3 = new List<GameObject>();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        AllInstantiate();
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy"); 
        foreach (GameObject enemy in enemies)
        {
            Debug.Log(enemy.name);
        }
    }

    // Update is called once per frame
    void Update()
    {
        switch (waveCount)
        {
            case 1:
                if(wave1.Count == killCount)
                {
                    waveCount++;
                    AllInstantiate();
                    killCount = 0;
                }
                break;
            case 2:
                if (wave2.Count == killCount)
                {
                    waveCount++;
                    AllInstantiate();
                    killCount = 0;
                }
                break;
            case 3:
                if (wave3.Count == killCount)
                {
                    //waveCount++;
                    //AllInstantiate();
                    killCount = 0;
                }
                break;
        }
    }
    public void AllInstantiate()
    {
        switch(waveCount)
        {
            case 1:
                for(int i = 0;i < wave1.Count; i++)
                {
                    Instantiate(wave1[i], new Vector3(i * 2, 0, 0), Quaternion.identity);
                }
                break;
            case 2:
                for (int i = 0; i < wave2.Count; i++)
                {
                    Instantiate(wave2[i], new Vector3(i * 2, 0, 0), Quaternion.identity);
                }
                break;
            case 3:
                for (int i = 0; i < wave3.Count; i++)
                {
                    Instantiate(wave3[i], new Vector3(i * 2, 0, 0), Quaternion.identity);
                }
                break;
        }
        
    }
}
