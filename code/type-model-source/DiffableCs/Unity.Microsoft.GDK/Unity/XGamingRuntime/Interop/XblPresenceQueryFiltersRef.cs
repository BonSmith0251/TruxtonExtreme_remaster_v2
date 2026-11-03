namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x200032B")]
internal class XblPresenceQueryFiltersRef
{
	[CompilerGenerated]
	[Token(Token = "0x200032C")]
	private sealed class <>c
	{
		[Token(Token = "0x40008FD")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x40008FE")]
		public static Func<XblPresenceDeviceType, DisposableCollection, XblPresenceDeviceType> <>9__7_0; //Field offset: 0x8
		[Token(Token = "0x40008FF")]
		public static Func<UInt32, DisposableCollection, UInt32> <>9__7_1; //Field offset: 0x10

		[Address(RVA = "0x2B9F880", Offset = "0x2B9EC80", Length = "0x67")]
		[Token(Token = "0x6001197")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6001198")]
		public <>c() { }

		[Address(RVA = "0xF59E80", Offset = "0xF59280", Length = "0x3")]
		[Token(Token = "0x6001199")]
		internal XblPresenceDeviceType <.ctor>b__7_0(XblPresenceDeviceType dt, DisposableCollection _) { }

		[Address(RVA = "0xF59E80", Offset = "0xF59280", Length = "0x3")]
		[Token(Token = "0x600119A")]
		internal uint <.ctor>b__7_1(uint titleId, DisposableCollection _) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40008F6")]
	private readonly IntPtr deviceTypes; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40008F7")]
	private readonly SizeT deviceTypesCount; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40008F8")]
	private readonly IntPtr titleIds; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40008F9")]
	private readonly SizeT titleIdsCount; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40008FA")]
	internal readonly XblPresenceDetailLevel detailLevel; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x40008FB")]
	internal bool onlineOnly; //Field offset: 0x34
	[FieldOffset(Offset = "0x35")]
	[Token(Token = "0x40008FC")]
	internal bool broadcastingOnly; //Field offset: 0x35

	[Address(RVA = "0x2BB79B0", Offset = "0x2BB6DB0", Length = "0x252")]
	[Token(Token = "0x6001196")]
	internal XblPresenceQueryFiltersRef(XblPresenceQueryFilters filters, DisposableCollection disposableCollection) { }

}

