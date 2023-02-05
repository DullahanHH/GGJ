using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Credits : MonoBehaviour
{
    public float speed = 1f;
    public ParticleSystem flyCube;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("StopParticle", 57);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * Time.deltaTime * speed);
    }

    void StopParticle()
    {
        flyCube.Stop();
    }
}
