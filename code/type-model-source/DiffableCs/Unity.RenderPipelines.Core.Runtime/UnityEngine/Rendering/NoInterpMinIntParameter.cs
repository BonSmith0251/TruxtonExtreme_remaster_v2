namespace UnityEngine.Rendering;

[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
[Token(Token = "0x2000204")]
public class NoInterpMinIntParameter : VolumeParameter<Int32>
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000984")]
	public int min; //Field offset: 0x20

	[Token(Token = "0x170001EC")]
	public virtual int value
	{
		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[Token(Token = "0x6000F19")]
		 get { } //Length: 4
		[Address(RVA = "0x2C62EC0", Offset = "0x2C622C0", Length = "0xC")]
		[Token(Token = "0x6000F1A")]
		 set { } //Length: 12
	}

	[Address(RVA = "0x2C634D0", Offset = "0x2C628D0", Length = "0x69")]
	[Token(Token = "0x6000F1B")]
	public NoInterpMinIntParameter(int value, int min, bool overrideState = false) { }

	[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
	[Token(Token = "0x6000F19")]
	public virtual int get_value() { }

	[Address(RVA = "0x2C62EC0", Offset = "0x2C622C0", Length = "0xC")]
	[Token(Token = "0x6000F1A")]
	public virtual void set_value(int value) { }

}

