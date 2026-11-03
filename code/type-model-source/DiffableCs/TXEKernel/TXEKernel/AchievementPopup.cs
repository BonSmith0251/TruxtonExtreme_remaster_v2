namespace TXEKernel;

[Token(Token = "0x20000FD")]
public class AchievementPopup : MonoBehaviourSingleton<AchievementPopup>
{
	[CompilerGenerated]
	[Token(Token = "0x2000100")]
	private sealed class <Waiting>d__0 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000523")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000524")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000525")]
		public ID achievementId; //Field offset: 0x20

		[Token(Token = "0x17000209")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x600074C")]
			private get { } //Length: 5
		}

		[Token(Token = "0x1700020A")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x600074E")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x6000749")]
		public <Waiting>d__0(int <>1__state) { }

		[Address(RVA = "0x2720080", Offset = "0x271F480", Length = "0x14A")]
		[Token(Token = "0x600074B")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x600074C")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x600074E")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x27201D0", Offset = "0x271F5D0", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x600074D")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x600074A")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000FF")]
	private sealed class <WaitLoadingFontDisplay>d__4 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400051E")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400051F")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000520")]
		public AchievementPopup <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000521")]
		public ID achievementId; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000522")]
		private YieldInstruction <cacheWait>5__2; //Field offset: 0x30

		[Token(Token = "0x17000207")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000746")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000208")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000748")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x6000743")]
		public <WaitLoadingFontDisplay>d__4(int <>1__state) { }

		[Address(RVA = "0x271FE70", Offset = "0x271F270", Length = "0x1C5")]
		[Token(Token = "0x6000745")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000746")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000748")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x2720040", Offset = "0x271F440", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000747")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x6000744")]
		private override void System.IDisposable.Dispose() { }

	}

	[Token(Token = "0x20000FE")]
	internal enum DisplaySequence : int
	{
		Wait = 0,
		FadeIn = 1,
		Display = 2,
		FadeOut = 3,
	}

	[Token(Token = "0x400050F")]
	private static readonly float FadeTime; //Field offset: 0x0
	[Token(Token = "0x4000510")]
	private static readonly float DisplayTime; //Field offset: 0x4
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x4000511")]
	private UIImage _icon; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4000512")]
	public UITextMeshPro _achievementName; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x4000513")]
	private AchievementData _achievementData; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000514")]
	private Vector3 _prePos; //Field offset: 0x38
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x4000515")]
	private Vector3 _orgPos; //Field offset: 0x44
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000516")]
	private float _sequenceTime; //Field offset: 0x50
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x4000517")]
	private DisplaySequence _displaySequence; //Field offset: 0x54
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000518")]
	private CanvasGroup _canvas; //Field offset: 0x58

	[Address(RVA = "0x2709290", Offset = "0x2708690", Length = "0x15C")]
	[Token(Token = "0x6000740")]
	private void _move(Vector3 startPos, Vector3 endPos, float moveRate, float alphaRate) { }

	[Address(RVA = "0x2709200", Offset = "0x2708600", Length = "0x4E")]
	[Token(Token = "0x6000742")]
	private static AchievementPopup() { }

	[Address(RVA = "0x2709250", Offset = "0x2708650", Length = "0x39")]
	[Token(Token = "0x6000741")]
	public AchievementPopup() { }

	[Address(RVA = "0x2708D20", Offset = "0x2708120", Length = "0xC8")]
	[Token(Token = "0x600073B")]
	protected virtual void Awake() { }

	[Address(RVA = "0x2708DF0", Offset = "0x27081F0", Length = "0xBF")]
	[Token(Token = "0x600073D")]
	public void DoPopup(ID achievementId) { }

	[Address(RVA = "0x2708EB0", Offset = "0x27082B0", Length = "0x8")]
	[Token(Token = "0x600073C")]
	public bool IsPopup() { }

	[Address(RVA = "0x2708EC0", Offset = "0x27082C0", Length = "0x255")]
	[Token(Token = "0x600073F")]
	private void Update() { }

	[Address(RVA = "0x27091A0", Offset = "0x27085A0", Length = "0x59")]
	[IteratorStateMachine(typeof(<Waiting>d__0))]
	[Token(Token = "0x600073A")]
	public static IEnumerator Waiting(ID achievementId) { }

	[Address(RVA = "0x2709120", Offset = "0x2708520", Length = "0x76")]
	[IteratorStateMachine(typeof(<WaitLoadingFontDisplay>d__4))]
	[Token(Token = "0x600073E")]
	public IEnumerator WaitLoadingFontDisplay(ID achievementId) { }

}

