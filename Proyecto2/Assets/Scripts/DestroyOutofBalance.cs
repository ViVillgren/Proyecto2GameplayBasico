using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutofBalance : MonoBehaviour
{
    private float upperLim = 30f;
    private float lowerLim = -5f;
    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > upperLim)
        {
            Destroy(gameObject);
        }

        if (transform.position.z < lowerLim)
        {
            player = GameObject.Find("Player");
            Destroy(player);
            Destroy(gameObject);
            Debug.Log($"GAME OVER!!");
            Time.timeScale = 0;

        }


    }
}
