namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x20001E1")]
public class XblSocialManagerPresenceRecord
{
	[CompilerGenerated]
	[Token(Token = "0x20001E2")]
	private sealed class <>c
	{
		[Token(Token = "0x4000526")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000527")]
		public static Func<XblSocialManagerPresenceTitleRecord, XblSocialManagerPresenceTitleRecord> <>9__0_1; //Field offset: 0x8

		[Address(RVA = "0x2B80510", Offset = "0x2B7F910", Length = "0x67")]
		[Token(Token = "0x60009EA")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60009EB")]
		public <>c() { }

		[Address(RVA = "0x2B80230", Offset = "0x2B7F630", Length = "0xAE")]
		[Token(Token = "0x60009EC")]
		internal XblSocialManagerPresenceTitleRecord <.ctor>b__0_1(XblSocialManagerPresenceTitleRecord r) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20001E3")]
	private sealed class <>c__DisplayClass0_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000528")]
		public XblSocialManagerPresenceRecord interopRecord; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60009ED")]
		public <>c__DisplayClass0_0() { }

		[Address(RVA = "0x2B80500", Offset = "0x2B7F900", Length = "0x8")]
		[Token(Token = "0x60009EE")]
		internal bool <.ctor>b__0(XblSocialManagerPresenceTitleRecord r, int index) { }

	}

	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000524")]
	private XblPresenceUserState <UserState>k__BackingField; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000525")]
	public XblSocialManagerPresenceTitleRecord[] PresenceTitleRecords; //Field offset: 0x18

	[Token(Token = "0x170001B6")]
	public private XblPresenceUserState UserState
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[CompilerGenerated]
		[Token(Token = "0x60009E8")]
		 get { } //Length: 85
		[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60009E9")]
		private set { } //Length: 4
	}

	[Address(RVA = "0x2B8B460", Offset = "0x2B8A860", Length = "0x20B")]
	[Token(Token = "0x60009E7")]
	internal XblSocialManagerPresenceRecord(XblSocialManagerPresenceRecord interopRecord) { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[CompilerGenerated]
	[Token(Token = "0x60009E8")]
	public XblPresenceUserState get_UserState() { }

	[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60009E9")]
	private void set_UserState(XblPresenceUserState value) { }

}

