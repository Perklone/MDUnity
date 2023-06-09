using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtTarget : MonoBehaviour
{
    public Transform Target;
    public float Speed = 1f;

    private Coroutine lookCoroutine;

    private void Start()
    {
        
    }

    private void Update()
    {
                Target = FindObjectOfType<Player>().transform;

        Vector3 targetDirection = Target.position - transform.position;
        targetDirection.y = 0.0f;
        transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.LookRotation(targetDirection), Time.time * Speed);
        // StartRotating();
    }

    public void StartRotating()
    {
        if (lookCoroutine != null)
        {
            StopCoroutine(lookCoroutine);
        }

        lookCoroutine = StartCoroutine(LookAt());
    }

    private IEnumerator LookAt()
    {
        Target = FindObjectOfType<Player>().transform;
        Quaternion lookRotation = Quaternion.LookRotation(Target.position - transform.position);
        lookRotation = Quaternion.Euler(transform.rotation.eulerAngles.x, lookRotation.eulerAngles.y,
            transform.rotation.eulerAngles.z);
        float time = 0;
        while (time < 1)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, time);
            time += Time.deltaTime * Speed;
            yield return null;
        }
    }

}
