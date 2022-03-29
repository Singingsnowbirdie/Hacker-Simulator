using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ring : MonoBehaviour
{
    Transform myTransform;
    int position;

    public int Pos { get => position; }

    void Start()
    {
        myTransform = transform;
        position = Random.Range(0, 10);
        Turn();
    }

    public void SetPos(int pos)
    {
        position += pos;
        if (position >= 10)
        {
            position -= 10;
        }
        else if (position < 0)
        {
            position += 10;
        }

        Turn();
    }

    void Turn()
    {
        myTransform.rotation = Quaternion.Euler(new Vector3(0, 0, position * 36));
    }

}
