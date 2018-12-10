using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseCS : MonoBehaviour {

    private void OnCollisionEnter(Collision c)
    {
        if (c.gameObject.tag == "Player")
        {
            UIManager.victory = true;
        }
    }
}
