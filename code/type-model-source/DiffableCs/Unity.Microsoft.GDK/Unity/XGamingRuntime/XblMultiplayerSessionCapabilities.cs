namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x200019D")]
public class XblMultiplayerSessionCapabilities
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40003DA")]
	private readonly bool <Connectivity>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x11")]
	[Token(Token = "0x40003DB")]
	private readonly bool <Team>k__BackingField; //Field offset: 0x11
	[CompilerGenerated]
	[FieldOffset(Offset = "0x12")]
	[Token(Token = "0x40003DC")]
	private readonly bool <Arbitration>k__BackingField; //Field offset: 0x12
	[CompilerGenerated]
	[FieldOffset(Offset = "0x13")]
	[Token(Token = "0x40003DD")]
	private readonly bool <SuppressPresenceActivityCheck>k__BackingField; //Field offset: 0x13
	[CompilerGenerated]
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40003DE")]
	private readonly bool <Gameplay>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	[FieldOffset(Offset = "0x15")]
	[Token(Token = "0x40003DF")]
	private readonly bool <Large>k__BackingField; //Field offset: 0x15
	[CompilerGenerated]
	[FieldOffset(Offset = "0x16")]
	[Token(Token = "0x40003E0")]
	private readonly bool <ConnectionRequiredForActiveMembers>k__BackingField; //Field offset: 0x16
	[CompilerGenerated]
	[FieldOffset(Offset = "0x17")]
	[Token(Token = "0x40003E1")]
	private readonly bool <UserAuthorizationStyle>k__BackingField; //Field offset: 0x17
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40003E2")]
	private readonly bool <Crossplay>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x19")]
	[Token(Token = "0x40003E3")]
	private readonly bool <Searchable>k__BackingField; //Field offset: 0x19
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1A")]
	[Token(Token = "0x40003E4")]
	private readonly bool <HasOwners>k__BackingField; //Field offset: 0x1A

	[Token(Token = "0x17000159")]
	public bool Arbitration
	{
		[Address(RVA = "0x10AACD0", Offset = "0x10AA0D0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60008EB")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700015D")]
	public bool ConnectionRequiredForActiveMembers
	{
		[Address(RVA = "0x27BCBD0", Offset = "0x27BBFD0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60008EF")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000157")]
	public bool Connectivity
	{
		[Address(RVA = "0x10AACB0", Offset = "0x10AA0B0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60008E9")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700015F")]
	public bool Crossplay
	{
		[Address(RVA = "0x1410A70", Offset = "0x140FE70", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60008F1")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700015B")]
	public bool Gameplay
	{
		[Address(RVA = "0x1964370", Offset = "0x1963770", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60008ED")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000161")]
	public bool HasOwners
	{
		[Address(RVA = "0x116C050", Offset = "0x116B450", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60008F3")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700015C")]
	public bool Large
	{
		[Address(RVA = "0x1F8C9E0", Offset = "0x1F8BDE0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60008EE")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000160")]
	public bool Searchable
	{
		[Address(RVA = "0x1D88C10", Offset = "0x1D88010", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60008F2")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700015A")]
	public bool SuppressPresenceActivityCheck
	{
		[Address(RVA = "0x10AAD90", Offset = "0x10AA190", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60008EC")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000158")]
	public bool Team
	{
		[Address(RVA = "0x10AACC0", Offset = "0x10AA0C0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60008EA")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700015E")]
	public bool UserAuthorizationStyle
	{
		[Address(RVA = "0x2B7BDB0", Offset = "0x2B7B1B0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60008F0")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x2B87CB0", Offset = "0x2B870B0", Length = "0x123")]
	[Token(Token = "0x60008E8")]
	internal XblMultiplayerSessionCapabilities(XblMultiplayerSessionCapabilities interopStruct) { }

	[Address(RVA = "0x10AACD0", Offset = "0x10AA0D0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60008EB")]
	public bool get_Arbitration() { }

	[Address(RVA = "0x27BCBD0", Offset = "0x27BBFD0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60008EF")]
	public bool get_ConnectionRequiredForActiveMembers() { }

	[Address(RVA = "0x10AACB0", Offset = "0x10AA0B0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60008E9")]
	public bool get_Connectivity() { }

	[Address(RVA = "0x1410A70", Offset = "0x140FE70", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60008F1")]
	public bool get_Crossplay() { }

	[Address(RVA = "0x1964370", Offset = "0x1963770", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60008ED")]
	public bool get_Gameplay() { }

	[Address(RVA = "0x116C050", Offset = "0x116B450", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60008F3")]
	public bool get_HasOwners() { }

	[Address(RVA = "0x1F8C9E0", Offset = "0x1F8BDE0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60008EE")]
	public bool get_Large() { }

	[Address(RVA = "0x1D88C10", Offset = "0x1D88010", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60008F2")]
	public bool get_Searchable() { }

	[Address(RVA = "0x10AAD90", Offset = "0x10AA190", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60008EC")]
	public bool get_SuppressPresenceActivityCheck() { }

	[Address(RVA = "0x10AACC0", Offset = "0x10AA0C0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60008EA")]
	public bool get_Team() { }

	[Address(RVA = "0x2B7BDB0", Offset = "0x2B7B1B0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60008F0")]
	public bool get_UserAuthorizationStyle() { }

}

