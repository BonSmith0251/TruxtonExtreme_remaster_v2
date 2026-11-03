namespace UnityEngine.InputSystem.OnScreen;

[AddComponentMenu("Input/On-Screen Button")]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.inputsystem@1.18/manual/OnScreen.html#on-screen-buttons")]
[Token(Token = "0x2000136")]
public class OnScreenButton : OnScreenControl, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
{
	[FieldOffset(Offset = "0x38")]
	[InputControl(layout = "Button")]
	[SerializeField]
	[Token(Token = "0x4000748")]
	private string m_ControlPath; //Field offset: 0x38

	[Token(Token = "0x170003D3")]
	protected virtual string controlPathInternal
	{
		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[Token(Token = "0x6000E59")]
		 get { } //Length: 5
		[Address(RVA = "0x5B7900", Offset = "0x5B6D00", Length = "0xD")]
		[Token(Token = "0x6000E5A")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x5B7910", Offset = "0x5B6D10", Length = "0x7")]
	[Token(Token = "0x6000E5B")]
	public OnScreenButton() { }

	[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
	[Token(Token = "0x6000E59")]
	protected virtual string get_controlPathInternal() { }

	[Address(RVA = "0x29E14B0", Offset = "0x29E08B0", Length = "0x41")]
	[Token(Token = "0x6000E58")]
	public override void OnPointerDown(PointerEventData eventData) { }

	[Address(RVA = "0x29E1500", Offset = "0x29E0900", Length = "0x3C")]
	[Token(Token = "0x6000E57")]
	public override void OnPointerUp(PointerEventData eventData) { }

	[Address(RVA = "0x5B7900", Offset = "0x5B6D00", Length = "0xD")]
	[Token(Token = "0x6000E5A")]
	protected virtual void set_controlPathInternal(string value) { }

}

