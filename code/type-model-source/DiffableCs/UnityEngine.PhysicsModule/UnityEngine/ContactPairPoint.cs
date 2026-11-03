namespace UnityEngine;

[IsReadOnly]
[Token(Token = "0x2000016")]
[UsedByNativeCode]
public struct ContactPairPoint
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000052")]
	internal readonly Vector3 m_Position; //Field offset: 0x0
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000053")]
	internal readonly float m_Separation; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000054")]
	internal readonly Vector3 m_Normal; //Field offset: 0x10
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000055")]
	internal readonly uint m_InternalFaceIndex0; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000056")]
	internal readonly Vector3 m_Impulse; //Field offset: 0x20
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000057")]
	internal readonly uint m_InternalFaceIndex1; //Field offset: 0x2C

	[Token(Token = "0x17000026")]
	public Vector3 impulse
	{
		[Address(RVA = "0x1D53450", Offset = "0x1D52850", Length = "0x13")]
		[Token(Token = "0x6000094")]
		 get { } //Length: 19
	}

	[Token(Token = "0x17000025")]
	public Vector3 normal
	{
		[Address(RVA = "0x6620A0", Offset = "0x6614A0", Length = "0x13")]
		[Token(Token = "0x6000093")]
		 get { } //Length: 19
	}

	[Token(Token = "0x17000023")]
	public Vector3 position
	{
		[Address(RVA = "0xAEF0B0", Offset = "0xAEE4B0", Length = "0x12")]
		[Token(Token = "0x6000091")]
		 get { } //Length: 18
	}

	[Token(Token = "0x17000024")]
	public float separation
	{
		[Address(RVA = "0x5AA530", Offset = "0x5A9930", Length = "0x6")]
		[Token(Token = "0x6000092")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x1D53450", Offset = "0x1D52850", Length = "0x13")]
	[Token(Token = "0x6000094")]
	public Vector3 get_impulse() { }

	[Address(RVA = "0x6620A0", Offset = "0x6614A0", Length = "0x13")]
	[Token(Token = "0x6000093")]
	public Vector3 get_normal() { }

	[Address(RVA = "0xAEF0B0", Offset = "0xAEE4B0", Length = "0x12")]
	[Token(Token = "0x6000091")]
	public Vector3 get_position() { }

	[Address(RVA = "0x5AA530", Offset = "0x5A9930", Length = "0x6")]
	[Token(Token = "0x6000092")]
	public float get_separation() { }

}

