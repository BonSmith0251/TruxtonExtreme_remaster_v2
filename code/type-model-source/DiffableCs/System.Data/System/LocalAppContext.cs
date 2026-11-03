namespace System;

[Token(Token = "0x2000007")]
internal class LocalAppContext
{
	[CompilerGenerated]
	[Token(Token = "0x2000008")]
	private sealed class <>c
	{
		[Token(Token = "0x4000007")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000008")]
		public static Func<Boolean> <>9__6_0; //Field offset: 0x8

		[Address(RVA = "0x230F930", Offset = "0x230ED30", Length = "0x67")]
		[Token(Token = "0x600000C")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600000D")]
		public <>c() { }

		[Address(RVA = "0x230F8C0", Offset = "0x230ECC0", Length = "0x64")]
		[Token(Token = "0x600000E")]
		internal bool <get_DisableCaching>b__6_0() { }

	}

	[Token(Token = "0x4000004")]
	private static bool s_isDisableCachingInitialized; //Field offset: 0x0
	[Token(Token = "0x4000005")]
	private static bool s_disableCaching; //Field offset: 0x1
	[Token(Token = "0x4000006")]
	private static object s_syncObject; //Field offset: 0x8

	[Token(Token = "0x17000002")]
	private static bool DisableCaching
	{
		[Address(RVA = "0x230F3C0", Offset = "0x230E7C0", Length = "0x161")]
		[Token(Token = "0x600000B")]
		private get { } //Length: 353
	}

	[Address(RVA = "0x230F3C0", Offset = "0x230E7C0", Length = "0x161")]
	[Token(Token = "0x600000B")]
	private static bool get_DisableCaching() { }

	[Address(RVA = "0x230F3A0", Offset = "0x230E7A0", Length = "0x15")]
	[Token(Token = "0x6000009")]
	internal static bool GetCachedSwitchValue(string switchName, ref int switchValue) { }

	[Address(RVA = "0x230F1D0", Offset = "0x230E5D0", Length = "0x1C1")]
	[Token(Token = "0x600000A")]
	private static bool GetCachedSwitchValueInternal(string switchName, ref int switchValue) { }

}

