using System;

[Flags]
public enum InventoryRestrictionMask : byte
{
    UNKNOWN = 0,
    SHOW_IN_ITEM_UNUSABLE = 1,
    SHOW_IN_ITEM_USABLE = 2,
    SHOW_EVERYWHERE_USABLE = 4
}
