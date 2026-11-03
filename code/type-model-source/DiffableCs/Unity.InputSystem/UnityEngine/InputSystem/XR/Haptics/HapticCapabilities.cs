namespace UnityEngine.InputSystem.XR.Haptics;

[Token(Token = "0x20000FA")]
public struct HapticCapabilities
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40005CA")]
	private readonly uint <numChannels>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40005CB")]
	private readonly bool <supportsImpulse>k__BackingField; //Field offset: 0x4
	[CompilerGenerated]
	[FieldOffset(Offset = "0x5")]
	[Token(Token = "0x40005CC")]
	private readonly bool <supportsBuffer>k__BackingField; //Field offset: 0x5
	[CompilerGenerated]
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40005CD")]
	private readonly uint <frequencyHz>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x40005CE")]
	private readonly uint <maxBufferSize>k__BackingField; //Field offset: 0xC
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40005CF")]
	private readonly uint <optimalBufferSize>k__BackingField; //Field offset: 0x10

	[Token(Token = "0x17000352")]
	public uint frequencyHz
	{
		[Address(RVA = "0x672E80", Offset = "0x672280", Length = "0x4")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000CB6")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000353")]
	public uint maxBufferSize
	{
		[Address(RVA = "0x672E90", Offset = "0x672290", Length = "0x4")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000CB7")]
		 get { } //Length: 4
	}

	[Token(Token = "0x1700034F")]
	public uint numChannels
	{
		[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000CB3")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000354")]
	public uint optimalBufferSize
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000CB8")]
		 get { } //Length: 85
	}

	[Token(Token = "0x17000351")]
	public bool supportsBuffer
	{
		[Address(RVA = "0x28F83B0", Offset = "0x28F77B0", Length = "0x5")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000CB5")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000350")]
	public bool supportsImpulse
	{
		[Address(RVA = "0xAEF1A0", Offset = "0xAEE5A0", Length = "0x5")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000CB4")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x29B6650", Offset = "0x29B5A50", Length = "0x20")]
	[Token(Token = "0x6000CB1")]
	public HapticCapabilities(uint numChannels, bool supportsImpulse, bool supportsBuffer, uint frequencyHz, uint maxBufferSize, uint optimalBufferSize) { }

	[Address(RVA = "0x29B6630", Offset = "0x29B5A30", Length = "0x18")]
	[Token(Token = "0x6000CB2")]
	public HapticCapabilities(uint numChannels, uint frequencyHz, uint maxBufferSize) { }

	[Address(RVA = "0x672E80", Offset = "0x672280", Length = "0x4")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6000CB6")]
	public uint get_frequencyHz() { }

	[Address(RVA = "0x672E90", Offset = "0x672290", Length = "0x4")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6000CB7")]
	public uint get_maxBufferSize() { }

	[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6000CB3")]
	public uint get_numChannels() { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6000CB8")]
	public uint get_optimalBufferSize() { }

	[Address(RVA = "0x28F83B0", Offset = "0x28F77B0", Length = "0x5")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6000CB5")]
	public bool get_supportsBuffer() { }

	[Address(RVA = "0xAEF1A0", Offset = "0xAEE5A0", Length = "0x5")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6000CB4")]
	public bool get_supportsImpulse() { }

}

