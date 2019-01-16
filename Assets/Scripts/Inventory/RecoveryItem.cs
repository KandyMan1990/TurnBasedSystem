using UnityEngine;

[CreateAssetMenu(fileName = "Recovery Item", menuName = "RPG/Item/Recovery Item")]
public class RecoveryItem : BaseItem
{
    [SerializeField]
    int healAmountValue;
    [SerializeField]
    [Range(0f, 1f)]
    float healAmountPercent;
    [SerializeField]
    bool partyItem;
    // [SerializeField]
    // BaseStatus[] statusToRemove;

    public override bool Use()
    {
        throw new System.NotImplementedException();
    }
}
