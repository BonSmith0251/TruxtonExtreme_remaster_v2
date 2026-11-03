namespace KANAI.UI;

[DefaultExecutionOrder(-11)]
[Token(Token = "0x2000048")]
public class UITextFont : MonoBehaviourSingleton<UITextFont>
{
	[CompilerGenerated]
	[Token(Token = "0x200004A")]
	private sealed class <LoadFontData>d__5 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40001CE")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40001CF")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40001D0")]
		public UITextFont <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40001D1")]
		public Area tarea; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40001D2")]
		private AssetReference <fontAsset>5__2; //Field offset: 0x30

		[Token(Token = "0x1700003F")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60001EC")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000040")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60001EE")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x60001E9")]
		public <LoadFontData>d__5(int <>1__state) { }

		[Address(RVA = "0x1E17900", Offset = "0x1E16D00", Length = "0x1B9")]
		[Token(Token = "0x60001EB")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60001EC")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60001EE")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x1E17AC0", Offset = "0x1E16EC0", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x60001ED")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x60001EA")]
		private override void System.IDisposable.Dispose() { }

	}

	[Token(Token = "0x2000049")]
	internal class LanguageDic
	{
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		[Token(Token = "0x40001CC")]
		private Area _area; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Token(Token = "0x40001CD")]
		private AssetReference _assets; //Field offset: 0x18

		[Token(Token = "0x1700003D")]
		public Area TargetArea
		{
			[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
			[Token(Token = "0x60001E6")]
			 get { } //Length: 85
		}

		[Token(Token = "0x1700003E")]
		public AssetReference TargetAssets
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[Token(Token = "0x60001E7")]
			 get { } //Length: 5
		}

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60001E8")]
		public LanguageDic() { }

		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[Token(Token = "0x60001E6")]
		public Area get_TargetArea() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x60001E7")]
		public AssetReference get_TargetAssets() { }

	}

	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40001CA")]
	private TMP_FontAsset <TMPFont>k__BackingField; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x40001CB")]
	private LanguageDic[] _languageAssets; //Field offset: 0x28

	[Token(Token = "0x1700003C")]
	public private TMP_FontAsset TMPFont
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60001DD")]
		 get { } //Length: 5
		[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x60001DE")]
		private set { } //Length: 13
	}

	[Address(RVA = "0x1E27C50", Offset = "0x1E27050", Length = "0x39")]
	[Token(Token = "0x60001E5")]
	public UITextFont() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60001DD")]
	public TMP_FontAsset get_TMPFont() { }

	[Address(RVA = "0x1E27920", Offset = "0x1E26D20", Length = "0x80")]
	[Token(Token = "0x60001E3")]
	public Font GetFont() { }

	[Address(RVA = "0x1E278C0", Offset = "0x1E26CC0", Length = "0x5C")]
	[Token(Token = "0x60001DF")]
	public AssetReference GetFontData(Area tarea) { }

	[Address(RVA = "0x1E279B0", Offset = "0x1E26DB0", Length = "0x76")]
	[IteratorStateMachine(typeof(<LoadFontData>d__5))]
	[Token(Token = "0x60001E0")]
	public IEnumerator LoadFontData(Area tarea) { }

	[Address(RVA = "0x1E27A30", Offset = "0x1E26E30", Length = "0xA3")]
	[Token(Token = "0x60001E4")]
	protected virtual void OnDestroy() { }

	[Address(RVA = "0x1E27AE0", Offset = "0x1E26EE0", Length = "0xDC")]
	[Token(Token = "0x60001E1")]
	public void ReleaseFontData(Area tarea) { }

	[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x60001DE")]
	private void set_TMPFont(TMP_FontAsset value) { }

	[Address(RVA = "0x1E27BC0", Offset = "0x1E26FC0", Length = "0x85")]
	[Token(Token = "0x60001E2")]
	public void SetFontAsset(TMP_FontAsset fasset) { }

}

