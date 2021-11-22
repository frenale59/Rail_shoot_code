using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Inventory : MonoBehaviour
{
    public static Inventory instance;

    [Header ("Collectibles")]
    public int formsTouch;
    public Text formsTouchText;

    private void Awake() 
    {
        if(instance != null)
        {
            Debug.LogWarning("Il y a plus d'une instance de Inventory dans la scène");
            return;
        }

        instance = this;
    }

    public void AddForms (int count)
    {
        formsTouch += count;
        formsTouchText.text = formsTouch.ToString();
    }
}
