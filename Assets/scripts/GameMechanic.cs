 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMecan : MonoBehaviour
{      
    public BoxCollider2D  boxCollider2D;
    public GameObject SisCubugu, HedefPosition;
    public float hiz,geriCekmeHizi;
    private Vector3 baslangicPozisyonu;
    // Start is called before the first frame update
    void Start()
    {
        baslangicPozisyonu = SisCubugu.transform.position;
    }
    bool tusaBasildi;
    bool hedefeVarildi;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            tusaBasildi=true;
            boxCollider2D.enabled =true;
        }

        if (tusaBasildi== true)//ILERI GIDERKEN
        {
            SisCubugu.transform.position = Vector3.MoveTowards(SisCubugu.transform.position,HedefPosition.transform.position,hiz*Time.deltaTime);
        }
        if(SisCubugu.transform.position == HedefPosition.transform.position)
        {
             hedefeVarildi =true;
        }
        if (hedefeVarildi == true)//GERI DONERKEN
        {
            SisCubugu.transform.position = Vector3.MoveTowards(SisCubugu.transform.position,baslangicPozisyonu, geriCekmeHizi * Time.deltaTime);
            boxCollider2D.enabled = false;
        }
        if(SisCubugu.transform.position == baslangicPozisyonu)
        {
            hedefeVarildi =false;
            tusaBasildi =false; 
        }
    }
}
