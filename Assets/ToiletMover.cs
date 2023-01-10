using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToiletMover : MonoBehaviour
{
    private Vector3 startPosition;
    public Vector3 moveDirection;
    public float maxDist;
    public bool directionForward = true;
    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if ((transform.position - startPosition).magnitude >= maxDist)
            directionForward ^= true;
        transform.position += (directionForward ? 1 : -1) * Time.deltaTime * moveDirection;
    }
}
