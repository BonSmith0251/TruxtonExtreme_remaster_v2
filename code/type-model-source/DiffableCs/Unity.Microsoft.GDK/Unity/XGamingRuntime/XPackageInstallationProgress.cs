namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x200024D")]
public class XPackageInstallationProgress
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000656")]
	internal XPackageInstallationProgress interop; //Field offset: 0x10

	[Token(Token = "0x17000250")]
	public bool Completed
	{
		[Address(RVA = "0x5BB2A0", Offset = "0x5BA6A0", Length = "0x5")]
		[Token(Token = "0x6000BD9")]
		 get { } //Length: 5
		[Address(RVA = "0x2707C90", Offset = "0x2707090", Length = "0x4")]
		[Token(Token = "0x6000BDA")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700024D")]
	public ulong InstalledBytes
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x6000BD3")]
		 get { } //Length: 5
		[Address(RVA = "0xF4AFC0", Offset = "0xF4A3C0", Length = "0x5")]
		[Token(Token = "0x6000BD4")]
		 set { } //Length: 5
	}

	[Token(Token = "0x1700024F")]
	public bool Launchable
	{
		[Address(RVA = "0x5BB290", Offset = "0x5BA690", Length = "0x5")]
		[Token(Token = "0x6000BD7")]
		 get { } //Length: 5
		[Address(RVA = "0x11EDB90", Offset = "0x11ECF90", Length = "0x4")]
		[Token(Token = "0x6000BD8")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700024E")]
	public ulong LaunchBytes
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x6000BD5")]
		 get { } //Length: 5
		[Address(RVA = "0x215EF90", Offset = "0x215E390", Length = "0x5")]
		[Token(Token = "0x6000BD6")]
		 set { } //Length: 5
	}

	[Token(Token = "0x1700024C")]
	public ulong TotalBytes
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000BD1")]
		 get { } //Length: 5
		[Address(RVA = "0x1160450", Offset = "0x115F850", Length = "0x5")]
		[Token(Token = "0x6000BD2")]
		 set { } //Length: 5
	}

	[Address(RVA = "0x11DF780", Offset = "0x11DEB80", Length = "0x31")]
	[Token(Token = "0x6000BCF")]
	internal XPackageInstallationProgress(XPackageInstallationProgress interop) { }

	[Address(RVA = "0x2B82130", Offset = "0x2B81530", Length = "0x21")]
	[Token(Token = "0x6000BD0")]
	public XPackageInstallationProgress() { }

	[Address(RVA = "0x5BB2A0", Offset = "0x5BA6A0", Length = "0x5")]
	[Token(Token = "0x6000BD9")]
	public bool get_Completed() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x6000BD3")]
	public ulong get_InstalledBytes() { }

	[Address(RVA = "0x5BB290", Offset = "0x5BA690", Length = "0x5")]
	[Token(Token = "0x6000BD7")]
	public bool get_Launchable() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x6000BD5")]
	public ulong get_LaunchBytes() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6000BD1")]
	public ulong get_TotalBytes() { }

	[Address(RVA = "0x2707C90", Offset = "0x2707090", Length = "0x4")]
	[Token(Token = "0x6000BDA")]
	public void set_Completed(bool value) { }

	[Address(RVA = "0xF4AFC0", Offset = "0xF4A3C0", Length = "0x5")]
	[Token(Token = "0x6000BD4")]
	public void set_InstalledBytes(ulong value) { }

	[Address(RVA = "0x11EDB90", Offset = "0x11ECF90", Length = "0x4")]
	[Token(Token = "0x6000BD8")]
	public void set_Launchable(bool value) { }

	[Address(RVA = "0x215EF90", Offset = "0x215E390", Length = "0x5")]
	[Token(Token = "0x6000BD6")]
	public void set_LaunchBytes(ulong value) { }

	[Address(RVA = "0x1160450", Offset = "0x115F850", Length = "0x5")]
	[Token(Token = "0x6000BD2")]
	public void set_TotalBytes(ulong value) { }

}

