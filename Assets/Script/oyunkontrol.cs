using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class oyunkontrol : MonoBehaviour
{
    public GameObject astreoid;
    public Vector3 randompos;
    int score = 0;
    public Text text;
    public Text oyunbittiText;
    public Text yenidenbaşlaText;
    bool oyunbittikontrol = false;
    bool yenidenbaşlakontrol = false;
    void Start()
    {
        score = 0;
        text.text = "Score=" + score;
        StartCoroutine(oluştur());
    }
     void Update()
    {
        if(Input.GetKeyDown(KeyCode.R)&& yenidenbaşlakontrol )
        {
            SceneManager.LoadScene("level1");
        }
    }
    IEnumerator oluştur()
    {
        yield return new WaitForSeconds(2);
        while(true)
        {
            for (int a = 0; a < 10; a++)
            {
                Vector3 vec = new Vector3(Random.Range(-randompos.x, randompos.x), 0, randompos.z);
                Instantiate(astreoid, vec, Quaternion.identity);
                yield return new WaitForSeconds(0.7f);

            }
            if (oyunbittikontrol)
            {
                yenidenbaşlaText.text="PRESS R FOR RESTART";
                yenidenbaşlakontrol = true;
                break;
            }

            yield return new WaitForSeconds(1);

            
        }
        
    }
    public void skorarttır(int gelenskor)
    {
        score += gelenskor;
        text.text = "Score=" + score;
        Debug.Log(score);

    }
    public void gameover()
    {
        oyunbittiText.text = "GAME OVER";
        oyunbittikontrol = true;
    }

    
}
