namespace KANAI.Network;

[Token(Token = "0x200000A")]
public class HTTPManager : MonoBehaviourSingleton<HTTPManager>
{
	[CompilerGenerated]
	[Token(Token = "0x200000C")]
	private sealed class <>c__DisplayClass12_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000030")]
		public HTTPManager <>4__this; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000031")]
		public HTTPRequest request; //Field offset: 0x18

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000039")]
		public <>c__DisplayClass12_0() { }

		[Address(RVA = "0x1E030E0", Offset = "0x1E024E0", Length = "0x17A")]
		[Token(Token = "0x600003A")]
		internal bool <WaitQue>b__0() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200000D")]
	private sealed class <WaitQue>d__12 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000032")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000033")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000034")]
		public HTTPManager <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000035")]
		public HTTPRequest request; //Field offset: 0x28

		[Token(Token = "0x17000007")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x600003E")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000008")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000040")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x600003B")]
		public <WaitQue>d__12(int <>1__state) { }

		[Address(RVA = "0x1E03260", Offset = "0x1E02660", Length = "0x12C")]
		[Token(Token = "0x600003D")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x600003E")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000040")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x1E03390", Offset = "0x1E02790", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x600003F")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x600003C")]
		private override void System.IDisposable.Dispose() { }

	}

	[Token(Token = "0x200000B")]
	internal enum Order : int
	{
		Serial = 0,
		Parallel = 1,
	}

	[Token(Token = "0x4000029")]
	private static List<X509Certificate> clientCertificate; //Field offset: 0x0
	[Token(Token = "0x400002A")]
	private static List<X509Certificate> serverCertificate; //Field offset: 0x8
	[Token(Token = "0x400002B")]
	private static List<HTTPRequest> waitQues; //Field offset: 0x10
	[Token(Token = "0x400002C")]
	private static List<HTTPRequest> execQues; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000027")]
	private CookieContainer cookies; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000028")]
	public Order execOrder; //Field offset: 0x28

	[Address(RVA = "0x1E00590", Offset = "0x1DFF990", Length = "0x107")]
	[Token(Token = "0x6000036")]
	private bool _checkFinish(HTTPRequest request) { }

	[Address(RVA = "0x1DFF900", Offset = "0x1DFED00", Length = "0x8A")]
	[Token(Token = "0x6000032")]
	private void _ResetConnection() { }

	[Address(RVA = "0x1E00090", Offset = "0x1DFF490", Length = "0x179")]
	[Token(Token = "0x6000033")]
	private void _StartRequest(HTTPRequest request) { }

	[Address(RVA = "0x1E00210", Offset = "0x1DFF610", Length = "0x78")]
	[Token(Token = "0x6000034")]
	private void _UpdateRequestWait(HTTPRequest request) { }

	[Address(RVA = "0x1E00290", Offset = "0x1DFF690", Length = "0x17D")]
	[Token(Token = "0x6000035")]
	private void _UpdateResponseWait(HTTPRequest request) { }

	[Address(RVA = "0x1E00410", Offset = "0x1DFF810", Length = "0x17A")]
	[Token(Token = "0x6000038")]
	private static HTTPManager() { }

	[Address(RVA = "0x1E006A0", Offset = "0x1DFFAA0", Length = "0x77")]
	[Token(Token = "0x6000037")]
	public HTTPManager() { }

	[Address(RVA = "0x1DFF790", Offset = "0x1DFEB90", Length = "0xCA")]
	[Token(Token = "0x600002D")]
	public void AddQue(HTTPRequest request) { }

	[Address(RVA = "0x1DFF860", Offset = "0x1DFEC60", Length = "0xA0")]
	[Token(Token = "0x6000029")]
	protected virtual void Awake() { }

	[Address(RVA = "0x1DFF990", Offset = "0x1DFED90", Length = "0x79")]
	[Token(Token = "0x6000030")]
	public bool Cancel(HTTPRequest request) { }

	[Address(RVA = "0x1DFF900", Offset = "0x1DFED00", Length = "0x8A")]
	[Token(Token = "0x6000031")]
	public void CancelAllQue() { }

	[Address(RVA = "0x1DFFA10", Offset = "0x1DFEE10", Length = "0x16C")]
	[Token(Token = "0x600002F")]
	public bool IsExec(HTTPRequest request) { }

	[Address(RVA = "0x1DFFB80", Offset = "0x1DFEF80", Length = "0xA9")]
	[Token(Token = "0x600002B")]
	protected virtual void OnDestroy() { }

	[Address(RVA = "0x1DFFC30", Offset = "0x1DFF030", Length = "0x8E")]
	[Token(Token = "0x600002A")]
	private void Start() { }

	[Address(RVA = "0x1DFFCC0", Offset = "0x1DFF0C0", Length = "0x332")]
	[Token(Token = "0x600002C")]
	private void Update() { }

	[Address(RVA = "0x1E00000", Offset = "0x1DFF400", Length = "0x84")]
	[IteratorStateMachine(typeof(<WaitQue>d__12))]
	[Token(Token = "0x600002E")]
	public IEnumerator WaitQue(HTTPRequest request) { }

}

