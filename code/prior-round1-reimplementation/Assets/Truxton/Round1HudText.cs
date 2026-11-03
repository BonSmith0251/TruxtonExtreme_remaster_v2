using UnityEngine;
using UnityEngine.UI;

public class Round1HudText : MonoBehaviour
{
    public Texture2D[] glyphs;
    public RawImage[] cells;
    public bool rightAligned;
    public string Value { get; private set; }="";
    public void SetText(string value,Color? tint=null)
    {
        Value=value;
        int offset=rightAligned?Mathf.Max(0,cells.Length-value.Length):0;
        for(int i=0;i<cells.Length;i++)
        {
            int character=i-offset;
            int index=character>=0 && character<value.Length?char.ToUpperInvariant(value[character])-33:-1;
            bool valid=index>=0 && index<glyphs.Length && glyphs[index];
            cells[i].enabled=valid;if(valid)cells[i].texture=glyphs[index];cells[i].color=tint??Color.white;
        }
    }
}
