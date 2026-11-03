namespace KANAI.UI;

[Token(Token = "0x200004B")]
public class UITextMeshPro : TextMeshProUGUI, ITextContext
{
	[Token(Token = "0x40001D8")]
	private static readonly int ID_FaceDilate; //Field offset: 0x0
	[FieldOffset(Offset = "0x7D0")]
	[SerializeField]
	[Token(Token = "0x40001D3")]
	private UITextFontColor _textColorId; //Field offset: 0x7D0
	[FieldOffset(Offset = "0x7D4")]
	[SerializeField]
	[Token(Token = "0x40001D4")]
	private UITextOutlineColor _outlineColorId; //Field offset: 0x7D4
	[FieldOffset(Offset = "0x7D8")]
	[SerializeField]
	[Token(Token = "0x40001D5")]
	private UITextOutlineSize _outlineSizeId; //Field offset: 0x7D8
	[FieldOffset(Offset = "0x7E0")]
	[SerializeField]
	[Token(Token = "0x40001D6")]
	private string _localizeKey; //Field offset: 0x7E0
	[FieldOffset(Offset = "0x7E8")]
	[SerializeField]
	[Token(Token = "0x40001D7")]
	private bool _isKeepFont; //Field offset: 0x7E8

	[Token(Token = "0x17000041")]
	public override string localizeKey
	{
		[Address(RVA = "0x1E28AD0", Offset = "0x1E27ED0", Length = "0x8")]
		[Token(Token = "0x60001EF")]
		 get { } //Length: 8
		[Address(RVA = "0x1E28AE0", Offset = "0x1E27EE0", Length = "0x92")]
		[Token(Token = "0x60001F0")]
		 set { } //Length: 146
	}

	[Token(Token = "0x17000042")]
	public virtual string text
	{
		[Address(RVA = "0x1CF2E60", Offset = "0x1CF2260", Length = "0x8")]
		[Token(Token = "0x60001F1")]
		 get { } //Length: 8
		[Address(RVA = "0x1E28B80", Offset = "0x1E27F80", Length = "0x8")]
		[Token(Token = "0x60001F2")]
		 set { } //Length: 8
	}

	[Address(RVA = "0x1E28990", Offset = "0x1E27D90", Length = "0x92")]
	[Token(Token = "0x60001F5")]
	protected override void _Setup(string key) { }

	[Address(RVA = "0x1E28A30", Offset = "0x1E27E30", Length = "0x4F")]
	[Token(Token = "0x6000203")]
	private static UITextMeshPro() { }

	[Address(RVA = "0x1E28A80", Offset = "0x1E27E80", Length = "0x49")]
	[Token(Token = "0x6000202")]
	public UITextMeshPro() { }

	[Address(RVA = "0x1E27C90", Offset = "0x1E27090", Length = "0x3D")]
	[Token(Token = "0x60001FC")]
	private void ApplyAllStyle() { }

	[Address(RVA = "0x1E27CD0", Offset = "0x1E270D0", Length = "0x11A")]
	[Token(Token = "0x60001FD")]
	private void ApplyFontColor() { }

	[Address(RVA = "0x1E27DF0", Offset = "0x1E271F0", Length = "0x2DC")]
	[Token(Token = "0x60001FE")]
	private void ApplyOutlineFromState() { }

	[Address(RVA = "0x1E281A0", Offset = "0x1E275A0", Length = "0x2C")]
	[Token(Token = "0x60001F3")]
	protected virtual void Awake() { }

	[Address(RVA = "0x1E280D0", Offset = "0x1E274D0", Length = "0xCD")]
	[Token(Token = "0x60001F4")]
	public override void AwakeSetup() { }

	[Address(RVA = "0x1E28AD0", Offset = "0x1E27ED0", Length = "0x8")]
	[Token(Token = "0x60001EF")]
	public override string get_localizeKey() { }

	[Address(RVA = "0x1CF2E60", Offset = "0x1CF2260", Length = "0x8")]
	[Token(Token = "0x60001F1")]
	public virtual string get_text() { }

	[Address(RVA = "0x1E281D0", Offset = "0x1E275D0", Length = "0xD7")]
	[Token(Token = "0x60001FF")]
	private float GetOutlineThicknessOffset(float pixelSize) { }

	[Address(RVA = "0x1E282B0", Offset = "0x1E276B0", Length = "0xE0")]
	[Token(Token = "0x60001FB")]
	private void ResetLocalMaterialInstance() { }

	[Address(RVA = "0x1E28AE0", Offset = "0x1E27EE0", Length = "0x92")]
	[Token(Token = "0x60001F0")]
	public override void set_localizeKey(string value) { }

	[Address(RVA = "0x1E28B80", Offset = "0x1E27F80", Length = "0x8")]
	[Token(Token = "0x60001F2")]
	public virtual void set_text(string value) { }

	[Address(RVA = "0x1E283A0", Offset = "0x1E277A0", Length = "0x24C")]
	[Token(Token = "0x60001F6")]
	public void SetFontAsset(TMP_FontAsset font, bool withKeep) { }

	[Address(RVA = "0x1E285F0", Offset = "0x1E279F0", Length = "0xD")]
	[Token(Token = "0x60001F7")]
	public void SetFontColor(UITextFontColor color) { }

	[Address(RVA = "0x1E28860", Offset = "0x1E27C60", Length = "0x14")]
	[Token(Token = "0x60001F8")]
	public void SetOutline(UITextOutlineColor color, UITextOutlineSize size) { }

	[Address(RVA = "0x1E28600", Offset = "0x1E27A00", Length = "0x244")]
	[Token(Token = "0x60001FA")]
	public void SetOutlineDirect(Color color, float pixelSize) { }

	[Address(RVA = "0x1E28850", Offset = "0x1E27C50", Length = "0xD")]
	[Token(Token = "0x60001F9")]
	public void SetOutlineSize(UITextOutlineSize size) { }

	[Address(RVA = "0x1E28880", Offset = "0x1E27C80", Length = "0x110")]
	[Token(Token = "0x6000200")]
	private bool TryGetEditableFontMaterial(out Material mat) { }

	[Address(RVA = "0x1E27C90", Offset = "0x1E27090", Length = "0x3D")]
	[Token(Token = "0x6000201")]
	protected override void UpdateColors() { }

}

