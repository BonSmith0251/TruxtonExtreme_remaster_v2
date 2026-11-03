namespace UnityEngine.VFX;

[Token(Token = "0x2000027")]
internal static class VFXTimeSpaceHelper
{
	[CompilerGenerated]
	[Token(Token = "0x2000028")]
	private sealed class <CollectClipEvents>d__1 : IEnumerable<VisualEffectPlayableSerializedEvent>, IEnumerable, IEnumerator<VisualEffectPlayableSerializedEvent>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000064")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000065")]
		private VisualEffectPlayableSerializedEvent <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000066")]
		private int <>l__initialThreadId; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4000067")]
		private VisualEffectControlClip source; //Field offset: 0x50
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4000068")]
		public VisualEffectControlClip <>3__source; //Field offset: 0x58
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4000069")]
		private Enumerator<ClipEvent> <>7__wrap1; //Field offset: 0x60
		[FieldOffset(Offset = "0xC0")]
		[Token(Token = "0x400006A")]
		private VisualEffectPlayableSerializedEvent <eventExit>5__3; //Field offset: 0xC0

		[Token(Token = "0x17000007")]
		private override VisualEffectPlayableSerializedEvent System.Collections.Generic.IEnumerator<UnityEngine.VFX.VisualEffectPlayableSerializedEvent>.Current
		{
			[Address(RVA = "0xABF840", Offset = "0xABEC40", Length = "0x1B")]
			[DebuggerHidden]
			[Token(Token = "0x600005C")]
			private get { } //Length: 27
		}

		[Token(Token = "0x17000008")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x2F714B0", Offset = "0x2F708B0", Length = "0x57")]
			[DebuggerHidden]
			[Token(Token = "0x600005E")]
			private get { } //Length: 87
		}

		[Address(RVA = "0x1B7B3D0", Offset = "0x1B7A7D0", Length = "0x2E")]
		[DebuggerHidden]
		[Token(Token = "0x6000058")]
		public <CollectClipEvents>d__1(int <>1__state) { }

		[Address(RVA = "0x2F715A0", Offset = "0x2F709A0", Length = "0x41")]
		[Token(Token = "0x600005B")]
		private void <>m__Finally1() { }

		[Address(RVA = "0x2F70F80", Offset = "0x2F70380", Length = "0x44B")]
		[Token(Token = "0x600005A")]
		private override bool MoveNext() { }

		[Address(RVA = "0x2F713D0", Offset = "0x2F707D0", Length = "0x9C")]
		[DebuggerHidden]
		[Token(Token = "0x600005F")]
		private override IEnumerator<VisualEffectPlayableSerializedEvent> System.Collections.Generic.IEnumerable<UnityEngine.VFX.VisualEffectPlayableSerializedEvent>.GetEnumerator() { }

		[Address(RVA = "0xABF840", Offset = "0xABEC40", Length = "0x1B")]
		[DebuggerHidden]
		[Token(Token = "0x600005C")]
		private override VisualEffectPlayableSerializedEvent System.Collections.Generic.IEnumerator<UnityEngine.VFX.VisualEffectPlayableSerializedEvent>.get_Current() { }

		[Address(RVA = "0x2F713D0", Offset = "0x2F707D0", Length = "0x9C")]
		[DebuggerHidden]
		[Token(Token = "0x6000060")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[Address(RVA = "0x2F714B0", Offset = "0x2F708B0", Length = "0x57")]
		[DebuggerHidden]
		[Token(Token = "0x600005E")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x2F71470", Offset = "0x2F70870", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x600005D")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x2F71510", Offset = "0x2F70910", Length = "0x85")]
		[DebuggerHidden]
		[Token(Token = "0x6000059")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000029")]
	private sealed class <GetEventNormalizedSpace>d__3 : IEnumerable<VisualEffectPlayableSerializedEvent>, IEnumerable, IEnumerator<VisualEffectPlayableSerializedEvent>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400006B")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400006C")]
		private VisualEffectPlayableSerializedEvent <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x400006D")]
		private int <>l__initialThreadId; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x400006E")]
		private IEnumerable<VisualEffectPlayableSerializedEvent> events; //Field offset: 0x50
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x400006F")]
		public IEnumerable<VisualEffectPlayableSerializedEvent> <>3__events; //Field offset: 0x58
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4000070")]
		private PlayableTimeSpace space; //Field offset: 0x60
		[FieldOffset(Offset = "0x64")]
		[Token(Token = "0x4000071")]
		public PlayableTimeSpace <>3__space; //Field offset: 0x64
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4000072")]
		private double clipStart; //Field offset: 0x68
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x4000073")]
		public double <>3__clipStart; //Field offset: 0x70
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x4000074")]
		private double clipEnd; //Field offset: 0x78
		[FieldOffset(Offset = "0x80")]
		[Token(Token = "0x4000075")]
		public double <>3__clipEnd; //Field offset: 0x80
		[FieldOffset(Offset = "0x88")]
		[Token(Token = "0x4000076")]
		private IEnumerator<VisualEffectPlayableSerializedEvent> <>7__wrap1; //Field offset: 0x88

		[Token(Token = "0x17000009")]
		private override VisualEffectPlayableSerializedEvent System.Collections.Generic.IEnumerator<UnityEngine.VFX.VisualEffectPlayableSerializedEvent>.Current
		{
			[Address(RVA = "0xABF840", Offset = "0xABEC40", Length = "0x1B")]
			[DebuggerHidden]
			[Token(Token = "0x6000065")]
			private get { } //Length: 27
		}

		[Token(Token = "0x1700000A")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x2F72070", Offset = "0x2F71470", Length = "0x57")]
			[DebuggerHidden]
			[Token(Token = "0x6000067")]
			private get { } //Length: 87
		}

		[Address(RVA = "0x1B7B3D0", Offset = "0x1B7A7D0", Length = "0x2E")]
		[DebuggerHidden]
		[Token(Token = "0x6000061")]
		public <GetEventNormalizedSpace>d__3(int <>1__state) { }

		[Address(RVA = "0x2F72130", Offset = "0x2F71530", Length = "0x56")]
		[Token(Token = "0x6000064")]
		private void <>m__Finally1() { }

		[Address(RVA = "0x2F71CC0", Offset = "0x2F710C0", Length = "0x2A9")]
		[Token(Token = "0x6000063")]
		private override bool MoveNext() { }

		[Address(RVA = "0x2F71F70", Offset = "0x2F71370", Length = "0xB5")]
		[DebuggerHidden]
		[Token(Token = "0x6000068")]
		private override IEnumerator<VisualEffectPlayableSerializedEvent> System.Collections.Generic.IEnumerable<UnityEngine.VFX.VisualEffectPlayableSerializedEvent>.GetEnumerator() { }

		[Address(RVA = "0xABF840", Offset = "0xABEC40", Length = "0x1B")]
		[DebuggerHidden]
		[Token(Token = "0x6000065")]
		private override VisualEffectPlayableSerializedEvent System.Collections.Generic.IEnumerator<UnityEngine.VFX.VisualEffectPlayableSerializedEvent>.get_Current() { }

		[Address(RVA = "0x2F71F70", Offset = "0x2F71370", Length = "0xB5")]
		[DebuggerHidden]
		[Token(Token = "0x6000069")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[Address(RVA = "0x2F72070", Offset = "0x2F71470", Length = "0x57")]
		[DebuggerHidden]
		[Token(Token = "0x6000067")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x2F72030", Offset = "0x2F71430", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000066")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x2F720D0", Offset = "0x2F714D0", Length = "0x53")]
		[DebuggerHidden]
		[Token(Token = "0x6000062")]
		private override void System.IDisposable.Dispose() { }

	}


	[Address(RVA = "0x2F78440", Offset = "0x2F77840", Length = "0x71")]
	[IteratorStateMachine(typeof(<CollectClipEvents>d__1))]
	[Token(Token = "0x6000054")]
	private static IEnumerable<VisualEffectPlayableSerializedEvent> CollectClipEvents(VisualEffectControlClip source) { }

	[Address(RVA = "0x2F78630", Offset = "0x2F77A30", Length = "0x2F")]
	[Token(Token = "0x6000053")]
	public static IEnumerable<VisualEffectPlayableSerializedEvent> GetEventNormalizedSpace(PlayableTimeSpace space, VisualEffectControlPlayableBehaviour source) { }

	[Address(RVA = "0x2F78570", Offset = "0x2F77970", Length = "0xB5")]
	[Token(Token = "0x6000055")]
	public static IEnumerable<VisualEffectPlayableSerializedEvent> GetEventNormalizedSpace(PlayableTimeSpace space, VisualEffectControlClip source, bool clipEvents) { }

	[Address(RVA = "0x2F784C0", Offset = "0x2F778C0", Length = "0xA7")]
	[IteratorStateMachine(typeof(<GetEventNormalizedSpace>d__3))]
	[Token(Token = "0x6000056")]
	private static IEnumerable<VisualEffectPlayableSerializedEvent> GetEventNormalizedSpace(PlayableTimeSpace space, IEnumerable<VisualEffectPlayableSerializedEvent> events, double clipStart, double clipEnd) { }

	[Address(RVA = "0x2F78660", Offset = "0x2F77A60", Length = "0x258")]
	[Token(Token = "0x6000057")]
	public static double GetTimeInSpace(PlayableTimeSpace srcSpace, double srcTime, PlayableTimeSpace dstSpace, double clipStart, double clipEnd) { }

}

