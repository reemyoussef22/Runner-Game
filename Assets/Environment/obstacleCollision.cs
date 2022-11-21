using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacleCollision : MonoBehaviour
{

    public GameObject thePlayer;
    public GameObject charModel;
    public GameObject LevelControl;

    void OnTriggerEnter(Collider other)
    {
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        thePlayer.GetComponent<Player>().enabled = false;
        charModel.GetComponent<Animator>().Play("Stumble");
        LevelControl.GetComponent<EndRunSequence>().enabled = true;
       
    }



}
