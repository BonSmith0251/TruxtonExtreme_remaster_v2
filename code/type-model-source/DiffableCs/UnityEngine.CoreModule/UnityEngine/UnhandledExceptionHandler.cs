namespace UnityEngine;

[NativeHeader("PlatformDependent/iPhonePlayer/IOSScriptBindings.h")]
[Token(Token = "0x20001C9")]
internal sealed class UnhandledExceptionHandler
{
	[CompilerGenerated]
	[Token(Token = "0x20001CA")]
	private sealed class <>c
	{
		[Token(Token = "0x4000696")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000697")]
		public static UnhandledExceptionEventHandler <>9__0_0; //Field offset: 0x8

		[Address(RVA = "0x3073D70", Offset = "0x3073170", Length = "0x67")]
		[Token(Token = "0x6001428")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6001429")]
		public <>c() { }

		[Address(RVA = "0x3073620", Offset = "0x3072A20", Length = "0xA4")]
		[Token(Token = "0x600142A")]
		internal void <RegisterUECatcher>b__0_0(object sender, UnhandledExceptionEventArgs e) { }

	}


	[Address(RVA = "0x3073E50", Offset = "0x3073250", Length = "0x114")]
	[RequiredByNativeCode]
	[Token(Token = "0x6001427")]
	private static void RegisterUECatcher() { }

}

