namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x20002FB")]
internal struct XblMultiplayerSessionInitArgs
{
	[CompilerGenerated]
	[Token(Token = "0x20002FC")]
	private sealed class <>c
	{
		[Token(Token = "0x4000832")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000833")]
		public static Func<UInt64, DisposableCollection, UInt64> <>9__5_0; //Field offset: 0x8

		[Address(RVA = "0x2B9FA40", Offset = "0x2B9EE40", Length = "0x67")]
		[Token(Token = "0x6001152")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6001153")]
		public <>c() { }

		[Address(RVA = "0xA50320", Offset = "0xA4F720", Length = "0x4")]
		[Token(Token = "0x6001154")]
		internal ulong <.ctor>b__5_0(ulong x, DisposableCollection dc) { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400082D")]
	internal readonly uint MaxMembersInSession; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x400082E")]
	internal readonly XblMultiplayerSessionVisibility Visibility; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400082F")]
	private readonly IntPtr InitiatorXuids; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000830")]
	internal readonly SizeT InitiatorXuidsCount; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000831")]
	internal readonly UTF8StringPtr CustomJson; //Field offset: 0x18

	[Address(RVA = "0x2BB6C00", Offset = "0x2BB6000", Length = "0x178")]
	[Token(Token = "0x6001151")]
	internal XblMultiplayerSessionInitArgs(XblMultiplayerSessionInitArgs publicObject, DisposableCollection disposableCollection) { }

}

