namespace Cysharp.Threading.Tasks;

[Token(Token = "0x2000107")]
public class AutoResetUniTaskCompletionSource : IUniTaskSource, ITaskPoolNode<AutoResetUniTaskCompletionSource>, IPromise, IResolvePromise, IRejectPromise, ICancelPromise
{
	[CompilerGenerated]
	[Token(Token = "0x2000108")]
	private sealed class <>c
	{
		[Token(Token = "0x40003D0")]
		public static readonly <>c <>9; //Field offset: 0x0

		[Address(RVA = "0x273F510", Offset = "0x273E910", Length = "0x67")]
		[Token(Token = "0x600066D")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600066E")]
		public <>c() { }

		[Address(RVA = "0x273EC20", Offset = "0x273E020", Length = "0x5A")]
		[Token(Token = "0x600066F")]
		internal int <.cctor>b__4_0() { }

	}

	[Token(Token = "0x40003CD")]
	private static TaskPool<AutoResetUniTaskCompletionSource> pool; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40003CE")]
	private AutoResetUniTaskCompletionSource nextNode; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40003CF")]
	private UniTaskCompletionSourceCore<AsyncUnit> core; //Field offset: 0x18

	[Token(Token = "0x17000049")]
	public override AutoResetUniTaskCompletionSource NextNode
	{
		[Address(RVA = "0xE28B40", Offset = "0xE27F40", Length = "0x5")]
		[Token(Token = "0x600065D")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700004A")]
	public UniTask Task
	{
		[Address(RVA = "0x272F110", Offset = "0x272E510", Length = "0x62")]
		[DebuggerHidden]
		[Token(Token = "0x6000664")]
		 get { } //Length: 98
	}

	[Address(RVA = "0x272F010", Offset = "0x272E410", Length = "0x100")]
	[Token(Token = "0x600065E")]
	private static AutoResetUniTaskCompletionSource() { }

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x600065F")]
	private AutoResetUniTaskCompletionSource() { }

	[Address(RVA = "0x272EC30", Offset = "0x272E030", Length = "0xA2")]
	[DebuggerHidden]
	[Token(Token = "0x6000660")]
	public static AutoResetUniTaskCompletionSource Create() { }

	[Address(RVA = "0x272E9F0", Offset = "0x272DDF0", Length = "0xD4")]
	[DebuggerHidden]
	[Token(Token = "0x6000663")]
	public static AutoResetUniTaskCompletionSource CreateCompleted(out short token) { }

	[Address(RVA = "0x272EAD0", Offset = "0x272DED0", Length = "0xAF")]
	[DebuggerHidden]
	[Token(Token = "0x6000661")]
	public static AutoResetUniTaskCompletionSource CreateFromCanceled(CancellationToken cancellationToken, out short token) { }

	[Address(RVA = "0x272EB80", Offset = "0x272DF80", Length = "0xAF")]
	[DebuggerHidden]
	[Token(Token = "0x6000662")]
	public static AutoResetUniTaskCompletionSource CreateFromException(Exception exception, out short token) { }

	[Address(RVA = "0xE28B40", Offset = "0xE27F40", Length = "0x5")]
	[Token(Token = "0x600065D")]
	public override AutoResetUniTaskCompletionSource get_NextNode() { }

	[Address(RVA = "0x272F110", Offset = "0x272E510", Length = "0x62")]
	[DebuggerHidden]
	[Token(Token = "0x6000664")]
	public UniTask get_Task() { }

	[Address(RVA = "0x272ECE0", Offset = "0x272E0E0", Length = "0x80")]
	[DebuggerHidden]
	[Token(Token = "0x6000668")]
	public override void GetResult(short token) { }

	[Address(RVA = "0x272ED70", Offset = "0x272E170", Length = "0x49")]
	[DebuggerHidden]
	[Token(Token = "0x6000669")]
	public override UniTaskStatus GetStatus(short token) { }

	[Address(RVA = "0x272EDC0", Offset = "0x272E1C0", Length = "0x70")]
	[DebuggerHidden]
	[Token(Token = "0x600066B")]
	public override void OnCompleted(Action<Object> continuation, object state, short token) { }

	[Address(RVA = "0x272EE30", Offset = "0x272E230", Length = "0x84")]
	[DebuggerHidden]
	[Token(Token = "0x600066C")]
	private bool TryReturn() { }

	[Address(RVA = "0x272EEC0", Offset = "0x272E2C0", Length = "0x49")]
	[DebuggerHidden]
	[Token(Token = "0x6000666")]
	public override bool TrySetCanceled(CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x272EF10", Offset = "0x272E310", Length = "0x49")]
	[DebuggerHidden]
	[Token(Token = "0x6000667")]
	public override bool TrySetException(Exception exception) { }

	[Address(RVA = "0x272EF60", Offset = "0x272E360", Length = "0x6F")]
	[DebuggerHidden]
	[Token(Token = "0x6000665")]
	public override bool TrySetResult() { }

	[Address(RVA = "0x272EFD0", Offset = "0x272E3D0", Length = "0x3A")]
	[DebuggerHidden]
	[Token(Token = "0x600066A")]
	public override UniTaskStatus UnsafeGetStatus() { }

}

