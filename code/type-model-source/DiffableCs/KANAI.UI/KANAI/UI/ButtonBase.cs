namespace KANAI.UI;

[AddComponentMenu("UI/ButtonBase", 30)]
[Token(Token = "0x2000007")]
public class ButtonBase : Button
{
	[CompilerGenerated]
	[Token(Token = "0x2000009")]
	private sealed class <>c__DisplayClass19_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000022")]
		public Image image; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000023")]
		public ButtonState iState; //Field offset: 0x18

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000028")]
		public <>c__DisplayClass19_0() { }

		[Address(RVA = "0x1E17B90", Offset = "0x1E16F90", Length = "0x98")]
		[Token(Token = "0x6000029")]
		internal bool <_GetImage>b__0(ButtonImageExchangeInfo p) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200000A")]
	private sealed class <>c__DisplayClass20_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000024")]
		public ButtonState iState; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600002A")]
		public <>c__DisplayClass20_0() { }

		[Address(RVA = "0x1E17C30", Offset = "0x1E17030", Length = "0x1C")]
		[Token(Token = "0x600002B")]
		internal bool <GetTextColor>b__0(ButtonTextExchangeInfo p) { }

	}

	[Token(Token = "0x2000008")]
	internal class ButtonPressEvent : UnityEvent
	{

		[Address(RVA = "0x1E16870", Offset = "0x1E15C70", Length = "0x7")]
		[Token(Token = "0x6000027")]
		public ButtonPressEvent() { }

	}

	[CompilerGenerated]
	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x4000013")]
	private bool <IsValidShortClick>k__BackingField; //Field offset: 0x108
	[CompilerGenerated]
	[FieldOffset(Offset = "0x109")]
	[Token(Token = "0x4000014")]
	private bool <IsValidLongClick>k__BackingField; //Field offset: 0x109
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10A")]
	[Token(Token = "0x4000015")]
	private bool <IsInvalidButton>k__BackingField; //Field offset: 0x10A
	[FieldOffset(Offset = "0x110")]
	[Token(Token = "0x4000016")]
	private ButtonClickedEvent onShortPress; //Field offset: 0x110
	[FieldOffset(Offset = "0x118")]
	[Token(Token = "0x4000017")]
	private ButtonClickedEvent onLongPress; //Field offset: 0x118
	[FieldOffset(Offset = "0x120")]
	[SerializeField]
	[Token(Token = "0x4000018")]
	private float clickInterval; //Field offset: 0x120
	[FieldOffset(Offset = "0x124")]
	[SerializeField]
	[Token(Token = "0x4000019")]
	private float longPressThreshold; //Field offset: 0x124
	[FieldOffset(Offset = "0x128")]
	[Token(Token = "0x400001A")]
	private float clickDelay; //Field offset: 0x128
	[FieldOffset(Offset = "0x12C")]
	[Token(Token = "0x400001B")]
	private float pressingTime; //Field offset: 0x12C
	[FieldOffset(Offset = "0x130")]
	[SerializeField]
	[Token(Token = "0x400001C")]
	protected ButtonState _State; //Field offset: 0x130
	[FieldOffset(Offset = "0x138")]
	[SerializeField]
	[Token(Token = "0x400001D")]
	protected UITextMeshPro[] _TextLists; //Field offset: 0x138
	[FieldOffset(Offset = "0x140")]
	[SerializeField]
	[Token(Token = "0x400001E")]
	protected Image[] _ImageLists; //Field offset: 0x140
	[FieldOffset(Offset = "0x148")]
	[SerializeField]
	[Token(Token = "0x400001F")]
	protected ButtonImageExchangeInfo[] _ImagePools; //Field offset: 0x148
	[FieldOffset(Offset = "0x150")]
	[SerializeField]
	[Token(Token = "0x4000020")]
	protected ButtonTextExchangeInfo[] _TextPools; //Field offset: 0x150
	[FieldOffset(Offset = "0x158")]
	[SerializeField]
	[Token(Token = "0x4000021")]
	protected UINew _newImage; //Field offset: 0x158

	[Token(Token = "0x17000005")]
	public bool IsEntering
	{
		[Address(RVA = "0x1E167C0", Offset = "0x1E15BC0", Length = "0xB")]
		[Token(Token = "0x6000022")]
		 get { } //Length: 11
	}

	[Token(Token = "0x17000006")]
	public bool IsEnteringAnimation
	{
		[Address(RVA = "0x1E167C0", Offset = "0x1E15BC0", Length = "0xB")]
		[Token(Token = "0x6000023")]
		 get { } //Length: 11
	}

	[Token(Token = "0x17000003")]
	public private bool IsInvalidButton
	{
		[Address(RVA = "0x1E167D0", Offset = "0x1E15BD0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x600001F")]
		 get { } //Length: 8
		[Address(RVA = "0x1E16820", Offset = "0x1E15C20", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x6000020")]
		private set { } //Length: 7
	}

	[Token(Token = "0x17000004")]
	public bool IsPressing
	{
		[Address(RVA = "0x1E167E0", Offset = "0x1E15BE0", Length = "0xB")]
		[Token(Token = "0x6000021")]
		 get { } //Length: 11
	}

	[Token(Token = "0x17000002")]
	public private bool IsValidLongClick
	{
		[Address(RVA = "0x1E167F0", Offset = "0x1E15BF0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x600001D")]
		 get { } //Length: 8
		[Address(RVA = "0x1E16830", Offset = "0x1E15C30", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x600001E")]
		private set { } //Length: 7
	}

	[Token(Token = "0x17000001")]
	public private bool IsValidShortClick
	{
		[Address(RVA = "0x1E16800", Offset = "0x1E15C00", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x600001B")]
		 get { } //Length: 8
		[Address(RVA = "0x1E16840", Offset = "0x1E15C40", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x600001C")]
		private set { } //Length: 7
	}

	[Token(Token = "0x17000008")]
	public UINew NewImage
	{
		[Address(RVA = "0x1E16810", Offset = "0x1E15C10", Length = "0x8")]
		[Token(Token = "0x6000025")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000007")]
	public ButtonState State
	{
		[Address(RVA = "0x1D11BF0", Offset = "0x1D10FF0", Length = "0x7")]
		[Token(Token = "0x6000024")]
		 get { } //Length: 7
	}

	[Address(RVA = "0x1E164D0", Offset = "0x1E158D0", Length = "0x16D")]
	[Token(Token = "0x6000017")]
	protected override ButtonImageExchangeInfo _GetImage(Image image, ButtonState iState) { }

	[Address(RVA = "0x1E16640", Offset = "0x1E15A40", Length = "0x29")]
	[Token(Token = "0x600001A")]
	private void _OnChangeState(ButtonState value, bool isChangeOK) { }

	[Address(RVA = "0x1E16670", Offset = "0x1E15A70", Length = "0x37")]
	[Token(Token = "0x6000013")]
	protected override void _OnClicked() { }

	[Address(RVA = "0x1E166B0", Offset = "0x1E15AB0", Length = "0x51")]
	[Token(Token = "0x6000014")]
	protected void _UpdateDelayInterval() { }

	[Address(RVA = "0x1E16710", Offset = "0x1E15B10", Length = "0xAF")]
	[Token(Token = "0x6000026")]
	public ButtonBase() { }

	[Address(RVA = "0x1E15B40", Offset = "0x1E14F40", Length = "0x2E")]
	[Token(Token = "0x6000008")]
	public void ClearLongClick() { }

	[Address(RVA = "0x1E15B70", Offset = "0x1E14F70", Length = "0x2E")]
	[Token(Token = "0x6000007")]
	public void ClearOnClick() { }

	[Address(RVA = "0x1E167C0", Offset = "0x1E15BC0", Length = "0xB")]
	[Token(Token = "0x6000022")]
	public bool get_IsEntering() { }

	[Address(RVA = "0x1E167C0", Offset = "0x1E15BC0", Length = "0xB")]
	[Token(Token = "0x6000023")]
	public bool get_IsEnteringAnimation() { }

	[Address(RVA = "0x1E167D0", Offset = "0x1E15BD0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x600001F")]
	public bool get_IsInvalidButton() { }

	[Address(RVA = "0x1E167E0", Offset = "0x1E15BE0", Length = "0xB")]
	[Token(Token = "0x6000021")]
	public bool get_IsPressing() { }

	[Address(RVA = "0x1E167F0", Offset = "0x1E15BF0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x600001D")]
	public bool get_IsValidLongClick() { }

	[Address(RVA = "0x1E16800", Offset = "0x1E15C00", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x600001B")]
	public bool get_IsValidShortClick() { }

	[Address(RVA = "0x1E16810", Offset = "0x1E15C10", Length = "0x8")]
	[Token(Token = "0x6000025")]
	public UINew get_NewImage() { }

	[Address(RVA = "0x1D11BF0", Offset = "0x1D10FF0", Length = "0x7")]
	[Token(Token = "0x6000024")]
	public ButtonState get_State() { }

	[Address(RVA = "0x1E15BA0", Offset = "0x1E14FA0", Length = "0x7")]
	[Token(Token = "0x6000015")]
	protected override float GetDeltaTime() { }

	[Address(RVA = "0x1E15BB0", Offset = "0x1E14FB0", Length = "0xEE")]
	[Token(Token = "0x6000018")]
	protected override Color GetTextColor(ButtonState iState) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x600000A")]
	public override bool IsAnimation() { }

	[Address(RVA = "0x1E15CA0", Offset = "0x1E150A0", Length = "0x4A")]
	[Token(Token = "0x6000009")]
	public bool IsLock() { }

	[Address(RVA = "0x1E15CF0", Offset = "0x1E150F0", Length = "0xDA")]
	[Token(Token = "0x600000B")]
	public virtual void OnPointerClick(PointerEventData eventData) { }

	[Address(RVA = "0x1E15DD0", Offset = "0x1E151D0", Length = "0x6E")]
	[Token(Token = "0x600000C")]
	public virtual void OnPointerDown(PointerEventData eventData) { }

	[Address(RVA = "0x1E15E40", Offset = "0x1E15240", Length = "0x58")]
	[Token(Token = "0x600000E")]
	public virtual void OnPointerEnter(PointerEventData eventData) { }

	[Address(RVA = "0x1E15EA0", Offset = "0x1E152A0", Length = "0x4F")]
	[Token(Token = "0x600000F")]
	public virtual void OnPointerExit(PointerEventData eventData) { }

	[Address(RVA = "0x1E15EF0", Offset = "0x1E152F0", Length = "0x4F")]
	[Token(Token = "0x600000D")]
	public virtual void OnPointerUp(PointerEventData eventData) { }

	[Address(RVA = "0x1E15F40", Offset = "0x1E15340", Length = "0x137")]
	[Token(Token = "0x6000016")]
	protected override void RefreshImage() { }

	[Address(RVA = "0x1E16820", Offset = "0x1E15C20", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x6000020")]
	private void set_IsInvalidButton(bool value) { }

	[Address(RVA = "0x1E16830", Offset = "0x1E15C30", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x600001E")]
	private void set_IsValidLongClick(bool value) { }

	[Address(RVA = "0x1E16840", Offset = "0x1E15C40", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x600001C")]
	private void set_IsValidShortClick(bool value) { }

	[Address(RVA = "0x1E16080", Offset = "0x1E15480", Length = "0x52")]
	[Token(Token = "0x6000019")]
	public void SetInvalid(bool isSet) { }

	[Address(RVA = "0x1E160E0", Offset = "0x1E154E0", Length = "0xB3")]
	[Token(Token = "0x6000006")]
	public void SetLongClick(Action callback) { }

	[Address(RVA = "0x1E161A0", Offset = "0x1E155A0", Length = "0xB3")]
	[Token(Token = "0x6000005")]
	public void SetOnClick(Action callback) { }

	[Address(RVA = "0x1E16260", Offset = "0x1E15660", Length = "0xA4")]
	[Token(Token = "0x6000010")]
	public void SetState(ButtonState state) { }

	[Address(RVA = "0x1E16310", Offset = "0x1E15710", Length = "0xA4")]
	[Token(Token = "0x6000011")]
	protected virtual void Start() { }

	[Address(RVA = "0x1E163C0", Offset = "0x1E157C0", Length = "0x107")]
	[Token(Token = "0x6000012")]
	protected override void Update() { }

}

