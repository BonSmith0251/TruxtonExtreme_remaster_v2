namespace System.Threading.Tasks;

[AsyncMethodBuilder(typeof(AsyncValueTaskMethodBuilder`1))]
[IsReadOnly]
[Token(Token = "0x200025B")]
public struct ValueTask : IEquatable<ValueTask`1<TResult>>
{
	[Token(Token = "0x200025C")]
	private sealed class ValueTaskSourceAsTask : Task<TResult>
	{
		[CompilerGenerated]
		[Token(Token = "0x200025D")]
		private sealed class <>c
		{
			[Token(Token = "0x4000AB8")]
			public static readonly <>c<TResult> <>9; //Field offset: 0x0

			[Address(RVA = "0xA509C0", Offset = "0xA4FDC0", Length = "0xE9")]
			[Token(Token = "0x60013D9")]
			private static <>c() { }

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x60013DA")]
			public <>c() { }

			[Address(RVA = "0xA36840", Offset = "0xA35C40", Length = "0x1DC")]
			[Token(Token = "0x60013DB")]
			internal void <.cctor>b__4_0(object state) { }

		}

		[Token(Token = "0x4000AB5")]
		private static readonly Action<Object> s_completionAction; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000AB6")]
		private IValueTaskSource<TResult> _source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000AB7")]
		private readonly short _token; //Field offset: 0x0

		[Address(RVA = "0x120FD40", Offset = "0x120F140", Length = "0x172")]
		[Token(Token = "0x60013D8")]
		private static ValueTaskSourceAsTask() { }

		[Address(RVA = "0x12101D0", Offset = "0x120F5D0", Length = "0x115")]
		[Token(Token = "0x60013D7")]
		public ValueTaskSourceAsTask(IValueTaskSource<TResult> source, short token) { }

	}

	[Token(Token = "0x4000AB0")]
	private static Task<TResult> s_canceledTask; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000AB1")]
	internal readonly object _obj; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000AB2")]
	internal readonly TResult _result; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000AB3")]
	internal readonly short _token; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000AB4")]
	internal readonly bool _continueOnCapturedContext; //Field offset: 0x0

	[Token(Token = "0x170001D0")]
	public bool IsCompleted
	{
		[Address(RVA = "0x1211080", Offset = "0x1210480", Length = "0xFC")]
		[Token(Token = "0x60013D1")]
		 get { } //Length: 252
	}

	[Token(Token = "0x170001D1")]
	public bool IsCompletedSuccessfully
	{
		[Address(RVA = "0x1210F80", Offset = "0x1210380", Length = "0xFD")]
		[Token(Token = "0x60013D2")]
		 get { } //Length: 253
	}

	[Token(Token = "0x170001D2")]
	public TResult Result
	{
		[Address(RVA = "0x1211180", Offset = "0x1210580", Length = "0x40F")]
		[Token(Token = "0x60013D3")]
		 get { } //Length: 1039
	}

	[Address(RVA = "0x1210E60", Offset = "0x1210260", Length = "0x2F")]
	[Token(Token = "0x60013C8")]
	public ValueTask`1(TResult result) { }

	[Address(RVA = "0x1210E90", Offset = "0x1210290", Length = "0x45")]
	[Token(Token = "0x60013C9")]
	public ValueTask`1(Task<TResult> task) { }

	[Address(RVA = "0x1210F20", Offset = "0x1210320", Length = "0x53")]
	[Token(Token = "0x60013CA")]
	public ValueTask`1(IValueTaskSource<TResult> source, short token) { }

	[Address(RVA = "0x1210EE0", Offset = "0x12102E0", Length = "0x40")]
	[Token(Token = "0x60013CB")]
	private ValueTask`1(object obj, TResult result, short token, bool continueOnCapturedContext) { }

	[Address(RVA = "0x12102F0", Offset = "0x120F6F0", Length = "0x13A")]
	[Token(Token = "0x60013CF")]
	public Task<TResult> AsTask() { }

	[Address(RVA = "0x1210430", Offset = "0x120F830", Length = "0xB0")]
	[Token(Token = "0x60013D5")]
	public ConfiguredValueTaskAwaitable<TResult> ConfigureAwait(bool continueOnCapturedContext) { }

	[Address(RVA = "0x1210690", Offset = "0x120FA90", Length = "0x116")]
	[Token(Token = "0x60013CD")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x12104E0", Offset = "0x120F8E0", Length = "0x1A6")]
	[Token(Token = "0x60013CE")]
	public override bool Equals(ValueTask<TResult> other) { }

	[Address(RVA = "0x1211080", Offset = "0x1210480", Length = "0xFC")]
	[Token(Token = "0x60013D1")]
	public bool get_IsCompleted() { }

	[Address(RVA = "0x1210F80", Offset = "0x1210380", Length = "0xFD")]
	[Token(Token = "0x60013D2")]
	public bool get_IsCompletedSuccessfully() { }

	[Address(RVA = "0x1211180", Offset = "0x1210580", Length = "0x40F")]
	[Token(Token = "0x60013D3")]
	public TResult get_Result() { }

	[Address(RVA = "0x12107B0", Offset = "0x120FBB0", Length = "0x44")]
	[Token(Token = "0x60013D4")]
	public ValueTaskAwaiter<TResult> GetAwaiter() { }

	[Address(RVA = "0x1210800", Offset = "0x120FC00", Length = "0x5B")]
	[Token(Token = "0x60013CC")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1210860", Offset = "0x120FC60", Length = "0x52C")]
	[Token(Token = "0x60013D0")]
	private Task<TResult> GetTaskForValueTaskSource(IValueTaskSource<TResult> t) { }

	[Address(RVA = "0x1210D90", Offset = "0x1210190", Length = "0xCA")]
	[Token(Token = "0x60013D6")]
	public virtual string ToString() { }

}

