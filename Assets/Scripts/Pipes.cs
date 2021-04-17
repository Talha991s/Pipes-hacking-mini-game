using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipes : MonoBehaviour
{
    public float correctRotation;
    [SerializeField]bool isPlaced = false;
    float[] rotations = { 0, 90, 180, 270 };
    private void Start()
    {
        int rand = Random.Range(0, rotations.Length);
        transform.eulerAngles = new Vector3(0, 0, rotations[rand]);

        if (transform.eulerAngles.z == correctRotation )
        {
            isPlaced = true;
        }

    }
    private void OnMouseDown()
    {
        transform.Rotate(new Vector3(0, 0, 90));
        if(transform.eulerAngles.z == correctRotation&&isPlaced==false)
        {
            isPlaced = true;
        }
        else if(isPlaced==true)
        {
            isPlaced = false;
        }
    }

}
