using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime;
public class Dropper : MonoBehaviour {
    [Header("Set in Inspector")]
    // Prefab for instantiating drops
    public GameObject   dropPrefab;
    public GameObject   player;
    public float        secondsBetweenAppleDrops = 0.5f;
 void Start () {
        // Dropping apples every second
        Invoke( "Drop", 2f );
    }

void Drop() {      
        Vector3 pos = transform.position;                                            
        GameObject drop = Instantiate<GameObject>( dropPrefab );     
        drop.transform.position = transform.position;                  
        Invoke( "Drop", secondsBetweenAppleDrops );
        pos.x = Random.Range(-9, 9);
        pos.z = Random.Range(-9, 9);
        pos.y = 10;
        transform.position = pos;            
    }

 void Update () {

    }
void FixedUpdate() {
        
    }

}