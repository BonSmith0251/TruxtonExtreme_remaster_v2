namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
[Token(Token = "0x200016B")]
public sealed class AsyncDestroyTrigger : MonoBehaviour
{
	[CompilerGenerated]
	[Token(Token = "0x200016D")]
	private sealed class <>c
	{
		[Token(Token = "0x4000587")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000588")]
		public static Action<Object> <>9__7_0; //Field offset: 0x8

		[Address(RVA = "0x278D3E0", Offset = "0x278C7E0", Length = "0x67")]
		[Token(Token = "0x6000947")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000948")]
		public <>c() { }

		[Address(RVA = "0x278CC80", Offset = "0x278C080", Length = "0x72")]
		[Token(Token = "0x6000949")]
		internal void <OnDestroyAsync>b__7_0(object state) { }

	}

	[Token(Token = "0x200016C")]
	private class AwakeMonitor : IPlayerLoopItem
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000586")]
		private readonly AsyncDestroyTrigger trigger; //Field offset: 0x10

		[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
		[Token(Token = "0x6000945")]
		public AwakeMonitor(AsyncDestroyTrigger trigger) { }

		[Address(RVA = "0x2786090", Offset = "0x2785490", Length = "0xA9")]
		[Token(Token = "0x6000946")]
		public override bool MoveNext() { }

	}

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000583")]
	private bool awakeCalled; //Field offset: 0x20
	[FieldOffset(Offset = "0x21")]
	[Token(Token = "0x4000584")]
	private bool called; //Field offset: 0x21
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000585")]
	private CancellationTokenSource cancellationTokenSource; //Field offset: 0x28

	[Token(Token = "0x17000067")]
	public CancellationToken CancellationToken
	{
		[Address(RVA = "0x2774B10", Offset = "0x2773F10", Length = "0xEC")]
		[Token(Token = "0x6000940")]
		 get { } //Length: 236
	}

	[Address(RVA = "0x5B7910", Offset = "0x5B6D10", Length = "0x7")]
	[Token(Token = "0x6000944")]
	public AsyncDestroyTrigger() { }

	[Address(RVA = "0x1D15400", Offset = "0x1D14800", Length = "0x5")]
	[Token(Token = "0x6000941")]
	private void Awake() { }

	[Address(RVA = "0x2774B10", Offset = "0x2773F10", Length = "0xEC")]
	[Token(Token = "0x6000940")]
	public CancellationToken get_CancellationToken() { }

	[Address(RVA = "0x2774AD0", Offset = "0x2773ED0", Length = "0x38")]
	[Token(Token = "0x6000942")]
	private void OnDestroy() { }

	[Address(RVA = "0x2774820", Offset = "0x2773C20", Length = "0x2AF")]
	[Token(Token = "0x6000943")]
	public UniTask OnDestroyAsync() { }

}

