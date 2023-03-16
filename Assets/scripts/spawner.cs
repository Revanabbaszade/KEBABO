 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public void StartGame()
    {
        oyunBasladiMi = true;
    }
    public void EndGame()
    {
        Application.Quit();
    }
    void Start()
    {
        
    }
    public bool oyunBasladiMi;
    public float minSure,maxSure;
    public GameObject[] yiyecekListesi;
    // Update is called once per frame
    void Update()
    {
        if (oyunBasladiMi == true && objeSpawnCoroutine == null)
        {
            objeSpawnCoroutine = StartCoroutine(objeSpawn(Random.Range(minSure, maxSure)));
        }
    }
    Coroutine objeSpawnCoroutine =null;
    IEnumerator objeSpawn (float zaman)
    {
        int rastgeleSayi =Random.Range(0,yiyecekListesi.Length);
        GameObject yiyecek = Instantiate(yiyecekListesi[rastgeleSayi],gameObject.transform.position + new Vector3(Random.Range(-1.8f,1.7f),0,0),Quaternion.identity);
        Destroy(yiyecek,4f);
        yield return new WaitForSeconds(zaman);
        objeSpawnCoroutine = null;
    }

}
