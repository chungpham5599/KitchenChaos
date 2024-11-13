using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private const string OPEN_CLOSE = "OpenClose";
    private Animator animator;
    [SerializeField] private ContainterCounter containerCounter;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void Start()
    {
        containerCounter.OnKitchenObjectGrabbed += ContainterCounter_OnKitchenObjectGrabbed;
    }

    private void ContainterCounter_OnKitchenObjectGrabbed(object sender, System.EventArgs e)
    {
        animator.SetTrigger(OPEN_CLOSE);
    }
}
