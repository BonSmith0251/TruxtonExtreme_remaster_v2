namespace Unity.Cinemachine;

[Obsolete("AxisBase has been deprecated. Use InputAxis instead.")]
[Token(Token = "0x200011B")]
public struct AxisBase
{
	[FieldOffset(Offset = "0x0")]
	[NoSaveDuringPlay]
	[Token(Token = "0x400049D")]
	[Tooltip("The current value of the axis.")]
	public float m_Value; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x400049E")]
	[Tooltip("The minimum value for the axis")]
	public float m_MinValue; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400049F")]
	[Tooltip("The maximum value for the axis")]
	public float m_MaxValue; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x40004A0")]
	[Tooltip("If checked, then the axis will wrap around at the min/max values, forming a loop")]
	public bool m_Wrap; //Field offset: 0xC

	[Address(RVA = "0x2869B70", Offset = "0x2868F70", Length = "0x26")]
	[Token(Token = "0x6000576")]
	public void Validate() { }

}

