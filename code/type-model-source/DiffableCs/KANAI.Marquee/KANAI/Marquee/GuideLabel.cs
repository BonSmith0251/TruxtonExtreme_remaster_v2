namespace KANAI.Marquee;

[Token(Token = "0x2000004")]
public class GuideLabel : MonoBehaviour
{
	[Token(Token = "0x2000007")]
	internal enum Dir : int
	{
		V = 0,
		H = 1,
	}

	[Token(Token = "0x2000005")]
	internal class LabelInfo
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400000F")]
		public RectTransform BaseRect; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000010")]
		public UIImage LabelIcon; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000011")]
		public UITextMeshPro LabelStr; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000012")]
		private RectTransform _StrRect; //Field offset: 0x28

		[Token(Token = "0x17000002")]
		public RectTransform StrRect
		{
			[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
			[Token(Token = "0x6000013")]
			 get { } //Length: 5
			[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
			[Token(Token = "0x6000014")]
			 set { } //Length: 13
		}

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000015")]
		public LabelInfo() { }

		[Address(RVA = "0x1DFA220", Offset = "0x1DF9620", Length = "0x66")]
		[Token(Token = "0x6000012")]
		public void Clear() { }

		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x6000013")]
		public RectTransform get_StrRect() { }

		[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
		[Token(Token = "0x6000014")]
		public void set_StrRect(RectTransform value) { }

	}

	[Token(Token = "0x2000006")]
	internal class LabelPack
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000013")]
		public Sprite iconSprite; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000014")]
		public string textString; //Field offset: 0x18

		[Address(RVA = "0x1DFA290", Offset = "0x1DF9690", Length = "0x6F")]
		[Token(Token = "0x6000016")]
		public LabelPack(Sprite img, string ttext) { }

	}

	[Token(Token = "0x400000B")]
	private static readonly float screenWidth; //Field offset: 0x0
	[Token(Token = "0x400000C")]
	private static readonly float limitWidth; //Field offset: 0x4
	[Token(Token = "0x400000D")]
	private static readonly float possibleWidth; //Field offset: 0x8
	[Token(Token = "0x400000E")]
	private static readonly float MaximumStrWidth; //Field offset: 0xC
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x4000006")]
	private LabelInfo[] _labels; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000007")]
	private Dir _dir; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000008")]
	private CanvasGroup _canvas; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000009")]
	private int _guideCount; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x400000A")]
	private int _displayBit; //Field offset: 0x3C

	[Token(Token = "0x17000001")]
	public float canvasAlpha
	{
		[Address(RVA = "0x1DFA0B0", Offset = "0x1DF94B0", Length = "0x1D")]
		[Token(Token = "0x600000D")]
		 get { } //Length: 29
		[Address(RVA = "0x1DFA0D0", Offset = "0x1DF94D0", Length = "0x141")]
		[Token(Token = "0x600000C")]
		 set { } //Length: 321
	}

	[Address(RVA = "0x1DFA010", Offset = "0x1DF9410", Length = "0x8C")]
	[Token(Token = "0x6000011")]
	private static GuideLabel() { }

	[Address(RVA = "0x1DFA0A0", Offset = "0x1DF94A0", Length = "0xE")]
	[Token(Token = "0x6000010")]
	public GuideLabel() { }

	[Address(RVA = "0x1DF9130", Offset = "0x1DF8530", Length = "0x3D0")]
	[Token(Token = "0x6000007")]
	public void AdjustDisplay() { }

	[Address(RVA = "0x1DF9510", Offset = "0x1DF8910", Length = "0x7F")]
	[Token(Token = "0x600000E")]
	private void ClearDisplay() { }

	[Address(RVA = "0x1DFA0B0", Offset = "0x1DF94B0", Length = "0x1D")]
	[Token(Token = "0x600000D")]
	public float get_canvasAlpha() { }

	[Address(RVA = "0x1DF9590", Offset = "0x1DF8990", Length = "0x1E5")]
	[Token(Token = "0x600000A")]
	public List<LabelPack> GetCurrentLabels() { }

	[Address(RVA = "0x1DF9780", Offset = "0x1DF8B80", Length = "0xEC")]
	[Token(Token = "0x6000003")]
	public void Initialize(Dir dir) { }

	[Address(RVA = "0x1DF9870", Offset = "0x1DF8C70", Length = "0x8")]
	[Token(Token = "0x6000009")]
	public bool IsDisplay() { }

	[Address(RVA = "0x1DF9880", Offset = "0x1DF8C80", Length = "0x7F")]
	[Token(Token = "0x6000004")]
	public void Refresh(TMP_FontAsset tfont) { }

	[Address(RVA = "0x1DF9900", Offset = "0x1DF8D00", Length = "0x129")]
	[Token(Token = "0x6000005")]
	public void Reset() { }

	[Address(RVA = "0x1DF9A30", Offset = "0x1DF8E30", Length = "0x8C")]
	[Token(Token = "0x600000F")]
	private void RestoreDisplay() { }

	[Address(RVA = "0x1DFA0D0", Offset = "0x1DF94D0", Length = "0x141")]
	[Token(Token = "0x600000C")]
	public void set_canvasAlpha(float value) { }

	[Address(RVA = "0x1DF9AC0", Offset = "0x1DF8EC0", Length = "0x170")]
	[Token(Token = "0x600000B")]
	public void SetCurrentLabels(List<LabelPack> plabels) { }

	[Address(RVA = "0x1DF9C40", Offset = "0x1DF9040", Length = "0x9C")]
	[Token(Token = "0x6000008")]
	public void SetDisplay(int index, bool isDisplay) { }

	[Address(RVA = "0x1DF9CE0", Offset = "0x1DF90E0", Length = "0x326")]
	[Token(Token = "0x6000006")]
	public void SetIconAndLabel(int index, Sprite icon, string labelStr) { }

}

