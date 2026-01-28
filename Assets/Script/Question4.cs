using UnityEngine;
using UnityEngine.UI;

public class Question4 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Image>().fillAmount += 1f/60f * Time.deltaTime;
    }
}
