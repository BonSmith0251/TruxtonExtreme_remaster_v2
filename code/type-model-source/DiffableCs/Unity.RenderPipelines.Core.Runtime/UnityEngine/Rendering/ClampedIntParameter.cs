namespace UnityEngine.Rendering;

[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
[Token(Token = "0x2000207")]
public class ClampedIntParameter : IntParameter
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000987")]
	public int min; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000988")]
	public int max; //Field offset: 0x24

	[Token(Token = "0x170001EF")]
	public virtual int value
	{
		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[Token(Token = "0x6000F22")]
		 get { } //Length: 4
		[Address(RVA = "0x2C542E0", Offset = "0x2C536E0", Length = "0x16")]
		[Token(Token = "0x6000F23")]
		 set { } //Length: 22
	}

	[Address(RVA = "0x2C54270", Offset = "0x2C53670", Length = "0x6D")]
	[Token(Token = "0x6000F24")]
	public ClampedIntParameter(int value, int min, int max, bool overrideState = false) { }

	[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
	[Token(Token = "0x6000F22")]
	public virtual int get_value() { }

	[Address(RVA = "0x2C542E0", Offset = "0x2C536E0", Length = "0x16")]
	[Token(Token = "0x6000F23")]
	public virtual void set_value(int value) { }

}

