using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class DestroyObjectsTransformList : MonoBehaviour
{
    [SerializeField] List<Transform> transformList = new List<Transform>();
    [SerializeField] List<Vector3> vector3List = new List<Vector3>();
    void Start()
    {
        transformList = GetComponentsInChildren<Transform>().ToList();
        foreach (Transform t in transformList)
        {
            vector3List.Add(t.localPosition);
        }
    }

    public List<Vector3> GetVector3LocalPosition()
    {
        return vector3List;
    }
}
