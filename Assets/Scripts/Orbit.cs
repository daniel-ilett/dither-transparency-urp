using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbit : MonoBehaviour
{
    [SerializeField] private Transform orbitObject;
    [SerializeField] private float orbitSize;
    [SerializeField] private float orbitOffset;

    private void Update()
    {
        var time = Time.time * Mathf.PI * 0.25f;

        var xPos = orbitObject.position.x + Mathf.Sin(time) * orbitSize;
        var yPos = orbitObject.position.y + orbitOffset;
        var zPos = orbitObject.position.z + Mathf.Cos(time) * orbitSize;

        transform.position = new Vector3(xPos, yPos, zPos);
        transform.LookAt(orbitObject);
    }
}
