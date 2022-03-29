using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecorCircleRotator : MonoBehaviour
{
    [SerializeField] float i;
    Transform myTransform;

    private void Start()
    {
        myTransform = transform;
    }

    void Update()
    {
        myTransform.Rotate(new Vector3(0, 0, i) * Time.deltaTime);
    }
}
