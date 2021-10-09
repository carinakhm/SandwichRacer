using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using AudioBuddyTool;

public class ResetBinding : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private string control;
    [SerializeField] private string actionName;

    public void OnPointerClick(PointerEventData eventData)
    {
        if (control.Equals("")) Options.Instance.resetAllKeys();
        else Options.Instance.resetKey(control, actionName);

        AudioBuddy.Play("button_2", Options.Instance.EffectVolume);
    }
}
