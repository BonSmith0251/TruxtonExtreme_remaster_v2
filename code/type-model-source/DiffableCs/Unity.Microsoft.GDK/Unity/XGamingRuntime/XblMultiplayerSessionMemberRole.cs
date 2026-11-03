namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x200017A")]
public class XblMultiplayerSessionMemberRole
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400030B")]
	private readonly string <RoleTypeName>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400030C")]
	private readonly string <RoleName>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400030D")]
	private readonly XblMultiplayerSessionMemberRole <InteropHandle>k__BackingField; //Field offset: 0x20

	[Token(Token = "0x17000104")]
	internal XblMultiplayerSessionMemberRole InteropHandle
	{
		[Address(RVA = "0xF53F00", Offset = "0xF53300", Length = "0xB")]
		[CompilerGenerated]
		[Token(Token = "0x6000862")]
		internal get { } //Length: 11
	}

	[Token(Token = "0x17000103")]
	public string RoleName
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000861")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000102")]
	public string RoleTypeName
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000860")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x2B88F00", Offset = "0x2B88300", Length = "0x5E")]
	[Token(Token = "0x600085F")]
	internal XblMultiplayerSessionMemberRole(XblMultiplayerSessionMemberRole interopHandle) { }

	[Address(RVA = "0xF53F00", Offset = "0xF53300", Length = "0xB")]
	[CompilerGenerated]
	[Token(Token = "0x6000862")]
	internal XblMultiplayerSessionMemberRole get_InteropHandle() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000861")]
	public string get_RoleName() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000860")]
	public string get_RoleTypeName() { }

}

