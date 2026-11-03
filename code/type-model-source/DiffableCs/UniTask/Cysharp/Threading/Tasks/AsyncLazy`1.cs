namespace Cysharp.Threading.Tasks;

[Token(Token = "0x2000006")]
public class AsyncLazy
{
	[Token(Token = "0x400000D")]
	private static Action<Object> continuation; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400000E")]
	private Func<UniTask`1<T>> taskFactory; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400000F")]
	private UniTaskCompletionSource<T> completionSource; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000010")]
	private Awaiter<T> awaiter; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000011")]
	private object syncLock; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000012")]
	private bool initialized; //Field offset: 0x0

	[Token(Token = "0x17000003")]
	public UniTask<T> Task
	{
		[Address(RVA = "0x100C880", Offset = "0x100BC80", Length = "0xEB")]
		[Token(Token = "0x6000010")]
		 get { } //Length: 235
	}

	[Address(RVA = "0x100C290", Offset = "0x100B690", Length = "0xED")]
	[Token(Token = "0x6000016")]
	private static AsyncLazy`1() { }

	[Address(RVA = "0x100C6B0", Offset = "0x100BAB0", Length = "0x1CD")]
	[Token(Token = "0x600000E")]
	public AsyncLazy`1(Func<UniTask`1<T>> taskFactory) { }

	[Address(RVA = "0x100C380", Offset = "0x100B780", Length = "0x32E")]
	[Token(Token = "0x600000F")]
	internal AsyncLazy`1(UniTask<T> task) { }

	[Address(RVA = "0x100BA90", Offset = "0x100AE90", Length = "0x6D")]
	[Token(Token = "0x6000012")]
	private void EnsureInitialized() { }

	[Address(RVA = "0x100B6C0", Offset = "0x100AAC0", Length = "0x3C9")]
	[Token(Token = "0x6000013")]
	private void EnsureInitializedCore() { }

	[Address(RVA = "0x100C880", Offset = "0x100BC80", Length = "0xEB")]
	[Token(Token = "0x6000010")]
	public UniTask<T> get_Task() { }

	[Address(RVA = "0x100BB00", Offset = "0x100AF00", Length = "0x13F")]
	[Token(Token = "0x6000011")]
	public Awaiter<T> GetAwaiter() { }

	[Address(RVA = "0x100C0B0", Offset = "0x100B4B0", Length = "0x1DC")]
	[Token(Token = "0x6000014")]
	private void SetCompletionSource(in Awaiter<T> awaiter) { }

	[Address(RVA = "0x100BC40", Offset = "0x100B040", Length = "0x463")]
	[Token(Token = "0x6000015")]
	private static void SetCompletionSource(object state) { }

}

