using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class RunInBackground : MonoBehaviour {

	// Use this for initialization
	void Start () {
	  Application.runInBackground = true;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
