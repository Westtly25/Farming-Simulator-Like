using UnityEngine;

[System.Serializable]
public class ItemDetails : IItemDetails
{
    public int itemCode;
    public ItemType itemType;
    public string itemDescription;
    public Sprite itemSprite;
    public string itemLongDescription;
    public short itemUseGridRadius;
    public float itemUseRadius;
    public bool isStartingItem;
    public bool canBePickedUp;
    public bool canBeDropped;
    public bool canBeEaten;
    public bool canBeCarried;

    public int ItemCode
    {
        get => itemCode;
        set => itemCode = value;
    }
    public ItemType ItemType
    {
        get => itemType;
        set => itemType = value;
    }
    public string ItemDescription
    {
        get => itemDescription;
        set => itemDescription = value;
    }
    public Sprite ItemSprite
    {
        get => itemSprite;
        set => itemSprite = value;
    }
    public string ItemLongDescription
    {
        get => itemLongDescription;
        set => itemLongDescription = value;
    }
    public short ItemUseGridRadius
    {
        get => itemUseGridRadius;
        set => itemUseGridRadius = value;
    }
    public float ItemUseRadius
    {
        get => itemUseRadius;
        set => itemUseRadius = value;
    }
    public bool IsStartingItem
    {
        get => isStartingItem;
        set => isStartingItem = value;
    }
    public bool CanBePickedUp
    {
        get => canBePickedUp;
        set => canBePickedUp = value;
    }
    public bool CanBeDropped
    {
        get => canBeDropped;
        set => canBeDropped = value;
    }
    public bool CanBeEaten
    {
        get => canBeEaten;
        set => canBeEaten = value;
    }
    public bool CanBeCarried
    {
        get => canBeCarried;
        set => canBeCarried = value;
    }
}
