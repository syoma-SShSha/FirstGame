using UnityEngine;

public class Question1 : MonoBehaviour
{
    public GameObject Cube;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for(int i = 0;i <= 8; i++)
        {
            for (int a = 0;a <= 8; a++)
            {
                Instantiate(Cube, new Vector3(a * 2, 0, i * 2), Quaternion.identity);
            }
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
