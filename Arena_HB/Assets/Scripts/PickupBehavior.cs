using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupBehavior : MonoBehaviour 
 {
     public GameBehavior gameManager;
     GameObject size;
 
     void Start()
     {                
           gameManager = GameObject.Find("GameManager").GetComponent<GameBehavior>();
     }
 
     void OnCollisionEnter(Collision collision)
     {
         if (collision.gameObject.name == "Player")
         {
             int draw = Random.Range(0,2);
             Debug.Log(draw);
             if (draw == 1) 
             {
                RandomSize();
             }
             else
             {
                RandomColor();
             }
             Destroy(this.transform.parent.gameObject);
             Debug.Log("Item collected!");
 
             gameManager.Items += 1;
         }
     }

     void RandomColor()
     {
           var playerManager = GameObject.Find("Player").GetComponent<Renderer>();
           playerManager.material.SetColor("_Color", Color.cyan);
     }

     void RandomSize()
     {
         size = GameObject.Find("Player");
         size.gameObject.transform.localScale += new Vector3(1,1,1);
    }
 } 