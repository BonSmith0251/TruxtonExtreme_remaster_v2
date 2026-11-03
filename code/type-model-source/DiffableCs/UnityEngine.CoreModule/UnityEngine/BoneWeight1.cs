namespace UnityEngine;

[Token(Token = "0x2000132")]
[UsedByNativeCode]
public struct BoneWeight1 : IEquatable<BoneWeight1>
{
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x40003F5")]
	private float m_Weight; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[SerializeField]
	[Token(Token = "0x40003F6")]
	private int m_BoneIndex; //Field offset: 0x4

	[Token(Token = "0x17000207")]
	public int boneIndex
	{
		[Address(RVA = "0xFD3C70", Offset = "0xFD3070", Length = "0x6")]
		[Token(Token = "0x6000D57")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000206")]
	public float weight
	{
		[Address(RVA = "0x2FE30A0", Offset = "0x2FE24A0", Length = "0x7")]
		[Token(Token = "0x6000D56")]
		 get { } //Length: 7
	}

	[Address(RVA = "0x301BDB0", Offset = "0x301B1B0", Length = "0xC1")]
	[Token(Token = "0x6000D58")]
	public virtual bool Equals(object other) { }

	[Address(RVA = "0x301BD50", Offset = "0x301B150", Length = "0x5A")]
	[Token(Token = "0x6000D59")]
	public override bool Equals(BoneWeight1 other) { }

	[Address(RVA = "0xFD3C70", Offset = "0xFD3070", Length = "0x6")]
	[Token(Token = "0x6000D57")]
	public int get_boneIndex() { }

	[Address(RVA = "0x2FE30A0", Offset = "0x2FE24A0", Length = "0x7")]
	[Token(Token = "0x6000D56")]
	public float get_weight() { }

	[Address(RVA = "0x301BE80", Offset = "0x301B280", Length = "0x4D")]
	[Token(Token = "0x6000D5A")]
	public virtual int GetHashCode() { }

}

