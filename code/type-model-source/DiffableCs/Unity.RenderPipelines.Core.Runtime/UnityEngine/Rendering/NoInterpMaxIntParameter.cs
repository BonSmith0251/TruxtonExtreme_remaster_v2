namespace UnityEngine.Rendering;

[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
[Token(Token = "0x2000206")]
public class NoInterpMaxIntParameter : VolumeParameter<Int32>
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000986")]
	public int max; //Field offset: 0x20

	[Token(Token = "0x170001EE")]
	public virtual int value
	{
		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[Token(Token = "0x6000F1F")]
		 get { } //Length: 4
		[Address(RVA = "0x2C61D60", Offset = "0x2C61160", Length = "0xC")]
		[Token(Token = "0x6000F20")]
		 set { } //Length: 12
	}

	[Address(RVA = "0x2C633F0", Offset = "0x2C627F0", Length = "0x69")]
	[Token(Token = "0x6000F21")]
	public NoInterpMaxIntParameter(int value, int max, bool overrideState = false) { }

	[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
	[Token(Token = "0x6000F1F")]
	public virtual int get_value() { }

	[Address(RVA = "0x2C61D60", Offset = "0x2C61160", Length = "0xC")]
	[Token(Token = "0x6000F20")]
	public virtual void set_value(int value) { }

}

