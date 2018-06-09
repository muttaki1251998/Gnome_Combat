using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollower : MonoBehaviour {

    [SerializeField]
    Transform target;
    [SerializeField]
    private float smoothing = 5.0f;

    Vector3 offset;

    private void Awake()
    {
        //Assert.IsNotNull(target);
    }

    // Use this for initialization
    void Start () {
        offset = transform.position - target.position;
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 cameraPos = target.position + offset;
        transform.position = Vector3.Lerp(transform.position, cameraPos, smoothing * Time.deltaTime);
	}
}
