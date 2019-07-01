public class XorLogicalElement : LogicalElement
{
    protected override void ValueSet()
    {
        base.ValueSet();
        byte end;

        if ((inPoints[0].In != null && inPoints[0].In.value == 0) && (inPoints[0].In != null && inPoints[1].In.value != 0))
            end = 1;
        else if ((inPoints[0].In != null && inPoints[0].In.value != 0) && (inPoints[0].In != null && inPoints[1].In.value == 0))
            end = 1;
        else
            end = 0; ;

        outPoints[0].value = end;
    }
}
