namespace UnityEngine;

[Token(Token = "0x2000131")]
[UsedByNativeCode]
public struct BoneWeight : IEquatable<BoneWeight>
{
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x40003ED")]
	private float m_Weight0; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[SerializeField]
	[Token(Token = "0x40003EE")]
	private float m_Weight1; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[SerializeField]
	[Token(Token = "0x40003EF")]
	private float m_Weight2; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[SerializeField]
	[Token(Token = "0x40003F0")]
	private float m_Weight3; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	[Token(Token = "0x40003F1")]
	private int m_BoneIndex0; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[SerializeField]
	[Token(Token = "0x40003F2")]
	private int m_BoneIndex1; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x40003F3")]
	private int m_BoneIndex2; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	[Token(Token = "0x40003F4")]
	private int m_BoneIndex3; //Field offset: 0x1C

	[Token(Token = "0x17000202")]
	public int boneIndex0
	{
		[Address(RVA = "0x2FE30B0", Offset = "0x2FE24B0", Length = "0x6")]
		[Token(Token = "0x6000D4F")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000203")]
	public int boneIndex1
	{
		[Address(RVA = "0x1963AC0", Offset = "0x1962EC0", Length = "0x6")]
		[Token(Token = "0x6000D50")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000204")]
	public int boneIndex2
	{
		[Address(RVA = "0xE0D7C0", Offset = "0xE0CBC0", Length = "0x6")]
		[Token(Token = "0x6000D51")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000205")]
	public int boneIndex3
	{
		[Address(RVA = "0x1C18DC0", Offset = "0x1C181C0", Length = "0x6")]
		[Token(Token = "0x6000D52")]
		 get { } //Length: 6
	}

	[Token(Token = "0x170001FE")]
	public float weight0
	{
		[Address(RVA = "0x2FE30A0", Offset = "0x2FE24A0", Length = "0x7")]
		[Token(Token = "0x6000D4B")]
		 get { } //Length: 7
	}

	[Token(Token = "0x170001FF")]
	public float weight1
	{
		[Address(RVA = "0x2FB47B0", Offset = "0x2FB3BB0", Length = "0x8")]
		[Token(Token = "0x6000D4C")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000200")]
	public float weight2
	{
		[Address(RVA = "0x2FE3090", Offset = "0x2FE2490", Length = "0x8")]
		[Token(Token = "0x6000D4D")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000201")]
	public float weight3
	{
		[Address(RVA = "0x2FB4CA0", Offset = "0x2FB40A0", Length = "0x8")]
		[Token(Token = "0x6000D4E")]
		 get { } //Length: 8
	}

	[Address(RVA = "0x301BFA0", Offset = "0x301B3A0", Length = "0x99")]
	[Token(Token = "0x6000D54")]
	public virtual bool Equals(object other) { }

	[Address(RVA = "0x301BED0", Offset = "0x301B2D0", Length = "0xCF")]
	[Token(Token = "0x6000D55")]
	public override bool Equals(BoneWeight other) { }

	[Address(RVA = "0x2FE30B0", Offset = "0x2FE24B0", Length = "0x6")]
	[Token(Token = "0x6000D4F")]
	public int get_boneIndex0() { }

	[Address(RVA = "0x1963AC0", Offset = "0x1962EC0", Length = "0x6")]
	[Token(Token = "0x6000D50")]
	public int get_boneIndex1() { }

	[Address(RVA = "0xE0D7C0", Offset = "0xE0CBC0", Length = "0x6")]
	[Token(Token = "0x6000D51")]
	public int get_boneIndex2() { }

	[Address(RVA = "0x1C18DC0", Offset = "0x1C181C0", Length = "0x6")]
	[Token(Token = "0x6000D52")]
	public int get_boneIndex3() { }

	[Address(RVA = "0x2FE30A0", Offset = "0x2FE24A0", Length = "0x7")]
	[Token(Token = "0x6000D4B")]
	public float get_weight0() { }

	[Address(RVA = "0x2FB47B0", Offset = "0x2FB3BB0", Length = "0x8")]
	[Token(Token = "0x6000D4C")]
	public float get_weight1() { }

	[Address(RVA = "0x2FE3090", Offset = "0x2FE2490", Length = "0x8")]
	[Token(Token = "0x6000D4D")]
	public float get_weight2() { }

	[Address(RVA = "0x2FB4CA0", Offset = "0x2FB40A0", Length = "0x8")]
	[Token(Token = "0x6000D4E")]
	public float get_weight3() { }

	[Address(RVA = "0x301C040", Offset = "0x301B440", Length = "0x115")]
	[Token(Token = "0x6000D53")]
	public virtual int GetHashCode() { }

}

