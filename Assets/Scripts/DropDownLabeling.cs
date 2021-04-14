using UnityEngine;
using UnityEngine.UI;
public class DropDownLabeling : MonoBehaviour
{
    public Dropdown Label;
    private Text LabelText;

    private void Start()
    {
        LabelText = gameObject.GetComponent<Text>();
    }
    private void Update()
    {
        switch(Label.value)
        {
            case 0:
                LabelText.text = "Low";
                break;
            case 1:
                LabelText.text = "Medium";
                break;
            case 2:
                LabelText.text = "High";
                break;
        }
    }
}
