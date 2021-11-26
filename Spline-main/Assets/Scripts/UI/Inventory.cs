using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public static Inventory instance;
    
    [Header ("Collectibles")]
    public int formsCount;
    public Text formsCountText;

    private void Awake() 
    {
        if(instance != null)
        {
            Debug.LogWarning("Il y a plus d'une instance de Inventory dans la scène");
            return;
        }

        instance = this;
    }

    public void AddForms(int count)
    {
        formsCount += count;
        formsCountText.text = formsCount.ToString();
    }
}

