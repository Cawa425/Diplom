using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using PixelCrushers.DialogueSystem;
using TMPro;
using UnityEngine;

public class RemarkOpener : MonoBehaviour
{
    public GameObject UIToShow;
    public TextMeshPro Header;
    public TextMeshPro mainText;
    public List<RemarkSO> reactions;

    public void ShowUI(int lastID)
    {
        var last = reactions.FirstOrDefault(x => x.ID == lastID);
        if (last != null)
        {
            Header.text = last.Header;
            mainText.text = last.MainText;
        }
        UIToShow.SetActive(true);
    }

    private void OnEnable()
    {
        var lastID = DialogueLua.GetVariable("RemarkIdToShow").asInt;
        ShowUI(lastID);
    }
}
