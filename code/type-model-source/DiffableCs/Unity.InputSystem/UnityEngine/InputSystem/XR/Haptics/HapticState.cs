namespace UnityEngine.InputSystem.XR.Haptics;

[Token(Token = "0x20000F8")]
public struct HapticState
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40005C4")]
	private uint <samplesQueued>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40005C5")]
	private uint <samplesAvailable>k__BackingField; //Field offset: 0x4

	[Token(Token = "0x1700034B")]
	public private uint samplesAvailable
	{
		[Address(RVA = "0x6466B0", Offset = "0x645AB0", Length = "0x4")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000CAB")]
		 get { } //Length: 4
		[Address(RVA = "0x6466F0", Offset = "0x645AF0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000CAC")]
		private set { } //Length: 4
	}

	[Token(Token = "0x1700034A")]
	public private uint samplesQueued
	{
		[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000CA9")]
		 get { } //Length: 3
		[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
		[CompilerGenerated]
		[Token(Token = "0x6000CAA")]
		private set { } //Length: 3
	}

	[Address(RVA = "0xAEE4E0", Offset = "0xAED8E0", Length = "0x7")]
	[Token(Token = "0x6000CA8")]
	public HapticState(uint samplesQueued, uint samplesAvailable) { }

	[Address(RVA = "0x6466B0", Offset = "0x645AB0", Length = "0x4")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6000CAB")]
	public uint get_samplesAvailable() { }

	[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6000CA9")]
	public uint get_samplesQueued() { }

	[Address(RVA = "0x6466F0", Offset = "0x645AF0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000CAC")]
	private void set_samplesAvailable(uint value) { }

	[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
	[CompilerGenerated]
	[Token(Token = "0x6000CAA")]
	private void set_samplesQueued(uint value) { }

}

