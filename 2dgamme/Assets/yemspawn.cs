using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yemspawn : MonoBehaviour
{
    public GameObject yem;
    public GameObject yem_mavi;
    public GameObject yem_kirmizi;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("yemspawner", 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void yemspawner()
    {

        float posx = Random.Range(-20, +20);
        float posy = Random.Range(-20, +20);
        Vector2 posisyon = new Vector2(posx, posy);
        Instantiate(yem, posisyon, Quaternion.identity);
        float posxm = Random.Range(-20, +20);
        float posym = Random.Range(-20, +20);
        Vector2 posisyonm = new Vector2(posxm, posym);
        Instantiate(yem_mavi, posisyonm, Quaternion.identity);
        float posxk = Random.Range(-20, +20);
        float posyk = Random.Range(-20, +20);
        Vector2 posisyonk = new Vector2(posxk, posyk);
        Instantiate(yem_kirmizi, posisyonk, Quaternion.identity);
    }
}
