
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class DiceRoll : MonoBehaviour
{
    public GameObject TextBox;
    public int TheNumber;
    
    public void RandomGenerate()
    {
        TheNumber = Random.Range(1, 7);
        TextBox.GetComponent<TMP_Text>().text = "" + TheNumber;
    }
   
}
