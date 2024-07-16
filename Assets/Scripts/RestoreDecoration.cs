using Cinemachine.Utility;
using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class RestoreDecoration : MonoBehaviour
{
    [SerializeField] private float restoreRadius;
    private Transform[] childGameObject;
    private string destroyDecorationTag = "DestroyDecoration";
    [SerializeField] private List<Vector3> initialTransform = new List<Vector3>();
    void Update()
    {
        if (Input.GetKey(KeyCode.H))
        {
            RestoreDecorations();
        }
    }

    private void RestoreDecorations()
    {
        var foundDestroyDecoration = Physics.OverlapSphere(transform.position, restoreRadius)
          .Where(t => t.tag == destroyDecorationTag).ToList();
        foreach (var foundDecoration in foundDestroyDecoration)
        {
            initialTransform = foundDecoration.GetComponent<DestroyObjectsTransformList>().GetVector3LocalPosition();
            childGameObject = foundDecoration.GetComponentsInChildren<Transform>();
            for(int i = 1; i< childGameObject.Length; i++)
            {
                // childGameObject[i].transform.localPosition = initialTransform[i];
                childGameObject[i].DOLocalMove(initialTransform[i],2);
                childGameObject[i].transform.rotation = Quaternion.identity;
                childGameObject[i].GetComponent<Rigidbody>().isKinematic = true;
            }
            foundDecoration.GetComponent<BoxCollider>().isTrigger = false;
        }
    }
}
