using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamereControl : MonoBehaviour
{
   [SerializeField] private Transform target;
   [SerializeField] private float smoothTime = 5;
   private Vector3 offset;
   
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - target.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (target == null)
            return;
        Vector3 cameraTarget = target.position + offset;
        transform.position = Vector3.Lerp(transform.position, cameraTarget, smoothTime * Time.deltaTime);
    }
}
