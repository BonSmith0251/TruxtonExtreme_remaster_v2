namespace UnityEngine;

[NativeHeader("Modules/Animation/AnimatorInfo.h")]
[RequiredByNativeCode]
[Token(Token = "0x2000016")]
public struct AnimatorStateInfo
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400004C")]
	private int m_Name; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x400004D")]
	private int m_Path; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400004E")]
	private int m_FullPath; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x400004F")]
	private float m_NormalizedTime; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000050")]
	private float m_Length; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000051")]
	private float m_Speed; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000052")]
	private float m_SpeedMultiplier; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000053")]
	private int m_Tag; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000054")]
	private int m_Loop; //Field offset: 0x20

	[Token(Token = "0x17000013")]
	public int fullPathHash
	{
		[Address(RVA = "0xD18C70", Offset = "0xD18070", Length = "0x6")]
		[Token(Token = "0x6000069")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000015")]
	public float length
	{
		[Address(RVA = "0x2FB4C90", Offset = "0x2FB4090", Length = "0x8")]
		[Token(Token = "0x600006B")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000014")]
	public float normalizedTime
	{
		[Address(RVA = "0x2FB4CA0", Offset = "0x2FB40A0", Length = "0x8")]
		[Token(Token = "0x600006A")]
		 get { } //Length: 8
	}

	[Address(RVA = "0xD18C70", Offset = "0xD18070", Length = "0x6")]
	[Token(Token = "0x6000069")]
	public int get_fullPathHash() { }

	[Address(RVA = "0x2FB4C90", Offset = "0x2FB4090", Length = "0x8")]
	[Token(Token = "0x600006B")]
	public float get_length() { }

	[Address(RVA = "0x2FB4CA0", Offset = "0x2FB40A0", Length = "0x8")]
	[Token(Token = "0x600006A")]
	public float get_normalizedTime() { }

}

