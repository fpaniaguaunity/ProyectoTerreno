using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Arma : MonoBehaviour
{
    public int capacidad = 100;
    public int municion = 0; 
    public float fuerza = 10;
    public GameObject prefabBala;
    public Transform transformSpawner;

    public void Start(){
        municion = capacidad;
    }
    public void IntentarDisparo(){
        if (municion>0){
            Disparar();
        }
    }
    private void Disparar(){
        municion--;
        GameObject bala = Instantiate(prefabBala,transformSpawner.position, transformSpawner.rotation);
        bala.GetComponent<Rigidbody>().AddForce(bala.transform.forward * fuerza);
    }

    public void Reload(){
        municion = capacidad;
    }
}
