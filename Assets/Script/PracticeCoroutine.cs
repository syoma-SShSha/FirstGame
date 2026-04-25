using System.Collections;
using UnityEngine;

public class PracticeCoroutine : MonoBehaviour
{
    float lifetime;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(Test1());
        StartCoroutine(Test2());
        StartCoroutine(Test3());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator Test1()
    {
        yield return new WaitForSeconds(2f);
        Debug.Log("2•b");
    }
    IEnumerator Test2()
    {
        for (int i = 0;i < 5; i++)
        {
            yield return new WaitForSeconds(1f);
            Debug.Log(i);
        }
    }
    IEnumerator Test3()
    {
        Destroy(GameObject.Find("Cube"),3f);
        while (true)
        {
            yield return null;
            GameObject obj = GameObject.Find("Cube");
            obj.transform.position += new Vector3(0.1f, 0, 0);
            lifetime = lifetime + Time.deltaTime;
            if(lifetime >= 5)
            {
                break;
            }
        }
    }
}
