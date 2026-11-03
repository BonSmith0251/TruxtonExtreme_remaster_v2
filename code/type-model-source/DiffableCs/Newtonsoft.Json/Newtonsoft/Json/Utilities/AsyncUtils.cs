namespace Newtonsoft.Json.Utilities;

[Extension]
[Nullable(0)]
[NullableContext(1)]
[Token(Token = "0x2000093")]
internal static class AsyncUtils
{
	[CompilerGenerated]
	[Token(Token = "0x2000094")]
	private sealed class <>c
	{
		[Nullable(0)]
		[Token(Token = "0x400036A")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Nullable(0)]
		[Token(Token = "0x400036B")]
		public static Action <>9__5_0; //Field offset: 0x8

		[Address(RVA = "0x2131EB0", Offset = "0x21312B0", Length = "0x67")]
		[Token(Token = "0x60004E7")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60004E8")]
		public <>c() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x60004E9")]
		internal void <FromCanceled>b__5_0() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000095")]
	private sealed class <>c__6
	{
		[Nullable(0)]
		[Token(Token = "0x400036C")]
		public static readonly <>c__6<T> <>9; //Field offset: 0x0
		[Nullable(0)]
		[Token(Token = "0x400036D")]
		public static Func<T> <>9__6_0; //Field offset: 0x0

		[Address(RVA = "0xA509C0", Offset = "0xA4FDC0", Length = "0xE9")]
		[Token(Token = "0x60004EA")]
		private static <>c__6`1() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60004EB")]
		public <>c__6`1() { }

		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[NullableContext(0)]
		[Token(Token = "0x60004EC")]
		internal T <FromCanceled>b__6_0() { }

	}

	[Token(Token = "0x4000367")]
	public static readonly Task<Boolean> False; //Field offset: 0x0
	[Token(Token = "0x4000368")]
	public static readonly Task<Boolean> True; //Field offset: 0x8
	[Token(Token = "0x4000369")]
	internal static readonly Task CompletedTask; //Field offset: 0x10

	[Address(RVA = "0x2117540", Offset = "0x2116940", Length = "0xF5")]
	[Token(Token = "0x60004E6")]
	private static AsyncUtils() { }

	[Address(RVA = "0x2116F80", Offset = "0x2116380", Length = "0x90")]
	[Extension]
	[NullableContext(2)]
	[Token(Token = "0x60004DD")]
	public static Task CancelIfRequestedAsync(CancellationToken cancellationToken) { }

	[Address(RVA = "0x7433D0", Offset = "0x7427D0", Length = "0xA1")]
	[Extension]
	[NullableContext(2)]
	[Token(Token = "0x60004DE")]
	public static Task<T> CancelIfRequestedAsync(CancellationToken cancellationToken) { }

	[Address(RVA = "0x2117010", Offset = "0x2116410", Length = "0x11F")]
	[Extension]
	[Token(Token = "0x60004DF")]
	public static Task FromCanceled(CancellationToken cancellationToken) { }

	[Address(RVA = "0x743F00", Offset = "0x743300", Length = "0x1AA")]
	[Extension]
	[Token(Token = "0x60004E0")]
	public static Task<T> FromCanceled(CancellationToken cancellationToken) { }

	[Address(RVA = "0x2117130", Offset = "0x2116530", Length = "0x20")]
	[Extension]
	[Token(Token = "0x60004E5")]
	public static bool IsCompletedSuccessfully(Task task) { }

	[Address(RVA = "0x2117160", Offset = "0x2116560", Length = "0xE8")]
	[Extension]
	[Token(Token = "0x60004E4")]
	public static Task<Int32> ReadAsync(TextReader reader, Char[] buffer, int index, int count, CancellationToken cancellationToken) { }

	[Address(RVA = "0x2117250", Offset = "0x2116650", Length = "0x81")]
	[Extension]
	[Token(Token = "0x60004DC")]
	internal static Task<Boolean> ToAsync(bool value) { }

	[Address(RVA = "0x2117480", Offset = "0x2116880", Length = "0xBF")]
	[Extension]
	[Token(Token = "0x60004E1")]
	public static Task WriteAsync(TextWriter writer, char value, CancellationToken cancellationToken) { }

	[Address(RVA = "0x21172E0", Offset = "0x21166E0", Length = "0xBF")]
	[Extension]
	[Token(Token = "0x60004E2")]
	public static Task WriteAsync(TextWriter writer, string value, CancellationToken cancellationToken) { }

	[Address(RVA = "0x21173A0", Offset = "0x21167A0", Length = "0xD7")]
	[Extension]
	[Token(Token = "0x60004E3")]
	public static Task WriteAsync(TextWriter writer, Char[] value, int start, int count, CancellationToken cancellationToken) { }

}

