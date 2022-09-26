using UnityEngine;
using Zenject;

public class InventoryManagerInstaller : Installer<InventoryManagerInstaller>
{
    [SerializeField] private InventoryManager inventoryManager;

    public override void InstallBindings()
    {
    }
}