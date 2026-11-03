namespace Unity.XGamingRuntime;

[Token(Token = "0x20000F7")]
public class XIsAppBroadcastingChangedRegistrationToken
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001C6")]
	private XIsAppBroadcastingChangedRegistrationToken <interop>k__BackingField; //Field offset: 0x10

	[Token(Token = "0x1700001B")]
	internal XIsAppBroadcastingChangedRegistrationToken interop
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000598")]
		internal get { } //Length: 5
		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000599")]
		private set { } //Length: 13
	}

	[Token(Token = "0x1700001D")]
	public bool IsValid
	{
		[Address(RVA = "0x2B7CE50", Offset = "0x2B7C250", Length = "0x44")]
		[Token(Token = "0x600059D")]
		 get { } //Length: 68
	}

	[Token(Token = "0x1700001C")]
	public ulong Token
	{
		[Address(RVA = "0x5C1260", Offset = "0x5C0660", Length = "0x1B")]
		[Token(Token = "0x600059B")]
		 get { } //Length: 27
		[Address(RVA = "0x2B7CEA0", Offset = "0x2B7C2A0", Length = "0x1B")]
		[Token(Token = "0x600059C")]
		 set { } //Length: 27
	}

	[Address(RVA = "0x2B7CDC0", Offset = "0x2B7C1C0", Length = "0x87")]
	[Token(Token = "0x600059A")]
	internal XIsAppBroadcastingChangedRegistrationToken(XAppBroadcastMonitorCallback callback, IntPtr context) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000598")]
	internal XIsAppBroadcastingChangedRegistrationToken get_interop() { }

	[Address(RVA = "0x2B7CE50", Offset = "0x2B7C250", Length = "0x44")]
	[Token(Token = "0x600059D")]
	public bool get_IsValid() { }

	[Address(RVA = "0x5C1260", Offset = "0x5C0660", Length = "0x1B")]
	[Token(Token = "0x600059B")]
	public ulong get_Token() { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000599")]
	private void set_interop(XIsAppBroadcastingChangedRegistrationToken value) { }

	[Address(RVA = "0x2B7CEA0", Offset = "0x2B7C2A0", Length = "0x1B")]
	[Token(Token = "0x600059C")]
	public void set_Token(ulong value) { }

	[Address(RVA = "0x2B7CDA0", Offset = "0x2B7C1A0", Length = "0x1E")]
	[Token(Token = "0x600059E")]
	public bool Unregister(bool wait) { }

}

