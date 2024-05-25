using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterDescriptionChanger : MonoBehaviour
{
    public Dropdown dropD;

    public Text characterDescriptionText;

    public string maleCharacterDescription = "Bjorn Ironfist, son of Regnar the Third, was a renowned medieval warrior celebrated for his strength and skill in combat. Standing tall and imposing, he wielded his war hammer with unmatched ferocity, earning him the moniker 'Ironfist.' Victorious in battles that defined his era, including the famous duel with Thorgar the Merciless, Bjorn's leadership united clans and secured his kingdom's prosperity. Yet, his legacy extended beyond the battlefield; he was revered for his sense of justice and dedication to his people, ushering in an era of peace and prosperity. Today, his name echoes through history as a symbol of courage and valor.";
    public string femaleCharacterDescription = "Freya Swiftblade, daughter of the legendary warrior queen Astrid, was known for her unmatched agility and cunning on the battlefield. Leading her people with a sharp mind and even sharper blade, she orchestrated numerous victories that turned the tides of war. Freya's tactical brilliance and unwavering courage earned her a place in the annals of history. Beyond her prowess in combat, she was a beacon of hope and wisdom, guiding her people through times of peace and conflict alike. Her legacy endures as a paragon of strength and intellect.";

    void Start()
    {
        dropD.onValueChanged.AddListener(delegate
        {
            DropdownValueChanged(dropD);
        });
        characterDescriptionText.text = maleCharacterDescription;
    }

    void DropdownValueChanged(Dropdown change)
    {
        if(change.value == 0)
        {
            characterDescriptionText.text = maleCharacterDescription;
        }
        else if (change.value == 1)
        {
            characterDescriptionText.text = femaleCharacterDescription;
        }
    }
}
