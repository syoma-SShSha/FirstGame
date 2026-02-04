using UnityEngine;

public class Question1 : MonoBehaviour
{
    public GameObject Cube;
    private GameObject instance;
    private Rigidbody[] storage;
    private int count = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        storage = new Rigidbody[81];
        for (int i = 0; i <= 8; i++)
        {
            for (int a = 0; a <= 8; a++)
            {
                instance = Instantiate(Cube, new Vector3(a * 2, 0, i * 2), Quaternion.identity);
                storage[count] = instance.GetComponent<Rigidbody>();
                count++;
                if ((instance.transform.position.x) >= 10 && (instance.transform.position.z) <= 10)
                {
                    instance.GetComponent<MeshRenderer>().material.color = Color.blue;
                }
                if ((instance.transform.position.x) <= 10 && (instance.transform.position.z) >= 10)
                {
                    instance.GetComponent<MeshRenderer>().material.color = Color.green;
                }
                if ((instance.transform.position.x) >= 10 && (instance.transform.position.z) >= 10)
                {
                    instance.GetComponent<MeshRenderer>().material.color = Color.skyBlue;
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Gravity()
    {
        for(count = 0; count < 81; count++)
        {
            storage[count].useGravity = true;
        }
    }
}
