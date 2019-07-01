
using UnityEngine;

public class EditableOut : LogicalElement
{
    public string tag;


    public string returnTag()
    {
        return tag;
    }



    public byte value
    {
        get { return _value; }
        set
        {
            _value = value;
            for (int i = 0; i < outPoints.Length; i++)
            {
                outPoints[i].value = value;
            }
            GetComponentInChildren<TextMesh>().text = value.ToString();
        }
    }
    private byte _value;
}

