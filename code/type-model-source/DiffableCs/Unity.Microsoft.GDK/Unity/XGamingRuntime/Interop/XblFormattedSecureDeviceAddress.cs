namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x20002F1")]
internal struct XblFormattedSecureDeviceAddress
{
	[CompilerGenerated]
	[Token(Token = "0x20002F2")]
	[UnsafeValueType]
	internal struct <value>e__FixedBuffer
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000816")]
		public byte FixedElementField; //Field offset: 0x0

	}

	[FieldOffset(Offset = "0x0")]
	[FixedBuffer(typeof(byte), 4096)]
	[Token(Token = "0x4000815")]
	private <value>e__FixedBuffer value; //Field offset: 0x0

	[Address(RVA = "0x2BA64D0", Offset = "0x2BA58D0", Length = "0xD")]
	[Token(Token = "0x600114C")]
	internal string GetValue() { }

}

