using UnityEngine;
using Zenject;

public class InventoryManagerInstaller : MonoInstaller<InventoryManagerInstaller>
{
    [SerializeField] private InventoryManager inventoryManager;

    public override void InstallBindings()
    {
        Container.Bind<IInventoryManager>().FromInstance(inventoryManager).AsSingle().NonLazy();
    }
}