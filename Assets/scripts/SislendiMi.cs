using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SislendiMi : MonoBehaviour
{
    
    public ScoreObj scoreObject;
    void OnTriggerEnter2D(Collider2D temasEdilen)
    {
        if (temasEdilen.gameObject.CompareTag("Tavuk"))
        {
            scoreObject.ScoreKazan(); 
            Debug.Log("Tavuk sislendi!");
            Destroy(temasEdilen.gameObject);
        }
        else if(temasEdilen.gameObject.CompareTag("kuzu"))
        {
            scoreObject.ScoreKazan();
            Debug.Log("kuzu sislendi!");
            Destroy(temasEdilen.gameObject);
        }
        else if(temasEdilen.gameObject.CompareTag("dana"))
        {
            scoreObject.ScoreKazan();
            Debug.Log("dana sislendi!");
            Destroy(temasEdilen.gameObject);
        }
        else if(temasEdilen.gameObject.CompareTag("sinek"))
        {
            scoreObject.EndGame();
            Debug.Log("sinek sislendi!");
            Destroy(temasEdilen.gameObject);
        }
        else if(temasEdilen.gameObject.CompareTag("at"))
        {
            scoreObject.ScoreKazan();
            Debug.Log("at sislendi!");
            Destroy(temasEdilen.gameObject);
        }
       

    }



}
