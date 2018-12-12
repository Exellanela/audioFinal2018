using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnLightTriggersCS : MonoBehaviour {

    GameObject player;
    GameObject flashlight;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        flashlight = GameObject.FindGameObjectWithTag("Light");
    }

    /*
    // Use this for initialization
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Ray ray = new Ray(player.transform.position, flashlight.transform.forward);
            RaycastHit rayHit = new RaycastHit();
            Debug.DrawRay(ray.origin, ray.direction*400, Color.cyan);
            if (Physics.Raycast(ray, out rayHit))
            {

                //Debug.Log("HIT" + rayHit.collider.gameObject.name);
                if (rayHit.collider.CompareTag("Enemy"))
                {
                    var enemyComponent = rayHit.collider.GetComponent<Ene2>();
                    enemyComponent.beingHit = true;
                    enemyComponent.DecreaseLife();
                } 
            }
        }
    }

    
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            /*
            Ray ray = new Ray(player.transform.position, flashlight.transform.forward);
            RaycastHit rayHit = new RaycastHit();
            Debug.DrawRay(ray.origin, ray.direction*400, Color.green);
            if (Physics.Raycast(ray, out rayHit))
            {
                //Debug.Log("HIT" + rayHit.collider.gameObject.name);
                if (rayHit.collider.CompareTag("Enemy"))
                {
                    var enemyComponent = rayHit.collider.GetComponent<Ene2>();
                    enemyComponent.meshOn = false;
                    enemyComponent.able2move = true;
                }
            }
            
        }
    }
    */
}
