using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CatBehaviour : MonoBehaviour
{
    public Animator Animator;
    public float CatScareDistance = 2.0f;

    private FirstPersonDrifter _player;
    // Start is called before the first frame update
    void Start()
    {
        _player = FindObjectOfType<FirstPersonDrifter>();
        _player = GameObject.FindWithTag("MyPlayer").GetComponent<FirstPersonDrifter>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 vecToPlayer = _player.transform.position - transform.position;

        vecToPlayer.y = 0.0f;

        float distToPlayer = vecToPlayer.magnitude;

        if(distToPlayer < CatScareDistance)
        {
            Animator.SetBool("Walking", true);
        }
        else
        {
            Animator.SetBool("Walking", false);
        }
    }
}
