namespace UnityEngine.ResourceManagement.Profiling;

[Token(Token = "0x2000076")]
internal struct AssetFrameData
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000140")]
	public int AssetCode; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000141")]
	public int BundleCode; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000142")]
	public int ReferenceCount; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000143")]
	public float PercentComplete; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000144")]
	public ContentStatus Status; //Field offset: 0x10

	[Address(RVA = "0x2E3A770", Offset = "0x2E39B70", Length = "0x92")]
	[Token(Token = "0x6000292")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x2E3A810", Offset = "0x2E39C10", Length = "0xD5")]
	[Token(Token = "0x6000293")]
	public virtual int GetHashCode() { }

}

