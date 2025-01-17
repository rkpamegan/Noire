﻿using UnityEngine;
using Ink.Runtime;

public class InteractableExamine : InteractableObject
{
    [TextArea(3, 5)] [SerializeField] private string examineText;
    public override void Interact()
    {
        interactionsOccured++;
        ExamineUI.Instance.Display(examineText);
        FinishInteract();
    }
}