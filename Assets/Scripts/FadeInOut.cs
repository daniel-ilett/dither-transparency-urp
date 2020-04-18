using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Renderer))]
public class FadeInOut : MonoBehaviour
{
    [SerializeField] private float speed = 1.0f;

    private new Renderer renderer;

    private void Awake()
    {
        renderer = GetComponent<Renderer>();
    }

    private void Update()
    {
        var opacity = (Mathf.Sin(Time.time * speed) + 1.0f) / 2.0f;
        renderer.material.SetFloat("_Opacity", opacity);
    }
}
