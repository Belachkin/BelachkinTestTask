using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    Inventory inventory;

    private void Start()
    {
        inventory = Inventory.Instance;
        inventory.onChange += UpdateUI;
    }

    private void Update()
    {
        
    }

    private void UpdateUI()
    {

    }
}
