namespace System;

[Token(Token = "0x2000108")]
internal class LazyHelper
{
	[Token(Token = "0x40003FD")]
	internal static readonly LazyHelper NoneViaConstructor; //Field offset: 0x0
	[Token(Token = "0x40003FE")]
	internal static readonly LazyHelper NoneViaFactory; //Field offset: 0x8
	[Token(Token = "0x40003FF")]
	internal static readonly LazyHelper PublicationOnlyViaConstructor; //Field offset: 0x10
	[Token(Token = "0x4000400")]
	internal static readonly LazyHelper PublicationOnlyViaFactory; //Field offset: 0x18
	[Token(Token = "0x4000401")]
	internal static readonly LazyHelper PublicationOnlyWaitForOtherThreadToPublish; //Field offset: 0x20
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000402")]
	private readonly LazyState <State>k__BackingField; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000403")]
	private readonly ExceptionDispatchInfo _exceptionDispatch; //Field offset: 0x18

	[Token(Token = "0x17000087")]
	internal LazyState State
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[CompilerGenerated]
		[Token(Token = "0x6000828")]
		internal get { } //Length: 85
	}

	[Address(RVA = "0x2029420", Offset = "0x2028820", Length = "0x19E")]
	[Token(Token = "0x600082F")]
	private static LazyHelper() { }

	[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
	[Token(Token = "0x6000829")]
	internal LazyHelper(LazyState state) { }

	[Address(RVA = "0x20295C0", Offset = "0x20289C0", Length = "0x6E")]
	[Token(Token = "0x600082A")]
	internal LazyHelper(LazyThreadSafetyMode mode, Exception exception) { }

	[Address(RVA = "0x2029250", Offset = "0x2028650", Length = "0x19C")]
	[Token(Token = "0x600082C")]
	internal static LazyHelper Create(LazyThreadSafetyMode mode, bool useDefaultConstructor) { }

	[Address(RVA = "0x20291E0", Offset = "0x20285E0", Length = "0x64")]
	[Token(Token = "0x600082D")]
	internal static object CreateViaDefaultConstructor(Type type) { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[CompilerGenerated]
	[Token(Token = "0x6000828")]
	internal LazyState get_State() { }

	[Address(RVA = "0x20293F0", Offset = "0x20287F0", Length = "0x8")]
	[Token(Token = "0x600082E")]
	internal static LazyThreadSafetyMode GetModeFromIsThreadSafe(bool isThreadSafe) { }

	[Address(RVA = "0x2029400", Offset = "0x2028800", Length = "0x1D")]
	[Token(Token = "0x600082B")]
	internal void ThrowException() { }

}

