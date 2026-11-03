namespace KANAI.Sound;

[Token(Token = "0x2000006")]
public static class SoundHelper
{
	[CompilerGenerated]
	[Token(Token = "0x2000007")]
	private struct <FadeOut>d__0 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000013")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000014")]
		public AsyncUniTaskVoidMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000015")]
		public int channel; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x4000016")]
		public float fadeSec; //Field offset: 0x14
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000017")]
		public CancellationToken cts; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000018")]
		private SoundManager <m>5__2; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000019")]
		private float <sv>5__3; //Field offset: 0x28
		[FieldOffset(Offset = "0x2C")]
		[Token(Token = "0x400001A")]
		private float <t>5__4; //Field offset: 0x2C
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400001B")]
		private Awaiter <>u__1; //Field offset: 0x30

		[Address(RVA = "0x1E14430", Offset = "0x1E13830", Length = "0x436")]
		[Token(Token = "0x600001F")]
		private override void MoveNext() { }

		[Address(RVA = "0x113E390", Offset = "0x113D790", Length = "0xC")]
		[DebuggerHidden]
		[Token(Token = "0x6000020")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000008")]
	private struct <FadeOutAll>d__1 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400001C")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400001D")]
		public AsyncUniTaskVoidMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400001E")]
		public float fadeSec; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400001F")]
		public CancellationToken cts; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000020")]
		private SoundManager <m>5__2; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000021")]
		private float <t>5__3; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000022")]
		private Awaiter <>u__1; //Field offset: 0x30

		[Address(RVA = "0x1E13A30", Offset = "0x1E12E30", Length = "0x3A3")]
		[Token(Token = "0x6000021")]
		private override void MoveNext() { }

		[Address(RVA = "0x113E390", Offset = "0x113D790", Length = "0xC")]
		[DebuggerHidden]
		[Token(Token = "0x6000022")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000009")]
	private struct <FadeOutBGM>d__2 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000023")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000024")]
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000025")]
		public float fadeSec; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000026")]
		public CancellationToken cts; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000027")]
		public Action _callback; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000028")]
		private SoundManager <m>5__2; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000029")]
		private float <sv>5__3; //Field offset: 0x38
		[FieldOffset(Offset = "0x3C")]
		[Token(Token = "0x400002A")]
		private float <t>5__4; //Field offset: 0x3C
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x400002B")]
		private Awaiter <>u__1; //Field offset: 0x40
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x400002C")]
		private Awaiter <>u__2; //Field offset: 0x50

		[Address(RVA = "0x1E13DE0", Offset = "0x1E131E0", Length = "0x64D")]
		[Token(Token = "0x6000023")]
		private override void MoveNext() { }

		[Address(RVA = "0x113E390", Offset = "0x113D790", Length = "0xC")]
		[DebuggerHidden]
		[Token(Token = "0x6000024")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200000A")]
	private struct <FadePlay>d__3 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400002D")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400002E")]
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400002F")]
		public int ch; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000030")]
		public AudioClip clip; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000031")]
		public float fadeSec; //Field offset: 0x28
		[FieldOffset(Offset = "0x2C")]
		[Token(Token = "0x4000032")]
		public float volume; //Field offset: 0x2C
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000033")]
		public bool withLoop; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000034")]
		public CancellationToken cts; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000035")]
		private SoundManager <m>5__2; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000036")]
		private float <t>5__3; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4000037")]
		private Awaiter <>u__1; //Field offset: 0x50

		[Address(RVA = "0x1E14870", Offset = "0x1E13C70", Length = "0x452")]
		[Token(Token = "0x6000025")]
		private override void MoveNext() { }

		[Address(RVA = "0x113E390", Offset = "0x113D790", Length = "0xC")]
		[DebuggerHidden]
		[Token(Token = "0x6000026")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200000B")]
	private struct <VolumeInterpolation>d__4 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000038")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000039")]
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400003A")]
		public int channel; //Field offset: 0x18
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x400003B")]
		public float time; //Field offset: 0x1C
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400003C")]
		public float volume; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400003D")]
		public CancellationToken cts; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400003E")]
		private SoundManager <m>5__2; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x400003F")]
		private float <sv>5__3; //Field offset: 0x38
		[FieldOffset(Offset = "0x3C")]
		[Token(Token = "0x4000040")]
		private float <t>5__4; //Field offset: 0x3C
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000041")]
		private Awaiter <>u__1; //Field offset: 0x40

		[Address(RVA = "0x1E14CD0", Offset = "0x1E140D0", Length = "0x42E")]
		[Token(Token = "0x6000027")]
		private override void MoveNext() { }

		[Address(RVA = "0x113E390", Offset = "0x113D790", Length = "0xC")]
		[DebuggerHidden]
		[Token(Token = "0x6000028")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}


	[Address(RVA = "0x1E0FBF0", Offset = "0x1E0EFF0", Length = "0xB5")]
	[AsyncStateMachine(typeof(<FadeOut>d__0))]
	[Token(Token = "0x600001A")]
	public static UniTaskVoid FadeOut(int channel, float fadeSec = 1, CancellationToken cts = null) { }

	[Address(RVA = "0x1E0FA30", Offset = "0x1E0EE30", Length = "0xA3")]
	[AsyncStateMachine(typeof(<FadeOutAll>d__1))]
	[Token(Token = "0x600001B")]
	public static UniTaskVoid FadeOutAll(float fadeSec = 1, CancellationToken cts = null) { }

	[Address(RVA = "0x1E0FAE0", Offset = "0x1E0EEE0", Length = "0x107")]
	[AsyncStateMachine(typeof(<FadeOutBGM>d__2))]
	[Token(Token = "0x600001C")]
	public static UniTask FadeOutBGM(float fadeSec = 1, CancellationToken cts = null, Action _callback = null) { }

	[Address(RVA = "0x1E0FCB0", Offset = "0x1E0F0B0", Length = "0x124")]
	[AsyncStateMachine(typeof(<FadePlay>d__3))]
	[Token(Token = "0x600001D")]
	public static UniTask FadePlay(int ch, AudioClip clip, int ID, float volume, float fadeSec = 0, bool withLoop = true, CancellationToken cts = null) { }

	[Address(RVA = "0x1E0FDE0", Offset = "0x1E0F1E0", Length = "0x106")]
	[AsyncStateMachine(typeof(<VolumeInterpolation>d__4))]
	[Token(Token = "0x600001E")]
	public static UniTask VolumeInterpolation(int channel, float volume, float time = 1, CancellationToken cts = null) { }

}

