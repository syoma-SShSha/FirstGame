using UnityEngine;

public class PracticeObjectfind : MonoBehaviour
{
    public float time;
    GameObject player;
    GameObject cube;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        Debug.Log(player.name);
        cube = GameObject.FindWithTag("Cube");
        cube.transform.position = player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        time = time + Time.deltaTime;
        if (time >= 1f)
        {
            time = 0;
           GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (GameObject enemy in enemies)
        {
            Debug.Log(enemy.name);
        } 
        }
        
    }
}
