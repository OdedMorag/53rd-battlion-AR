using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class informationTextManager : MonoBehaviour
{
    [SerializeField]
    private Button nextButton;
    [SerializeField]
    private Button backButton;
    [SerializeField]
    private TextMeshProUGUI text;

    private int textCounter = 0;
    string[] texts =
        {"The battles on Tel Fars - the mountain that dominates the Raphid intersection, from where traffic routes extend to the center of the Golan and its south. In the Six Day War, IDF forces from all fronts of the Golan were hit at the foot of the mountain, thus sealing the occupation of the Golan.\r\n\r\nDuring the Yom Kippur War, the Syrian army advanced along these lines, bypassing Mount Perat from the north and south. A day before the outbreak of war (October 5, 1973), an artillery battery composed of fighters from the artillery school in Shveta arrived in the Tel Peres area.\r\n\r\nOn the first day of fighting, the battery bombarded the Syrian enemy and provided supporting fire to the Israeli infantry positions. At midnight on the first night of the fighting, an order was given to evacuate the hill and move further west, but the battery delayed. Only after two hours did they begin withdrawing from the hill area. A convoy of 7 vehicles left the position, and on their way west, they encountered a Syrian armored battalion that had arrived at a night camp. The first two vehicles in the convoy surged forward, while the last two retreated back to their position. The three vehicles in the middle of the convoy were damaged.\r\nIn this battle, 15 fighters fell, and 12 were wounded. The vehicles that surged forward retreated to the west and joined our forces in the Ma'ale Gamla area.\r",
        "As part of the Syrian attempts to take control of the hill, they tried to land four helicopters, including commando units, on it on the second day of fighting. The first two helicopters were shot down by our forces' fire, while the fighters of the third helicopter, which managed to land on the southern slopes of the mountain, were sniped from the top of the hill. The fourth helicopter's traces disappeared, and the decision was made to land an artillery shell on the hill to destroy the commando units.\r\n\r\nThe IDF soldiers who were in the post at the top of the hill - paratroopers, gunners, Modi'in, and anti-aircraft units - began to descend towards the volcanic escarpment from the south and joined forces with the 188 under the command of the 53rd Brigade. Towards the end, the brigade received approval from the command's general officer to clear the mound and move west.\r\n\r\nOn the same day, a battalion of the Syrian 1st Armored Division captured the hill. Syrian artillery observation officers were stationed on the hill, overseeing the entire southern Golan Heights, making it very difficult for the command to counterattack in the area. It wasn't until October 8 that IDF soldiers from the 205th Brigade returned and recaptured the hill from the Syrian patrol."};

    public void ShowText()
    {
        bool isTextActive = text.gameObject.activeSelf;
        text.gameObject.SetActive(!isTextActive);
        text.text = texts[textCounter];
    }

    public void NextText()
    {
        if (!(textCounter == 1))
            textCounter++;
        text.text = texts[textCounter];
    }

    public void BackText()
    {
        if (!(textCounter == 0))
            textCounter--;
        text.text = texts[textCounter];
    }
}
