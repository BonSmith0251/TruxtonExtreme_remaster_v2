namespace System.Runtime.CompilerServices;

[IsReadOnly]
[Token(Token = "0x2000491")]
public struct ValueTaskAwaiter : ICriticalNotifyCompletion, INotifyCompletion
{
	[CompilerGenerated]
	[Token(Token = "0x2000492")]
	private sealed class <>c
	{
		[Token(Token = "0x4001260")]
		public static readonly <>c <>9; //Field offset: 0x0

		[Address(RVA = "0x1F43860", Offset = "0x1F42C60", Length = "0x67")]
		[Token(Token = "0x6002101")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6002102")]
		public <>c() { }

		[Address(RVA = "0x1F435A0", Offset = "0x1F429A0", Length = "0x64")]
		[Token(Token = "0x6002103")]
		internal void <.cctor>b__9_0(object state) { }

	}

	[Token(Token = "0x400125E")]
	internal static readonly Action<Object> s_invokeActionDelegate; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400125F")]
	private readonly ValueTask _value; //Field offset: 0x0

	[Token(Token = "0x17000407")]
	public bool IsCompleted
	{
		[Address(RVA = "0x1F442F0", Offset = "0x1F436F0", Length = "0x49")]
		[Token(Token = "0x60020FC")]
		 get { } //Length: 73
	}

	[Address(RVA = "0x1F44220", Offset = "0x1F43620", Length = "0xC8")]
	[Token(Token = "0x6002100")]
	private static ValueTaskAwaiter() { }

	[Address(RVA = "0x120FC40", Offset = "0x120F040", Length = "0xD")]
	[Token(Token = "0x60020FB")]
	internal ValueTaskAwaiter(ValueTask value) { }

	[Address(RVA = "0x1F442F0", Offset = "0x1F436F0", Length = "0x49")]
	[Token(Token = "0x60020FC")]
	public bool get_IsCompleted() { }

	[Address(RVA = "0x1F43D70", Offset = "0x1F43170", Length = "0x49")]
	[StackTraceHidden]
	[Token(Token = "0x60020FD")]
	public void GetResult() { }

	[Address(RVA = "0x1F43DC0", Offset = "0x1F431C0", Length = "0x225")]
	[Token(Token = "0x60020FE")]
	public override void OnCompleted(Action continuation) { }

	[Address(RVA = "0x1F43FF0", Offset = "0x1F433F0", Length = "0x220")]
	[Token(Token = "0x60020FF")]
	public override void UnsafeOnCompleted(Action continuation) { }

}

