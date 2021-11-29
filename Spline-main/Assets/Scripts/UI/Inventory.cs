using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Inventory : MonoBehaviour
{
    #region Header
    [Header ("Collectibles")]
    public int formsTouch;
    public Text formsTouchText;
    #endregion

    #region API
    public static Inventory instance;
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
    #endregion
}
