using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class ScaleController : MonoBehaviour
{
    

    public  Vector3 playerChange;



    private void OnTriggerEnter(Collider other)
    {
        var localScale = other.gameObject.transform.localScale;
        Debug.Log(localScale);
        var playerScale = localScale;
        if (!other.CompareTag("Player")) return;
        other.gameObject.transform.DOScale(playerChange+playerScale, 1);

    }
}
