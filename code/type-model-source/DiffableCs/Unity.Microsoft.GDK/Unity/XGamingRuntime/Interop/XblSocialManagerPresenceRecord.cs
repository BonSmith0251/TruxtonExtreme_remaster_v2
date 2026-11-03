namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x200033D")]
internal struct XblSocialManagerPresenceRecord
{
	[CompilerGenerated]
	[Token(Token = "0x200033E")]
	private sealed class <>c
	{
		[Token(Token = "0x400093F")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000940")]
		public static Func<XblSocialManagerPresenceTitleRecord, XblSocialManagerPresenceTitleRecord> <>9__3_0; //Field offset: 0x8

		[Address(RVA = "0x2B9F8F0", Offset = "0x2B9ECF0", Length = "0x67")]
		[Token(Token = "0x60011AE")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60011AF")]
		public <>c() { }

		[Address(RVA = "0x2B9F430", Offset = "0x2B9E830", Length = "0x2B")]
		[Token(Token = "0x60011B0")]
		internal XblSocialManagerPresenceTitleRecord <.ctor>b__3_0(XblSocialManagerPresenceTitleRecord r) { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400093C")]
	internal readonly XblPresenceUserState userState; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400093D")]
	internal readonly XblSocialManagerPresenceTitleRecord[] presenceTitleRecords; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400093E")]
	internal readonly uint presenceTitleCount; //Field offset: 0x10

	[Address(RVA = "0x2BB84E0", Offset = "0x2BB78E0", Length = "0x17E")]
	[Token(Token = "0x60011AD")]
	internal XblSocialManagerPresenceRecord(XblSocialManagerPresenceRecord presenceRecord) { }

}

