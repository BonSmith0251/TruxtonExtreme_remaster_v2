namespace Unity.XGamingRuntime;

[Token(Token = "0x2000144")]
public class XblAchievementProgressChangeEventArgs
{
	[CompilerGenerated]
	[Token(Token = "0x2000145")]
	private sealed class <>c
	{
		[Token(Token = "0x4000218")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000219")]
		public static Func<XblAchievementProgressChangeEntry, XblAchievementProgressChangeEntry> <>9__0_0; //Field offset: 0x8

		[Address(RVA = "0x2B7B770", Offset = "0x2B7AB70", Length = "0x67")]
		[Token(Token = "0x600076D")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600076E")]
		public <>c() { }

		[Address(RVA = "0x2B711B0", Offset = "0x2B705B0", Length = "0x72")]
		[Token(Token = "0x600076F")]
		internal XblAchievementProgressChangeEntry <.ctor>b__0_0(XblAchievementProgressChangeEntry entriesInterop) { }

	}

	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000216")]
	private XblAchievementProgressChangeEntry[] <UpdatedAchievementEntries>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000217")]
	private ulong <EntryCount>k__BackingField; //Field offset: 0x18

	[Token(Token = "0x1700008C")]
	public private ulong EntryCount
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600076B")]
		 get { } //Length: 5
		[Address(RVA = "0xF4AFC0", Offset = "0xF4A3C0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600076C")]
		private set { } //Length: 5
	}

	[Token(Token = "0x1700008B")]
	public private XblAchievementProgressChangeEntry[] UpdatedAchievementEntries
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000769")]
		 get { } //Length: 5
		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x600076A")]
		private set { } //Length: 13
	}

	[Address(RVA = "0x2B7D2F0", Offset = "0x2B7C6F0", Length = "0x149")]
	[Token(Token = "0x6000768")]
	internal XblAchievementProgressChangeEventArgs(XblAchievementProgressChangeEventArgs interopEventArgs) { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600076B")]
	public ulong get_EntryCount() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000769")]
	public XblAchievementProgressChangeEntry[] get_UpdatedAchievementEntries() { }

	[Address(RVA = "0xF4AFC0", Offset = "0xF4A3C0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600076C")]
	private void set_EntryCount(ulong value) { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x600076A")]
	private void set_UpdatedAchievementEntries(XblAchievementProgressChangeEntry[] value) { }

}

