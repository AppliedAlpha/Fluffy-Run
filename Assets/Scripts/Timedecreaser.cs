using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timedecreaser : MonoBehaviour
{

    [Header("����� �� �پ��� �ð�")]
    public float decreasing = 5f;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Character")
        {
            Destroy(gameObject);
            Debug.Log("���� �ð� -" + decreasing );

        }
    }

}
