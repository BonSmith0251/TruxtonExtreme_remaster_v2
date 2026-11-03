namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x2000312")]
internal struct XblGuid
{
	[CompilerGenerated]
	[Token(Token = "0x2000313")]
	[UnsafeValueType]
	internal struct <value>e__FixedBuffer
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400089C")]
		public byte FixedElementField; //Field offset: 0x0

	}

	[FieldOffset(Offset = "0x0")]
	[FixedBuffer(typeof(byte), 40)]
	[Token(Token = "0x400089B")]
	private <value>e__FixedBuffer value; //Field offset: 0x0

	[Address(RVA = "0x2BA64A0", Offset = "0x2BA58A0", Length = "0x2A")]
	[Token(Token = "0x6001177")]
	internal XblGuid(XblGuid publicObject) { }

	[Address(RVA = "0x2BA6490", Offset = "0x2BA5890", Length = "0xD")]
	[Token(Token = "0x6001176")]
	internal string GetValue() { }

}

