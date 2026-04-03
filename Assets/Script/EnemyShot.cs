using UnityEngine;

public class EnemyShot : MonoBehaviour
{
    public float time;
    public GameObject bullet;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time = time + Time.deltaTime;
        if (time >= 3f)
        {
            time = 0;
            Instantiate(bullet, transform.position, transform.rotation);
        }
        
    }
    private void OnTriggerEnter(Collider other)
    {
        
    }
}
