namespace KANAI.Kernel;

[Token(Token = "0x2000034")]
public class TextureUtility
{
	[CompilerGenerated]
	[Token(Token = "0x2000035")]
	private sealed class <LoadLabelTextures>d__2 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000DB")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40000DC")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40000DD")]
		public TextureUtility <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40000DE")]
		public string tlabel; //Field offset: 0x28

		[Token(Token = "0x1700002B")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60001B8")]
			private get { } //Length: 5
		}

		[Token(Token = "0x1700002C")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60001BA")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x60001B5")]
		public <LoadLabelTextures>d__2(int <>1__state) { }

		[Address(RVA = "0x1DF3AB0", Offset = "0x1DF2EB0", Length = "0x492")]
		[Token(Token = "0x60001B7")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60001B8")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60001BA")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x1DF3F50", Offset = "0x1DF3350", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x60001B9")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x60001B6")]
		private override void System.IDisposable.Dispose() { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000D9")]
	private Dictionary<String, Sprite> _sprite; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40000DA")]
	private List<String> _labels; //Field offset: 0x18

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x60001B4")]
	public TextureUtility() { }

	[Address(RVA = "0x1DF1B90", Offset = "0x1DF0F90", Length = "0x9E")]
	[Token(Token = "0x60001AF")]
	public void AddSprite(Sprite ttex, string tname) { }

	[Address(RVA = "0x11EDDE0", Offset = "0x11ED1E0", Length = "0x12")]
	[Token(Token = "0x60001B2")]
	public string GetDebugString() { }

	[Address(RVA = "0x1DF1C30", Offset = "0x1DF1030", Length = "0x9A")]
	[Token(Token = "0x60001B1")]
	public Sprite GetSprite(string texname) { }

	[Address(RVA = "0x1DF1CD0", Offset = "0x1DF10D0", Length = "0xC3")]
	[Token(Token = "0x60001AB")]
	public void Initialize() { }

	[Address(RVA = "0x1DF1DA0", Offset = "0x1DF11A0", Length = "0x5D")]
	[Token(Token = "0x60001B3")]
	private bool IsContain(string texname) { }

	[Address(RVA = "0x1DF1E00", Offset = "0x1DF1200", Length = "0x84")]
	[IteratorStateMachine(typeof(<LoadLabelTextures>d__2))]
	[Token(Token = "0x60001AD")]
	public IEnumerator LoadLabelTextures(string tlabel) { }

	[Address(RVA = "0x1DF1E90", Offset = "0x1DF1290", Length = "0x294")]
	[Token(Token = "0x60001AE")]
	public void ReleaseLabelTextures(string tlabel) { }

	[Address(RVA = "0x1DF2130", Offset = "0x1DF1530", Length = "0x8E")]
	[Token(Token = "0x60001B0")]
	public void RemoveSprite(string tname) { }

	[Address(RVA = "0x1DF21C0", Offset = "0x1DF15C0", Length = "0xF6")]
	[Token(Token = "0x60001AC")]
	public void Terminate() { }

}

