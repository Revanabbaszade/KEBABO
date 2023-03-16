using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Taban : MonoBehaviour
{
    public ScoreObj scoreObject;
     private void OnTriggerEnter2D(Collider2D temasEdilen)
    {
        if (temasEdilen.gameObject.CompareTag("Tavuk"))             
        {
            scoreObject.EndGame();
           
            Destroy(temasEdilen.gameObject);
        }
        else if (temasEdilen.gameObject.CompareTag("kuzu"))
        {
            scoreObject.EndGame();
            
            Destroy(temasEdilen.gameObject);
        }
        else if (temasEdilen.gameObject.CompareTag("dana"))
        {
            scoreObject.EndGame();
          
            Destroy(temasEdilen.gameObject);
        }
        else if (temasEdilen.gameObject.CompareTag("sinek"))
        {
            scoreObject.ScoreKazan();
            
            Destroy(temasEdilen.gameObject);
        }
        else if (temasEdilen.gameObject.CompareTag("at"))
        {
            scoreObject.EndGame();
            Destroy(temasEdilen.gameObject);
        }

        
    }
}
