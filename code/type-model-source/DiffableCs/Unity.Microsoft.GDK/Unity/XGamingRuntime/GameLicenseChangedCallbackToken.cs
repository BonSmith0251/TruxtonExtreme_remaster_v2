namespace Unity.XGamingRuntime;

[Token(Token = "0x2000276")]
public class GameLicenseChangedCallbackToken
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40006AA")]
	private GameLicenseChangedCallbackToken <interop>k__BackingField; //Field offset: 0x10

	[Token(Token = "0x170002CD")]
	internal GameLicenseChangedCallbackToken interop
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000D09")]
		internal get { } //Length: 5
		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000D0A")]
		private set { } //Length: 13
	}

	[Token(Token = "0x170002CE")]
	public bool IsValid
	{
		[Address(RVA = "0x2B7F560", Offset = "0x2B7E960", Length = "0x44")]
		[Token(Token = "0x6000D0C")]
		 get { } //Length: 68
	}

	[Token(Token = "0x170002CF")]
	public ulong Token
	{
		[Address(RVA = "0x5C1260", Offset = "0x5C0660", Length = "0x1B")]
		[Token(Token = "0x6000D0D")]
		 get { } //Length: 27
		[Address(RVA = "0x2B7CEA0", Offset = "0x2B7C2A0", Length = "0x1B")]
		[Token(Token = "0x6000D0E")]
		 set { } //Length: 27
	}

	[Address(RVA = "0x2B7F4C0", Offset = "0x2B7E8C0", Length = "0x9F")]
	[Token(Token = "0x6000D0B")]
	internal GameLicenseChangedCallbackToken(XStoreContext storeContext, XStoreGameLicenseChangedCallback callback, IntPtr context) { }

	[Address(RVA = "0x2B7F450", Offset = "0x2B7E850", Length = "0x44")]
	[Token(Token = "0x6000D10")]
	public void Dispose() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000D09")]
	internal GameLicenseChangedCallbackToken get_interop() { }

	[Address(RVA = "0x2B7F560", Offset = "0x2B7E960", Length = "0x44")]
	[Token(Token = "0x6000D0C")]
	public bool get_IsValid() { }

	[Address(RVA = "0x5C1260", Offset = "0x5C0660", Length = "0x1B")]
	[Token(Token = "0x6000D0D")]
	public ulong get_Token() { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000D0A")]
	private void set_interop(GameLicenseChangedCallbackToken value) { }

	[Address(RVA = "0x2B7CEA0", Offset = "0x2B7C2A0", Length = "0x1B")]
	[Token(Token = "0x6000D0E")]
	public void set_Token(ulong value) { }

	[Address(RVA = "0x2B7F4A0", Offset = "0x2B7E8A0", Length = "0x1E")]
	[Token(Token = "0x6000D0F")]
	public bool Unregister(bool wait) { }

}

