namespace KANAI.UI;

[Token(Token = "0x200000C")]
public class SimpleButtonBase : Button
{
	[FieldOffset(Offset = "0x108")]
	[Readonly]
	[SerializeField]
	[Token(Token = "0x4000026")]
	protected ButtonState _State; //Field offset: 0x108
	[FieldOffset(Offset = "0x10C")]
	[SerializeField]
	[Token(Token = "0x4000027")]
	private float clickInterval; //Field offset: 0x10C
	[FieldOffset(Offset = "0x110")]
	[Token(Token = "0x4000028")]
	private float clickDelay; //Field offset: 0x110
	[CompilerGenerated]
	[FieldOffset(Offset = "0x114")]
	[Token(Token = "0x4000029")]
	private bool <IsInvalidButton>k__BackingField; //Field offset: 0x114
	[FieldOffset(Offset = "0x118")]
	[Token(Token = "0x400002A")]
	private ButtonClickedEvent _onClickButton; //Field offset: 0x118

	[Token(Token = "0x1700000B")]
	public bool IsInvalidButton
	{
		[Address(RVA = "0x1E17310", Offset = "0x1E16710", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x600003E")]
		 get { } //Length: 8
		[Address(RVA = "0x1E17340", Offset = "0x1E16740", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x600003F")]
		 set { } //Length: 7
	}

	[Token(Token = "0x1700000C")]
	public bool IsPressing
	{
		[Address(RVA = "0x1E17320", Offset = "0x1E16720", Length = "0xB")]
		[Token(Token = "0x6000040")]
		 get { } //Length: 11
	}

	[Token(Token = "0x1700000A")]
	public ButtonState State
	{
		[Address(RVA = "0x1E17330", Offset = "0x1E16730", Length = "0x7")]
		[Token(Token = "0x600003D")]
		 get { } //Length: 7
	}

	[Address(RVA = "0x1E17240", Offset = "0x1E16640", Length = "0x15")]
	[Token(Token = "0x600003C")]
	private void _OnChangeState(ButtonState value, bool isChangeOK) { }

	[Address(RVA = "0x1E17260", Offset = "0x1E16660", Length = "0x2E")]
	[Token(Token = "0x6000039")]
	protected override void _OnClicked() { }

	[Address(RVA = "0x1E171E0", Offset = "0x1E165E0", Length = "0x51")]
	[Token(Token = "0x600003A")]
	protected void _UpdateDelayInterval() { }

	[Address(RVA = "0x1E17290", Offset = "0x1E16690", Length = "0x76")]
	[Token(Token = "0x6000041")]
	public SimpleButtonBase() { }

	[Address(RVA = "0x1E16DA0", Offset = "0x1E161A0", Length = "0x20")]
	[Token(Token = "0x6000030")]
	public void ClearOnClick() { }

	[Address(RVA = "0x1E17310", Offset = "0x1E16710", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x600003E")]
	public bool get_IsInvalidButton() { }

	[Address(RVA = "0x1E17320", Offset = "0x1E16720", Length = "0xB")]
	[Token(Token = "0x6000040")]
	public bool get_IsPressing() { }

	[Address(RVA = "0x1E17330", Offset = "0x1E16730", Length = "0x7")]
	[Token(Token = "0x600003D")]
	public ButtonState get_State() { }

	[Address(RVA = "0x1E15BA0", Offset = "0x1E14FA0", Length = "0x7")]
	[Token(Token = "0x600003B")]
	protected override float GetDeltaTime() { }

	[Address(RVA = "0x1E16DD0", Offset = "0x1E161D0", Length = "0x4A")]
	[Token(Token = "0x6000031")]
	public bool IsLock() { }

	[Address(RVA = "0x1E16E20", Offset = "0x1E16220", Length = "0xDA")]
	[Token(Token = "0x6000032")]
	public virtual void OnPointerClick(PointerEventData eventData) { }

	[Address(RVA = "0x1E16F00", Offset = "0x1E16300", Length = "0x49")]
	[Token(Token = "0x6000033")]
	public virtual void OnPointerDown(PointerEventData eventData) { }

	[Address(RVA = "0x1E16F50", Offset = "0x1E16350", Length = "0x33")]
	[Token(Token = "0x6000035")]
	public virtual void OnPointerEnter(PointerEventData eventData) { }

	[Address(RVA = "0x1E16F90", Offset = "0x1E16390", Length = "0x2A")]
	[Token(Token = "0x6000036")]
	public virtual void OnPointerExit(PointerEventData eventData) { }

	[Address(RVA = "0x1E16FC0", Offset = "0x1E163C0", Length = "0x33")]
	[Token(Token = "0x6000034")]
	public virtual void OnPointerUp(PointerEventData eventData) { }

	[Address(RVA = "0x1E17340", Offset = "0x1E16740", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x600003F")]
	public void set_IsInvalidButton(bool value) { }

	[Address(RVA = "0x1E17000", Offset = "0x1E16400", Length = "0xA5")]
	[Token(Token = "0x600002F")]
	public void SetOnClick(Action callback) { }

	[Address(RVA = "0x1E170B0", Offset = "0x1E164B0", Length = "0x92")]
	[Token(Token = "0x6000037")]
	public void SetState(ButtonState state) { }

	[Address(RVA = "0x1E17150", Offset = "0x1E16550", Length = "0x8D")]
	[Token(Token = "0x600002E")]
	protected virtual void Start() { }

	[Address(RVA = "0x1E171E0", Offset = "0x1E165E0", Length = "0x51")]
	[Token(Token = "0x6000038")]
	protected override void Update() { }

}

