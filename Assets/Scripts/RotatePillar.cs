using UnityEngine;
using System.Collections;

public class RotatePillar : MonoBehaviour {

    public GameObject rotatePoint;
    public float speed = 10f;
    void Update()
    {
        transform.RotateAround(rotatePoint.transform.position ,Vector3.up, speed * Time.deltaTime);
    }
}
