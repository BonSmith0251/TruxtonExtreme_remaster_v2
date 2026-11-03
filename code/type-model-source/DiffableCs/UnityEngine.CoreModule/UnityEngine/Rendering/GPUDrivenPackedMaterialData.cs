namespace UnityEngine.Rendering;

[Token(Token = "0x20003C0")]
[UsedByNativeCode]
internal struct GPUDrivenPackedMaterialData
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000BC3")]
	private uint data; //Field offset: 0x0

	[Token(Token = "0x17000403")]
	public bool isIndirectSupported
	{
		[Address(RVA = "0x30B3A70", Offset = "0x30B2E70", Length = "0x7")]
		[Token(Token = "0x6001D43")]
		 get { } //Length: 7
	}

	[Token(Token = "0x17000402")]
	public bool isMotionVectorsPassEnabled
	{
		[Address(RVA = "0x2E7FCC0", Offset = "0x2E7F0C0", Length = "0x7")]
		[Token(Token = "0x6001D42")]
		 get { } //Length: 7
	}

	[Token(Token = "0x17000401")]
	public bool isTransparent
	{
		[Address(RVA = "0x2E7FCD0", Offset = "0x2E7F0D0", Length = "0x6")]
		[Token(Token = "0x6001D41")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000404")]
	public bool supportsCrossFade
	{
		[Address(RVA = "0x30B3A80", Offset = "0x30B2E80", Length = "0x7")]
		[Token(Token = "0x6001D44")]
		 get { } //Length: 7
	}

	[Address(RVA = "0x1CA23C0", Offset = "0x1CA17C0", Length = "0x7")]
	[Token(Token = "0x6001D45")]
	public GPUDrivenPackedMaterialData() { }

	[Address(RVA = "0x30B3A60", Offset = "0x30B2E60", Length = "0xB")]
	[Token(Token = "0x6001D46")]
	public bool Equals(GPUDrivenPackedMaterialData other) { }

	[Address(RVA = "0x30B3A70", Offset = "0x30B2E70", Length = "0x7")]
	[Token(Token = "0x6001D43")]
	public bool get_isIndirectSupported() { }

	[Address(RVA = "0x2E7FCC0", Offset = "0x2E7F0C0", Length = "0x7")]
	[Token(Token = "0x6001D42")]
	public bool get_isMotionVectorsPassEnabled() { }

	[Address(RVA = "0x2E7FCD0", Offset = "0x2E7F0D0", Length = "0x6")]
	[Token(Token = "0x6001D41")]
	public bool get_isTransparent() { }

	[Address(RVA = "0x30B3A80", Offset = "0x30B2E80", Length = "0x7")]
	[Token(Token = "0x6001D44")]
	public bool get_supportsCrossFade() { }

}

