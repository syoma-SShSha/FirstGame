using UnityEngine;

public class SampleLine : MonoBehaviour
{
    LineRenderer line;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        line = GetComponent<LineRenderer>();

        line.positionCount = 4;

        line.SetPosition(0, new Vector3(0, 0, 0));
        line.SetPosition(1, new Vector3(2, 0, 0));
        line.SetPosition(2, new Vector3(1, Mathf.Sqrt(3), 0));
        line.SetPosition(3, new Vector3(0, 0, 0));
        line.startColor = Color.red;
        line.endColor = Color.blue;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mp = Input.mousePosition;
        mp.z = 10f; // カメラから10m前の平面で取得（値は要調整）
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(mp);
        line.SetPosition(1, mousePos);
    }
}
