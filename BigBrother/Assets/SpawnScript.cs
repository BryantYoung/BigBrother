using UnityEngine;
using System.Collections;

public class SpawnScript : MonoBehaviour {
    float lastTime;
    public GameObject spawn;
	// Use this for initialization
	void Start () {
        lastTime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
        if (Time.time - lastTime > 3)
        {
            Instantiate(spawn, gameObject.transform.position,Quaternion.identity);
            lastTime = Time.time;
        }
	
	}
}
