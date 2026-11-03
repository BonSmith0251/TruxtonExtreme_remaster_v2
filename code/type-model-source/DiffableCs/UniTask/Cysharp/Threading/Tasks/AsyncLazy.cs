namespace Cysharp.Threading.Tasks;

[Token(Token = "0x2000005")]
public class AsyncLazy
{
	[Token(Token = "0x4000007")]
	private static Action<Object> continuation; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000008")]
	private Func<UniTask> taskFactory; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000009")]
	private UniTaskCompletionSource completionSource; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400000A")]
	private Awaiter awaiter; //Field offset: 0x20
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400000B")]
	private object syncLock; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400000C")]
	private bool initialized; //Field offset: 0x38

	[Token(Token = "0x17000002")]
	public UniTask Task
	{
		[Address(RVA = "0x272E250", Offset = "0x272D650", Length = "0x70")]
		[Token(Token = "0x6000007")]
		 get { } //Length: 112
	}

	[Address(RVA = "0x272DF00", Offset = "0x272D300", Length = "0x89")]
	[Token(Token = "0x600000D")]
	private static AsyncLazy() { }

	[Address(RVA = "0x272E190", Offset = "0x272D590", Length = "0xB3")]
	[Token(Token = "0x6000005")]
	public AsyncLazy(Func<UniTask> taskFactory) { }

	[Address(RVA = "0x272DF90", Offset = "0x272D390", Length = "0x1F5")]
	[Token(Token = "0x6000006")]
	internal AsyncLazy(UniTask task) { }

	[Address(RVA = "0x272DBB0", Offset = "0x272CFB0", Length = "0x2F")]
	[Token(Token = "0x6000009")]
	private void EnsureInitialized() { }

	[Address(RVA = "0x272D940", Offset = "0x272CD40", Length = "0x265")]
	[Token(Token = "0x600000A")]
	private void EnsureInitializedCore() { }

	[Address(RVA = "0x272E250", Offset = "0x272D650", Length = "0x70")]
	[Token(Token = "0x6000007")]
	public UniTask get_Task() { }

	[Address(RVA = "0x272DBE0", Offset = "0x272CFE0", Length = "0xD3")]
	[Token(Token = "0x6000008")]
	public Awaiter GetAwaiter() { }

	[Address(RVA = "0x272DCC0", Offset = "0x272D0C0", Length = "0x9B")]
	[Token(Token = "0x600000B")]
	private void SetCompletionSource(in Awaiter awaiter) { }

	[Address(RVA = "0x272DD60", Offset = "0x272D160", Length = "0x199")]
	[Token(Token = "0x600000C")]
	private static void SetCompletionSource(object state) { }

}

