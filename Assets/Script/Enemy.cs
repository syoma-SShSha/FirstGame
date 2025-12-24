using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public Transform playerTransform;
    public float speed = 0;
    public int HP = 5;
    public Image HpImage;
    private MeshRenderer mesh;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        mesh = GetComponent<MeshRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(playerTransform);
        transform.position += transform.forward * speed * Time.deltaTime;
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            HP -= 1;
            HpChange();
            if(HP <= 0) 
            {
                Destroy(gameObject);
            }
        }
    }
    void HpChange() 
    {
        HpImage.fillAmount -= 0.2f;
    }
}
