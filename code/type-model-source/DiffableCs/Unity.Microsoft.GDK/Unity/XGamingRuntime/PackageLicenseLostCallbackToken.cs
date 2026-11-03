namespace Unity.XGamingRuntime;

[Token(Token = "0x2000277")]
public class PackageLicenseLostCallbackToken
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40006AB")]
	private PackageLicenseLostCallbackToken <interop>k__BackingField; //Field offset: 0x10

	[Token(Token = "0x170002D0")]
	internal PackageLicenseLostCallbackToken interop
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000D11")]
		internal get { } //Length: 5
		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000D12")]
		private set { } //Length: 13
	}

	[Token(Token = "0x170002D1")]
	public bool IsValid
	{
		[Address(RVA = "0x2B7F6C0", Offset = "0x2B7EAC0", Length = "0x44")]
		[Token(Token = "0x6000D14")]
		 get { } //Length: 68
	}

	[Token(Token = "0x170002D2")]
	public ulong Token
	{
		[Address(RVA = "0x5C1260", Offset = "0x5C0660", Length = "0x1B")]
		[Token(Token = "0x6000D15")]
		 get { } //Length: 27
		[Address(RVA = "0x2B7CEA0", Offset = "0x2B7C2A0", Length = "0x1B")]
		[Token(Token = "0x6000D16")]
		 set { } //Length: 27
	}

	[Address(RVA = "0x2B7F620", Offset = "0x2B7EA20", Length = "0x9F")]
	[Token(Token = "0x6000D13")]
	internal PackageLicenseLostCallbackToken(XStoreLicense licenseHandle, XStorePackageLicenseLostCallback callback, IntPtr context) { }

	[Address(RVA = "0x2B7F5B0", Offset = "0x2B7E9B0", Length = "0x44")]
	[Token(Token = "0x6000D18")]
	public void Dispose() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000D11")]
	internal PackageLicenseLostCallbackToken get_interop() { }

	[Address(RVA = "0x2B7F6C0", Offset = "0x2B7EAC0", Length = "0x44")]
	[Token(Token = "0x6000D14")]
	public bool get_IsValid() { }

	[Address(RVA = "0x5C1260", Offset = "0x5C0660", Length = "0x1B")]
	[Token(Token = "0x6000D15")]
	public ulong get_Token() { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000D12")]
	private void set_interop(PackageLicenseLostCallbackToken value) { }

	[Address(RVA = "0x2B7CEA0", Offset = "0x2B7C2A0", Length = "0x1B")]
	[Token(Token = "0x6000D16")]
	public void set_Token(ulong value) { }

	[Address(RVA = "0x2B7F600", Offset = "0x2B7EA00", Length = "0x1E")]
	[Token(Token = "0x6000D17")]
	public bool Unregister(bool wait) { }

}

