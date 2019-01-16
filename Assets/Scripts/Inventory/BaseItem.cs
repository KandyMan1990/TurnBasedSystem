using UnityEngine;

public abstract class BaseItem : ScriptableObject
{
    [SerializeField]
    string description;
    [SerializeField]
    int cost;
    [SerializeField]
    Sprite icon;

    public string Description { get => description; }
    public int Cost { get => cost; }
    public Sprite Icon { get => icon; }

    public abstract bool Use();
}
