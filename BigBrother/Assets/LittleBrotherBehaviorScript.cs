using UnityEngine;
using System.Collections;

public class LittleBrotherBehaviorScript : MonoBehaviour {
    GameObject target;
    float lastTime;
	// Use this for initialization
	void Start () {
        target = GameObject.Find("Player");
        lastTime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
        gameObject.transform.Translate(new Vector3(-.05f, 0, 0));
        if (Time.time - lastTime <= 2)
        {
            if (gameObject.transform.position.y > target.transform.position.y) gameObject.transform.Translate(new Vector3(0, -.25f, 0));
            else if (gameObject.transform.position.y < target.transform.position.y) gameObject.transform.Translate(new Vector3(0, .25f, 0));
        }
        else
        {
            if (Time.time - lastTime > 4)
                lastTime = Time.time;
        }       
    }
}
