namespace UnityEngine.UI;

[AddComponentMenu("UI (Canvas)/Toggle", 30)]
[RequireComponent(typeof(RectTransform))]
[Token(Token = "0x2000075")]
public class Toggle : Selectable, IPointerClickHandler, IEventSystemHandler, ISubmitHandler, ICanvasElement
{
	[Token(Token = "0x2000077")]
	internal class ToggleEvent : UnityEvent<Boolean>
	{

		[Address(RVA = "0x345DD10", Offset = "0x345D110", Length = "0x39")]
		[Token(Token = "0x60004F2")]
		public ToggleEvent() { }

	}

	[Token(Token = "0x2000076")]
	internal enum ToggleTransition : int
	{
		None = 0,
		Fade = 1,
	}

	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x4000250")]
	public ToggleTransition toggleTransition; //Field offset: 0x100
	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x4000251")]
	public Graphic graphic; //Field offset: 0x108
	[FieldOffset(Offset = "0x110")]
	[SerializeField]
	[Token(Token = "0x4000252")]
	private ToggleGroup m_Group; //Field offset: 0x110
	[FieldOffset(Offset = "0x118")]
	[Token(Token = "0x4000253")]
	public ToggleEvent onValueChanged; //Field offset: 0x118
	[FieldOffset(Offset = "0x120")]
	[SerializeField]
	[Token(Token = "0x4000254")]
	[Tooltip("Is the toggle currently on or off?")]
	private bool m_IsOn; //Field offset: 0x120

	[Token(Token = "0x1700014F")]
	public ToggleGroup group
	{
		[Address(RVA = "0x1CF27D0", Offset = "0x1CF1BD0", Length = "0x8")]
		[Token(Token = "0x60004DD")]
		 get { } //Length: 8
		[Address(RVA = "0x345F360", Offset = "0x345E760", Length = "0x26")]
		[Token(Token = "0x60004DE")]
		 set { } //Length: 38
	}

	[Token(Token = "0x17000150")]
	public bool isOn
	{
		[Address(RVA = "0x2142350", Offset = "0x2141750", Length = "0x8")]
		[Token(Token = "0x60004E8")]
		 get { } //Length: 8
		[Address(RVA = "0x345F390", Offset = "0x345E790", Length = "0xB")]
		[Token(Token = "0x60004E9")]
		 set { } //Length: 11
	}

	[Address(RVA = "0x345F2A0", Offset = "0x345E6A0", Length = "0xB8")]
	[Token(Token = "0x60004DF")]
	protected Toggle() { }

	[Address(RVA = "0x1CF27D0", Offset = "0x1CF1BD0", Length = "0x8")]
	[Token(Token = "0x60004DD")]
	public ToggleGroup get_group() { }

	[Address(RVA = "0x2142350", Offset = "0x2141750", Length = "0x8")]
	[Token(Token = "0x60004E8")]
	public bool get_isOn() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60004E2")]
	public override void GraphicUpdateComplete() { }

	[Address(RVA = "0x345EB00", Offset = "0x345DF00", Length = "0x5D")]
	[Token(Token = "0x60004EE")]
	private void InternalToggle() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60004E1")]
	public override void LayoutComplete() { }

	[Address(RVA = "0x345EB60", Offset = "0x345DF60", Length = "0x82")]
	[Token(Token = "0x60004E3")]
	protected virtual void OnDestroy() { }

	[Address(RVA = "0x345EBF0", Offset = "0x345DFF0", Length = "0xCA")]
	[Token(Token = "0x60004E6")]
	protected virtual void OnDidApplyAnimationProperties() { }

	[Address(RVA = "0x345ECC0", Offset = "0x345E0C0", Length = "0x25")]
	[Token(Token = "0x60004E5")]
	protected virtual void OnDisable() { }

	[Address(RVA = "0x345ECF0", Offset = "0x345E0F0", Length = "0x37")]
	[Token(Token = "0x60004E4")]
	protected virtual void OnEnable() { }

	[Address(RVA = "0x345ED30", Offset = "0x345E130", Length = "0x70")]
	[Token(Token = "0x60004EF")]
	public override void OnPointerClick(PointerEventData eventData) { }

	[Address(RVA = "0x345EB00", Offset = "0x345DF00", Length = "0x5D")]
	[Token(Token = "0x60004F0")]
	public override void OnSubmit(BaseEventData eventData) { }

	[Address(RVA = "0x345EDB0", Offset = "0x345E1B0", Length = "0xBF")]
	[Token(Token = "0x60004EC")]
	private void PlayEffect(bool instant) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60004E0")]
	public override void Rebuild(CanvasUpdate executing) { }

	[Address(RVA = "0x345F100", Offset = "0x345E500", Length = "0x183")]
	[Token(Token = "0x60004EB")]
	private void Set(bool value, bool sendCallback = true) { }

	[Address(RVA = "0x345F360", Offset = "0x345E760", Length = "0x26")]
	[Token(Token = "0x60004DE")]
	public void set_group(ToggleGroup value) { }

	[Address(RVA = "0x345F390", Offset = "0x345E790", Length = "0xB")]
	[Token(Token = "0x60004E9")]
	public void set_isOn(bool value) { }

	[Address(RVA = "0x345EE70", Offset = "0x345E270", Length = "0xB")]
	[Token(Token = "0x60004EA")]
	public void SetIsOnWithoutNotify(bool value) { }

	[Address(RVA = "0x345EE80", Offset = "0x345E280", Length = "0x27A")]
	[Token(Token = "0x60004E7")]
	private void SetToggleGroup(ToggleGroup newGroup, bool setMemberValue) { }

	[Address(RVA = "0x345F290", Offset = "0x345E690", Length = "0xA")]
	[Token(Token = "0x60004ED")]
	protected virtual void Start() { }

	[Address(RVA = "0x282F9A0", Offset = "0x282EDA0", Length = "0x7")]
	[Token(Token = "0x60004F1")]
	private override Transform UnityEngine.UI.ICanvasElement.get_transform() { }

}

