using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class menzil : MonoBehaviour
{
    public Text score;
    public GameObject yemm;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "yem")
        {
            Camera.main.orthographicSize += 0.2f;
            float menzilx = gameObject.transform.localScale.x;
            float menzily = gameObject.transform.localScale.y;
            Debug.Log(menzilx);
            Debug.Log(menzily);
            Destroy(collision.gameObject);
            karakterhareket.score++;
            Debug.Log(karakterhareket.score);
            score.text = karakterhareket.score.ToString();
            menzilx += 0.1f;
            menzily += 0.1f;
            gameObject.transform.localScale = new Vector3(menzilx, menzily);
             

        }
    }
        private void OnTriggerExit2D(Collider2D collision) {
            
            if (collision.tag == "mermi")
            {
                Destroy(collision.gameObject);
                




            }
        
    }
     



}
