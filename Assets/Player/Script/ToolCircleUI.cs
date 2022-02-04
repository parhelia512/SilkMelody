using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToolCircleUI : MonoBehaviour
{
    public Image circleImage;
    public Image toolImage;

    private void Update()
    {
        if (GameMaster.instance.equippedTools.Count == 0)
        {
            if (circleImage.enabled)
                circleImage.enabled = false;
            if (toolImage.enabled)
                toolImage.enabled = false;
            return;
        }
        else
        {
            if (!circleImage.enabled)
                circleImage.enabled = true;
            if (!toolImage.enabled)
                toolImage.enabled = true;

            int currentToolId = (int)GameMaster.instance.equippedTools[GameMaster.instance.selectedId];
            circleImage.fillAmount = GameMaster.instance.redToolsCurrentCharge[currentToolId] / GameMaster.instance.redToolData[currentToolId].maxCharge;

            // Update tool image
            if (toolImage.sprite != GameMaster.instance.redToolData[currentToolId].sprite)
                toolImage.sprite = GameMaster.instance.redToolData[currentToolId].sprite;
        }
    }
}