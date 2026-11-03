namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x20002F4")]
internal struct XblMultiplayerInviteHandle
{
	[CompilerGenerated]
	[Token(Token = "0x20002F5")]
	[UnsafeValueType]
	internal struct <Data>e__FixedBuffer
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000822")]
		public byte FixedElementField; //Field offset: 0x0

	}

	[FieldOffset(Offset = "0x0")]
	[FixedBuffer(typeof(byte), 40)]
	[Token(Token = "0x4000821")]
	private <Data>e__FixedBuffer Data; //Field offset: 0x0

	[Address(RVA = "0x2BA6490", Offset = "0x2BA5890", Length = "0xD")]
	[Token(Token = "0x600114E")]
	internal string GetData() { }

}

