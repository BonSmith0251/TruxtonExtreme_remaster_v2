namespace OutGame.UI;

[Token(Token = "0x200015C")]
public class TXEUIWindow
{
	[CompilerGenerated]
	[Token(Token = "0x200015D")]
	private sealed class <>c__DisplayClass0_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000622")]
		public RectTransform _bWindow; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000623")]
		public CanvasGroup _canvas; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000624")]
		public Image _frame; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000625")]
		public RectTransform _fWindow; //Field offset: 0x28

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60008C3")]
		public <>c__DisplayClass0_0() { }

		[Address(RVA = "0x2209AA0", Offset = "0x2208EA0", Length = "0x194")]
		[Token(Token = "0x60008C4")]
		internal void <OpenWindow>b__0() { }

		[Address(RVA = "0x2209C40", Offset = "0x2209040", Length = "0x3E")]
		[Token(Token = "0x60008C5")]
		internal Color <OpenWindow>b__1() { }

		[Address(RVA = "0x2209C80", Offset = "0x2209080", Length = "0x37")]
		[Token(Token = "0x60008C6")]
		internal void <OpenWindow>b__2(Color color) { }

		[Address(RVA = "0x2209CC0", Offset = "0x22090C0", Length = "0x1D")]
		[Token(Token = "0x60008C7")]
		internal float <OpenWindow>b__3() { }

		[Address(RVA = "0x2209CE0", Offset = "0x22090E0", Length = "0x1E")]
		[Token(Token = "0x60008C8")]
		internal void <OpenWindow>b__4(float _a) { }

		[Address(RVA = "0x2209D00", Offset = "0x2209100", Length = "0x2F")]
		[Token(Token = "0x60008C9")]
		internal void <OpenWindow>b__5() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200015E")]
	private sealed class <>c__DisplayClass1_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000626")]
		public RectTransform twindow; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000627")]
		public Image frame; //Field offset: 0x18

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60008CA")]
		public <>c__DisplayClass1_0() { }

		[Address(RVA = "0x2209D30", Offset = "0x2209130", Length = "0x2F")]
		[Token(Token = "0x60008CB")]
		internal void <CloseWindow>b__0() { }

		[Address(RVA = "0x2209D60", Offset = "0x2209160", Length = "0x3E")]
		[Token(Token = "0x60008CC")]
		internal Color <CloseWindow>b__1() { }

		[Address(RVA = "0x2209DA0", Offset = "0x22091A0", Length = "0x37")]
		[Token(Token = "0x60008CD")]
		internal void <CloseWindow>b__2(Color color) { }

		[Address(RVA = "0x2209DE0", Offset = "0x22091E0", Length = "0x2F")]
		[Token(Token = "0x60008CE")]
		internal void <CloseWindow>b__3() { }

	}

	[Token(Token = "0x400061D")]
	private static readonly Vector3 _startScale; //Field offset: 0x0
	[Token(Token = "0x400061E")]
	private static readonly Vector3 _endScale; //Field offset: 0xC
	[Token(Token = "0x400061F")]
	private static readonly Quaternion startFrameRotate; //Field offset: 0x18
	[Token(Token = "0x4000620")]
	private static readonly Vector3 startFrameScale; //Field offset: 0x28
	[Token(Token = "0x4000621")]
	private static readonly Vector3 closeFrameScale; //Field offset: 0x34

	[Address(RVA = "0x2207270", Offset = "0x2206670", Length = "0x13B")]
	[Token(Token = "0x60008C2")]
	private static TXEUIWindow() { }

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x60008C1")]
	public TXEUIWindow() { }

	[Address(RVA = "0x2206B20", Offset = "0x2205F20", Length = "0x295")]
	[Token(Token = "0x60008C0")]
	public static Sequence CloseWindow(RectTransform twindow, Image frame, float _closeAnimationSecond) { }

	[Address(RVA = "0x2206DC0", Offset = "0x22061C0", Length = "0x4A8")]
	[Token(Token = "0x60008BF")]
	public static Sequence OpenWindow(RectTransform _bWindow, CanvasGroup _canvas, RectTransform _fWindow, Image _frame, float _openAnimationSecond) { }

}

