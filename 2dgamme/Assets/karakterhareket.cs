using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class karakterhareket : MonoBehaviour
{
    public GameObject rutbe1;
    public GameObject rutbe2;
    public GameObject rutbe3;
    public static int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mouseposisyon = Camera.main.ScreenToWorldPoint( Input.mousePosition);
        transform.position = Vector3.MoveTowards(transform.position, mouseposisyon, 7 * Time.deltaTime);
        if (score >= 50 && score < 99)
        {
            rutbe2.SetActive(true);



        }
        if (score >= 100 && 50 < score)
        {
            rutbe3.SetActive(true);



        }





















    }
}
