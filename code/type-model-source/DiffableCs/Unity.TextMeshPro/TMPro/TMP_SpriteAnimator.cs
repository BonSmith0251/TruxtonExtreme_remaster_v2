namespace TMPro;

[DisallowMultipleComponent]
[Token(Token = "0x200008A")]
public class TMP_SpriteAnimator : MonoBehaviour
{
	[CompilerGenerated]
	[Token(Token = "0x200008B")]
	private sealed class <DoSpriteAnimationInternal>d__7 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000484")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000485")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000486")]
		public TMP_SpriteAnimator <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000487")]
		public int start; //Field offset: 0x28
		[FieldOffset(Offset = "0x2C")]
		[Token(Token = "0x4000488")]
		public int end; //Field offset: 0x2C
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000489")]
		public TMP_SpriteAsset spriteAsset; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x400048A")]
		public int currentCharacter; //Field offset: 0x38
		[FieldOffset(Offset = "0x3C")]
		[Token(Token = "0x400048B")]
		public int framerate; //Field offset: 0x3C
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x400048C")]
		private int <currentFrame>5__2; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x400048D")]
		private TMP_CharacterInfo <charInfo>5__3; //Field offset: 0x48
		[FieldOffset(Offset = "0x1C0")]
		[Token(Token = "0x400048E")]
		private int <materialIndex>5__4; //Field offset: 0x1C0
		[FieldOffset(Offset = "0x1C4")]
		[Token(Token = "0x400048F")]
		private int <vertexIndex>5__5; //Field offset: 0x1C4
		[FieldOffset(Offset = "0x1C8")]
		[Token(Token = "0x4000490")]
		private TMP_MeshInfo <meshInfo>5__6; //Field offset: 0x1C8
		[FieldOffset(Offset = "0x218")]
		[Token(Token = "0x4000491")]
		private float <baseSpriteScale>5__7; //Field offset: 0x218
		[FieldOffset(Offset = "0x21C")]
		[Token(Token = "0x4000492")]
		private float <elapsedTime>5__8; //Field offset: 0x21C
		[FieldOffset(Offset = "0x220")]
		[Token(Token = "0x4000493")]
		private float <targetTime>5__9; //Field offset: 0x220

		[Token(Token = "0x17000104")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60004A1")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000105")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60004A3")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x600049E")]
		public <DoSpriteAnimationInternal>d__7(int <>1__state) { }

		[Address(RVA = "0x2F17FA0", Offset = "0x2F173A0", Length = "0xD1E")]
		[Token(Token = "0x60004A0")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60004A1")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60004A3")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x2F18CC0", Offset = "0x2F180C0", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x60004A2")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x600049F")]
		private override void System.IDisposable.Dispose() { }

	}

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000482")]
	private Dictionary<Int32, Boolean> m_animations; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000483")]
	private TMP_Text m_TextComponent; //Field offset: 0x28

	[Address(RVA = "0x2F10A60", Offset = "0x2F0FE60", Length = "0x7C")]
	[Token(Token = "0x600049D")]
	public TMP_SpriteAnimator() { }

	[Address(RVA = "0x2F107D0", Offset = "0x2F0FBD0", Length = "0x49")]
	[Token(Token = "0x6000497")]
	private void Awake() { }

	[Address(RVA = "0x2F108E0", Offset = "0x2F0FCE0", Length = "0x122")]
	[Token(Token = "0x600049B")]
	public void DoSpriteAnimation(int currentCharacter, TMP_SpriteAsset spriteAsset, int start, int end, int framerate) { }

	[Address(RVA = "0x2F10820", Offset = "0x2F0FC20", Length = "0xB5")]
	[IteratorStateMachine(typeof(<DoSpriteAnimationInternal>d__7))]
	[Token(Token = "0x600049C")]
	private IEnumerator DoSpriteAnimationInternal(int currentCharacter, TMP_SpriteAsset spriteAsset, int start, int end, int framerate) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000499")]
	private void OnDisable() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000498")]
	private void OnEnable() { }

	[Address(RVA = "0x2F10A10", Offset = "0x2F0FE10", Length = "0x4E")]
	[Token(Token = "0x600049A")]
	public void StopAllAnimations() { }

}

