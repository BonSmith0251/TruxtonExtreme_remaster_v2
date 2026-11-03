namespace DG.Tweening;

[Extension]
[Token(Token = "0x2000004")]
public static class DOTweenModuleAudio
{
	[CompilerGenerated]
	[Token(Token = "0x2000005")]
	private sealed class <>c__DisplayClass0_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000006")]
		public AudioSource target; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000012")]
		public <>c__DisplayClass0_0() { }

		[Address(RVA = "0x5D0EC0", Offset = "0x5D02C0", Length = "0x1D")]
		[Token(Token = "0x6000013")]
		internal float <DOFade>b__0() { }

		[Address(RVA = "0x5D0EE0", Offset = "0x5D02E0", Length = "0x1E")]
		[Token(Token = "0x6000014")]
		internal void <DOFade>b__1(float x) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000006")]
	private sealed class <>c__DisplayClass1_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000007")]
		public AudioSource target; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000015")]
		public <>c__DisplayClass1_0() { }

		[Address(RVA = "0x5D12B0", Offset = "0x5D06B0", Length = "0x1D")]
		[Token(Token = "0x6000016")]
		internal float <DOPitch>b__0() { }

		[Address(RVA = "0x5D12D0", Offset = "0x5D06D0", Length = "0x1E")]
		[Token(Token = "0x6000017")]
		internal void <DOPitch>b__1(float x) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000007")]
	private sealed class <>c__DisplayClass2_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000008")]
		public AudioMixer target; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000009")]
		public string floatName; //Field offset: 0x18

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000018")]
		public <>c__DisplayClass2_0() { }

		[Address(RVA = "0x5D1580", Offset = "0x5D0980", Length = "0x39")]
		[Token(Token = "0x6000019")]
		internal float <DOSetFloat>b__0() { }

		[Address(RVA = "0x5D15C0", Offset = "0x5D09C0", Length = "0x28")]
		[Token(Token = "0x600001A")]
		internal void <DOSetFloat>b__1(float x) { }

	}


	[Address(RVA = "0x5C5D60", Offset = "0x5C5160", Length = "0x59")]
	[Extension]
	[Token(Token = "0x6000006")]
	public static int DOComplete(AudioMixer target, bool withCallbacks = false) { }

	[Address(RVA = "0x5C5DC0", Offset = "0x5C51C0", Length = "0x184")]
	[Extension]
	[Token(Token = "0x6000003")]
	public static TweenerCore<Single, Single, FloatOptions> DOFade(AudioSource target, float endValue, float duration) { }

	[Address(RVA = "0x5C5F50", Offset = "0x5C5350", Length = "0x49")]
	[Extension]
	[Token(Token = "0x6000008")]
	public static int DOFlip(AudioMixer target) { }

	[Address(RVA = "0x5C5FA0", Offset = "0x5C53A0", Length = "0x6B")]
	[Extension]
	[Token(Token = "0x6000009")]
	public static int DOGoto(AudioMixer target, float to, bool andPlay = false) { }

	[Address(RVA = "0x5C6010", Offset = "0x5C5410", Length = "0x59")]
	[Extension]
	[Token(Token = "0x6000007")]
	public static int DOKill(AudioMixer target, bool complete = false) { }

	[Address(RVA = "0x5C6070", Offset = "0x5C5470", Length = "0x49")]
	[Extension]
	[Token(Token = "0x600000A")]
	public static int DOPause(AudioMixer target) { }

	[Address(RVA = "0x5C60C0", Offset = "0x5C54C0", Length = "0x167")]
	[Extension]
	[Token(Token = "0x6000004")]
	public static TweenerCore<Single, Single, FloatOptions> DOPitch(AudioSource target, float endValue, float duration) { }

	[Address(RVA = "0x5C62D0", Offset = "0x5C56D0", Length = "0x49")]
	[Extension]
	[Token(Token = "0x600000B")]
	public static int DOPlay(AudioMixer target) { }

	[Address(RVA = "0x5C6230", Offset = "0x5C5630", Length = "0x49")]
	[Extension]
	[Token(Token = "0x600000C")]
	public static int DOPlayBackwards(AudioMixer target) { }

	[Address(RVA = "0x5C6280", Offset = "0x5C5680", Length = "0x49")]
	[Extension]
	[Token(Token = "0x600000D")]
	public static int DOPlayForward(AudioMixer target) { }

	[Address(RVA = "0x5C6320", Offset = "0x5C5720", Length = "0x54")]
	[Extension]
	[Token(Token = "0x600000E")]
	public static int DORestart(AudioMixer target) { }

	[Address(RVA = "0x5C6380", Offset = "0x5C5780", Length = "0x4C")]
	[Extension]
	[Token(Token = "0x600000F")]
	public static int DORewind(AudioMixer target) { }

	[Address(RVA = "0x5C63D0", Offset = "0x5C57D0", Length = "0x17A")]
	[Extension]
	[Token(Token = "0x6000005")]
	public static TweenerCore<Single, Single, FloatOptions> DOSetFloat(AudioMixer target, string floatName, float endValue, float duration) { }

	[Address(RVA = "0x5C6550", Offset = "0x5C5950", Length = "0x49")]
	[Extension]
	[Token(Token = "0x6000010")]
	public static int DOSmoothRewind(AudioMixer target) { }

	[Address(RVA = "0x5C65A0", Offset = "0x5C59A0", Length = "0x49")]
	[Extension]
	[Token(Token = "0x6000011")]
	public static int DOTogglePause(AudioMixer target) { }

}

