namespace Unity.XGamingRuntime;

[Token(Token = "0x2000251")]
public class XPackageRegisterPackageInstalledToken
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400065C")]
	private XPackageRegisterPackageInstalledToken <interop>k__BackingField; //Field offset: 0x10

	[Token(Token = "0x17000262")]
	internal XPackageRegisterPackageInstalledToken interop
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000C03")]
		internal get { } //Length: 5
		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000C04")]
		private set { } //Length: 13
	}

	[Token(Token = "0x17000264")]
	public bool IsValid
	{
		[Address(RVA = "0x2B823F0", Offset = "0x2B817F0", Length = "0x44")]
		[Token(Token = "0x6000C08")]
		 get { } //Length: 68
	}

	[Token(Token = "0x17000263")]
	public ulong Token
	{
		[Address(RVA = "0x5C1260", Offset = "0x5C0660", Length = "0x1B")]
		[Token(Token = "0x6000C06")]
		 get { } //Length: 27
		[Address(RVA = "0x2B7CEA0", Offset = "0x2B7C2A0", Length = "0x1B")]
		[Token(Token = "0x6000C07")]
		 set { } //Length: 27
	}

	[Address(RVA = "0x2B82360", Offset = "0x2B81760", Length = "0x87")]
	[Token(Token = "0x6000C05")]
	internal XPackageRegisterPackageInstalledToken(XPackageInstalledCallback callback, IntPtr context) { }

	[Address(RVA = "0x2B822F0", Offset = "0x2B816F0", Length = "0x44")]
	[Token(Token = "0x6000C0A")]
	public void Dispose() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000C03")]
	internal XPackageRegisterPackageInstalledToken get_interop() { }

	[Address(RVA = "0x2B823F0", Offset = "0x2B817F0", Length = "0x44")]
	[Token(Token = "0x6000C08")]
	public bool get_IsValid() { }

	[Address(RVA = "0x5C1260", Offset = "0x5C0660", Length = "0x1B")]
	[Token(Token = "0x6000C06")]
	public ulong get_Token() { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000C04")]
	private void set_interop(XPackageRegisterPackageInstalledToken value) { }

	[Address(RVA = "0x2B7CEA0", Offset = "0x2B7C2A0", Length = "0x1B")]
	[Token(Token = "0x6000C07")]
	public void set_Token(ulong value) { }

	[Address(RVA = "0x2B82340", Offset = "0x2B81740", Length = "0x1E")]
	[Token(Token = "0x6000C09")]
	public bool Unregister(bool wait) { }

}

