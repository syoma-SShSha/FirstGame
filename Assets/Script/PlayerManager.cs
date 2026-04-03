using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerManager : MonoBehaviour
{
    public float Hp;
    public float MaxHp;
    public TextMeshProUGUI HpCount;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        HpCount.text = MaxHp.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Hp -= 1;
            HpChange();
            if (Hp <= 0)
            {
                SceneManager.LoadScene("Gameover");
            }
        }
    }
    private void HpChange()
    {
        HpCount.text = Hp.ToString();
    }
}
