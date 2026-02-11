using UnityEngine;
using System.Collections.Generic;

public class PracticeList : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        List<string> names = new List<string>();
        names.Add("strawberry");
        names.Add("orange");
        names.Add("grape");
        names.Add("melon");
        for (int i = 0;i < names.Count;i++) {
            Debug.Log(names[i]);
        }
        /* List<int> test = new List<int>();
        test.Add(80);
        test.Add(86);
        test.Add(-30);
        test.Add(50);
        test.Sort();
        for(int i = 0;i < test.Count; i++)
        {
            Debug.Log(test[i]);
        }
        Debug.Log(test[test.Count - 1]);*/
        names.Remove("melon");
        Debug.Log(names.Count);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
