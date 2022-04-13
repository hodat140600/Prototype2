using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "Player")
        {
            GameManager._instance.AddLive(-1);
            Debug.Log("Player Lives: " + GameManager._instance.playerLife);
            Destroy(gameObject);
        }
        else if(other.tag == "Animal")
        {
            other.GetComponent<AnimalHunger>().FeedAnimal(1);
           
            Destroy(gameObject);
        }
    }
}
