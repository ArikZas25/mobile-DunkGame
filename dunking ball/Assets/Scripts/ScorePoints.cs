using UnityEngine;
using TMPro;


public class ScorePoints : MonoBehaviour
{
    public TMP_Text MyScoreText;
    private bool tuchedRing;
    public int ScoreNum;
    public int comboNum;

    void Start()
    {
        tuchedRing = false;
        ScoreNum = 0;
        comboNum = 0;
    }

    // need to change the code so the score point will work 


    private void OnTriggerEnter2D(Collider2D tuchedpoint)
    {
        if (tuchedpoint.tag == "point" && tuchedRing) 
        {
            GotPoint(); 
            Invoke("tuchedBeforePoint", 0.1f);
            MyScoreText.text += ScoreNum.ToString();
        }
        if (tuchedpoint.tag == "point" && !tuchedRing)
        {
            comboNum += 1;
            MyScoreText.text += comboNum.ToString();
            Debug.Log("combo");      
        }
 

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        tuchedRing = true;
    }


    // this is a test for github 


    

    private void GotPoint()
    {
        ScoreNum += 1;
        Debug.Log("point");
    } 


    private void tuchedBeforePoint()
    {
        tuchedRing = false;
    }

}
