using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;


public class Tweening : MonoBehaviour
{

    public Transform theDoor;
    public float endPositionY = -90f;
    public float endPositionY2 = 0f;
    public GameObject canvas;
    // public GameObject button1;

    public void openDoor()
    {
        if (theDoor.transform.rotation.y != endPositionY)
        {
            theDoor
            .DOLocalRotate(new Vector3(0, endPositionY, 0), 3f);
            canvas.SetActive(false);
        }
        else
        {
            theDoor
            .DOLocalRotate(new Vector3(0, 0, 0), 3f);
        }

    }
}
