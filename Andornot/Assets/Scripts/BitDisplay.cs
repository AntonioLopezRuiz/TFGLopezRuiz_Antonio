using UnityEngine;

public class BitDisplay : LogicalElement
{
    private TextMesh text;
    private int value;
    public string tag;

    protected override void Awake()
    {
        text = GetComponentInChildren<TextMesh>();
        base.Awake();

    }

    public void setValue()
    {
        value = (inPoints[0].In == null ? 0 : inPoints[0].In.value);
        
    }

    public string returnTag()
    {
        return tag;
    }

    public int getValue()
    {
        return value;
    }

    protected override void ValueSet()
    {
        base.ValueSet();
        text.text = (inPoints[0].In == null ? 0 : inPoints[0].In.value).ToString();
        setValue();
    }
}
