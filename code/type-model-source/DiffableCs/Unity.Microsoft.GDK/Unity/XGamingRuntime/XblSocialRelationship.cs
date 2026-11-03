namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x20001D7")]
public class XblSocialRelationship
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40004F3")]
	private readonly ulong <XboxUserId>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40004F4")]
	private readonly bool <IsFavourite>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x19")]
	[Token(Token = "0x40004F5")]
	private readonly bool <IsFollowingCaller>k__BackingField; //Field offset: 0x19
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40004F6")]
	private readonly String[] <SocialNetworks>k__BackingField; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40004F7")]
	private bool m_isFriend; //Field offset: 0x28

	[Token(Token = "0x170001A9")]
	public bool IsFavourite
	{
		[Address(RVA = "0x1410A70", Offset = "0x140FE70", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60009C7")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170001AB")]
	public bool IsFollowingCaller
	{
		[Address(RVA = "0x1D88C10", Offset = "0x1D88010", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60009CA")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170001AA")]
	public private bool IsFriend
	{
		[Address(RVA = "0x5BB290", Offset = "0x5BA690", Length = "0x5")]
		[Token(Token = "0x60009C8")]
		 get { } //Length: 5
		[Address(RVA = "0x11EDB90", Offset = "0x11ECF90", Length = "0x4")]
		[Token(Token = "0x60009C9")]
		private set { } //Length: 4
	}

	[Token(Token = "0x170001AC")]
	public String[] SocialNetworks
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60009CB")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170001A8")]
	public ulong XboxUserId
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60009C6")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x2B8C2F0", Offset = "0x2B8B6F0", Length = "0x55")]
	[Token(Token = "0x60009C4")]
	internal XblSocialRelationship(XblSocialRelationship interopHandle) { }

	[Address(RVA = "0x2B8C290", Offset = "0x2B8B690", Length = "0x58")]
	[Token(Token = "0x60009C5")]
	internal XblSocialRelationship(XblSocialRelationship2 interopHandle) { }

	[Address(RVA = "0x1410A70", Offset = "0x140FE70", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60009C7")]
	public bool get_IsFavourite() { }

	[Address(RVA = "0x1D88C10", Offset = "0x1D88010", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60009CA")]
	public bool get_IsFollowingCaller() { }

	[Address(RVA = "0x5BB290", Offset = "0x5BA690", Length = "0x5")]
	[Token(Token = "0x60009C8")]
	public bool get_IsFriend() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60009CB")]
	public String[] get_SocialNetworks() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60009C6")]
	public ulong get_XboxUserId() { }

	[Address(RVA = "0x11EDB90", Offset = "0x11ECF90", Length = "0x4")]
	[Token(Token = "0x60009C9")]
	private void set_IsFriend(bool value) { }

}

