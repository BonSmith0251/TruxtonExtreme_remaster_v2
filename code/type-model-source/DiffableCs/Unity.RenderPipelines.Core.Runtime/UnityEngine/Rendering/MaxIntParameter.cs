namespace UnityEngine.Rendering;

[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
[Token(Token = "0x2000205")]
public class MaxIntParameter : IntParameter
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000985")]
	public int max; //Field offset: 0x20

	[Token(Token = "0x170001ED")]
	public virtual int value
	{
		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[Token(Token = "0x6000F1C")]
		 get { } //Length: 4
		[Address(RVA = "0x2C61D60", Offset = "0x2C61160", Length = "0xC")]
		[Token(Token = "0x6000F1D")]
		 set { } //Length: 12
	}

	[Address(RVA = "0x2C61CF0", Offset = "0x2C610F0", Length = "0x69")]
	[Token(Token = "0x6000F1E")]
	public MaxIntParameter(int value, int max, bool overrideState = false) { }

	[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
	[Token(Token = "0x6000F1C")]
	public virtual int get_value() { }

	[Address(RVA = "0x2C61D60", Offset = "0x2C61160", Length = "0xC")]
	[Token(Token = "0x6000F1D")]
	public virtual void set_value(int value) { }

}

