using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    private Spawner spawner;
    public Transform playerTransform;
    public float speed = 0;
    public float HP = 5;
    public float MaxHP = 5;
    public Image HpImage;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawner = GameObject.FindObjectOfType<Spawner>();
        playerTransform = GameObject.FindObjectOfType<PlayerManager>().transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(playerTransform);
        transform.position += transform.forward * speed * Time.deltaTime;
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            HP -= 1;
            HpChange();
            if(HP <= 0) 
            {
                spawner.killCount++;
                Destroy(gameObject);
            }
        }
    }
    void HpChange() 
    {
        HpImage.fillAmount -= (1f / MaxHP);
        //HpImage.fillAmount = HP / MaxHP;
    }
}
