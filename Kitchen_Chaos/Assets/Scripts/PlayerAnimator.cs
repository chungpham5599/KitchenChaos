using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    private static readonly int IS_WALKING = Animator.StringToHash("IsWalking");
    private Animator animator;
    [SerializeField] Player player;

    private void Awake() 
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        animator.SetBool(IS_WALKING, player.IsWalking());
    }
}
