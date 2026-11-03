namespace System;

[Token(Token = "0x2000169")]
public sealed class OperatingSystem : ISerializable, ICloneable
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000553")]
	private readonly Version _version; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000554")]
	private readonly PlatformID _platform; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000555")]
	private readonly string _servicePack; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000556")]
	private string _versionString; //Field offset: 0x28

	[Token(Token = "0x17000105")]
	public PlatformID Platform
	{
		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[Token(Token = "0x6000C97")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000106")]
	public string VersionString
	{
		[Address(RVA = "0x2043DF0", Offset = "0x20431F0", Length = "0xB4")]
		[Token(Token = "0x6000C9A")]
		 get { } //Length: 180
	}

	[Address(RVA = "0x2043C60", Offset = "0x2043060", Length = "0x1A")]
	[Token(Token = "0x6000C94")]
	public OperatingSystem(PlatformID platform, Version version) { }

	[Address(RVA = "0x2043C80", Offset = "0x2043080", Length = "0x165")]
	[Token(Token = "0x6000C95")]
	internal OperatingSystem(PlatformID platform, Version version, string servicePack) { }

	[Address(RVA = "0x2043B90", Offset = "0x2042F90", Length = "0x7E")]
	[Token(Token = "0x6000C98")]
	public override object Clone() { }

	[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
	[Token(Token = "0x6000C97")]
	public PlatformID get_Platform() { }

	[Address(RVA = "0x2043DF0", Offset = "0x20431F0", Length = "0xB4")]
	[Token(Token = "0x6000C9A")]
	public string get_VersionString() { }

	[Address(RVA = "0x2043C10", Offset = "0x2043010", Length = "0x3E")]
	[Token(Token = "0x6000C96")]
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x2043C50", Offset = "0x2043050", Length = "0x7")]
	[Token(Token = "0x6000C99")]
	public virtual string ToString() { }

}

