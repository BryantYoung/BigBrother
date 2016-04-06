using UnityEngine;
using System.Collections;

public class PlayerTrigger : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnTriggerEnter2D(Collider2D theOtherObjectsCollider)
    {
        gameObject.transform.parent = theOtherObjectsCollider.gameObject.transform;
    }
    void OnTriggerExit2D(Collider2D theOtherObjectsCollider)
    {
        gameObject.transform.parent = null;
    }
}
