using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class SaveTranform : MonoBehaviour
{
    private Transform childObjectTranform;
    private void Awake()
    {
        childObjectTranform = transform;
    }

    public void RestoreTransfom()
    {
        transform.DOMove(new Vector3(0,0,0), 1);
        Debug.Log(childObjectTranform.name);
        
    }
}
