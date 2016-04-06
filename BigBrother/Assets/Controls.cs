using UnityEngine;
using System.Collections;

public class Controls : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyUp(KeyCode.RightArrow)) gameObject.transform.Translate(new Vector3(1f, 0, 0));
        if (Input.GetKeyUp(KeyCode.LeftArrow)) gameObject.transform.Translate(new Vector3(-1f, 0, 0));
        if (Input.GetKeyUp(KeyCode.UpArrow)) gameObject.transform.Translate(new Vector3(0, 1f, 0));
    }
}
