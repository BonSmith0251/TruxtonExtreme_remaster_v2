namespace UnityEngine.Rendering;

[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
[Token(Token = "0x2000203")]
public class MinIntParameter : IntParameter
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000983")]
	public int min; //Field offset: 0x20

	[Token(Token = "0x170001EB")]
	public virtual int value
	{
		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[Token(Token = "0x6000F16")]
		 get { } //Length: 4
		[Address(RVA = "0x2C62EC0", Offset = "0x2C622C0", Length = "0xC")]
		[Token(Token = "0x6000F17")]
		 set { } //Length: 12
	}

	[Address(RVA = "0x2C61CF0", Offset = "0x2C610F0", Length = "0x69")]
	[Token(Token = "0x6000F18")]
	public MinIntParameter(int value, int min, bool overrideState = false) { }

	[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
	[Token(Token = "0x6000F16")]
	public virtual int get_value() { }

	[Address(RVA = "0x2C62EC0", Offset = "0x2C622C0", Length = "0xC")]
	[Token(Token = "0x6000F17")]
	public virtual void set_value(int value) { }

}

