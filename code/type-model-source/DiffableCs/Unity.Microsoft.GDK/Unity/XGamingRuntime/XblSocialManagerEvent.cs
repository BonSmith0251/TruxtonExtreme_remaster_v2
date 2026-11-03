namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x20001DD")]
public class XblSocialManagerEvent
{
	[CompilerGenerated]
	[Token(Token = "0x20001DE")]
	private sealed class <>c
	{
		[Token(Token = "0x4000513")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000514")]
		public static Converter<XblSocialManagerUser, XblSocialManagerUser> <>9__0_0; //Field offset: 0x8

		[Address(RVA = "0x2B80AC0", Offset = "0x2B7FEC0", Length = "0x67")]
		[Token(Token = "0x60009E4")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60009E5")]
		public <>c() { }

		[Address(RVA = "0x2B7F930", Offset = "0x2B7ED30", Length = "0xCC")]
		[Token(Token = "0x60009E6")]
		internal XblSocialManagerUser <.ctor>b__0_0(XblSocialManagerUser u) { }

	}

	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400050E")]
	private XUserHandle <User>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400050F")]
	private XblSocialManagerEventType <EventType>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000510")]
	private int <Hr>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000511")]
	private XblSocialManagerUserGroupHandle <LoadedGroup>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000512")]
	private XblSocialManagerUser[] <UsersAffected>k__BackingField; //Field offset: 0x28

	[Token(Token = "0x170001B2")]
	public private XblSocialManagerEventType EventType
	{
		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60009DC")]
		 get { } //Length: 4
		[Address(RVA = "0xF4AFB0", Offset = "0xF4A3B0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60009DD")]
		private set { } //Length: 4
	}

	[Token(Token = "0x170001B3")]
	public private int Hr
	{
		[Address(RVA = "0xFE29D0", Offset = "0xFE1DD0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60009DE")]
		 get { } //Length: 4
		[Address(RVA = "0xFE2A80", Offset = "0xFE1E80", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60009DF")]
		private set { } //Length: 4
	}

	[Token(Token = "0x170001B4")]
	public private XblSocialManagerUserGroupHandle LoadedGroup
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60009E0")]
		 get { } //Length: 5
		[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x60009E1")]
		private set { } //Length: 13
	}

	[Token(Token = "0x170001B1")]
	public private XUserHandle User
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60009DA")]
		 get { } //Length: 5
		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x60009DB")]
		private set { } //Length: 13
	}

	[Token(Token = "0x170001B5")]
	public private XblSocialManagerUser[] UsersAffected
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60009E2")]
		 get { } //Length: 5
		[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x60009E3")]
		private set { } //Length: 13
	}

	[Address(RVA = "0x2B8B260", Offset = "0x2B8A660", Length = "0x1F3")]
	[Token(Token = "0x60009D9")]
	internal XblSocialManagerEvent(XblSocialManagerEvent interopEvent) { }

	[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60009DC")]
	public XblSocialManagerEventType get_EventType() { }

	[Address(RVA = "0xFE29D0", Offset = "0xFE1DD0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60009DE")]
	public int get_Hr() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60009E0")]
	public XblSocialManagerUserGroupHandle get_LoadedGroup() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60009DA")]
	public XUserHandle get_User() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60009E2")]
	public XblSocialManagerUser[] get_UsersAffected() { }

	[Address(RVA = "0xF4AFB0", Offset = "0xF4A3B0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60009DD")]
	private void set_EventType(XblSocialManagerEventType value) { }

	[Address(RVA = "0xFE2A80", Offset = "0xFE1E80", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60009DF")]
	private void set_Hr(int value) { }

	[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x60009E1")]
	private void set_LoadedGroup(XblSocialManagerUserGroupHandle value) { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x60009DB")]
	private void set_User(XUserHandle value) { }

	[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x60009E3")]
	private void set_UsersAffected(XblSocialManagerUser[] value) { }

}

