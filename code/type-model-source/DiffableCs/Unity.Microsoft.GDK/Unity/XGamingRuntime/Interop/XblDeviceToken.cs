namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x2000310")]
internal struct XblDeviceToken
{
	[CompilerGenerated]
	[Token(Token = "0x2000311")]
	[UnsafeValueType]
	internal struct <Value>e__FixedBuffer
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400089A")]
		public byte FixedElementField; //Field offset: 0x0

	}

	[FieldOffset(Offset = "0x0")]
	[FixedBuffer(typeof(byte), 40)]
	[Token(Token = "0x4000899")]
	private <Value>e__FixedBuffer Value; //Field offset: 0x0

	[Address(RVA = "0x2BA64A0", Offset = "0x2BA58A0", Length = "0x2A")]
	[Token(Token = "0x6001175")]
	internal XblDeviceToken(XblDeviceToken publicObject) { }

	[Address(RVA = "0x2BA6490", Offset = "0x2BA5890", Length = "0xD")]
	[Token(Token = "0x6001174")]
	internal string GetValue() { }

}

