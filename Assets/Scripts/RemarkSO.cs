using UnityEngine;

[CreateAssetMenu(fileName = "RemarkReaction", menuName = "ScriptableObjects/SpawnRemarkReaction", order = 1)]
public class RemarkSO: ScriptableObject
{
    public int ID;
    public string Header;
    public string MainText;
}