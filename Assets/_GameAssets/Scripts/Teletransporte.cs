using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Teletransporte : MonoBehaviour
{
    void OnTriggerEnter(Collider c){
        if (c.gameObject.CompareTag("Player")){
            bool tieneLlave = c.gameObject.GetComponent<Inventario>().HasItem("LlavePoder");
            if (tieneLlave){
                SceneManager.LoadScene("InteriorScene");
            }
        }
    }
}
