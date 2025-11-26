using Unity.VisualScripting;
using UnityEngine;

public class log : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Cube")
        {
             Debug.Log("Enter");
        }
    }
    private void OnCollisionStay(Collision collision)
    {
        if(collision.gameObject.name == "Cube")
        {
            Debug.Log("Stay");
        }
    }
}
