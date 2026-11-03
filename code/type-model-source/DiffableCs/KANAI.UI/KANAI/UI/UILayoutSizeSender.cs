namespace KANAI.UI;

[Token(Token = "0x200002C")]
public class UILayoutSizeSender : UIBehaviour, ILayoutController
{
	[Token(Token = "0x200002D")]
	private class FloatEvent : UnityEvent<Single>
	{

		[Address(RVA = "0x1E168A0", Offset = "0x1E15CA0", Length = "0x39")]
		[Token(Token = "0x6000132")]
		public FloatEvent() { }

	}

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000149")]
	private FloatEvent horizontalSize; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400014A")]
	private FloatEvent verticalSize; //Field offset: 0x28

	[Address(RVA = "0xE31DA0", Offset = "0xE311A0", Length = "0x7")]
	[Token(Token = "0x6000131")]
	public UILayoutSizeSender() { }

	[Address(RVA = "0x1E21FC0", Offset = "0x1E213C0", Length = "0x59")]
	[Token(Token = "0x600012D")]
	public void AddHorizontalSizeEventListener(UnityAction<Single> iEvent) { }

	[Address(RVA = "0x1E22020", Offset = "0x1E21420", Length = "0x59")]
	[Token(Token = "0x600012E")]
	public void AddVerticalSizeEventListener(UnityAction<Single> iEvent) { }

	[Address(RVA = "0x1E22080", Offset = "0x1E21480", Length = "0xC7")]
	[Token(Token = "0x600012B")]
	public void Initialize() { }

	[Address(RVA = "0x1E22150", Offset = "0x1E21550", Length = "0x7F")]
	[Token(Token = "0x600012F")]
	public override void SetLayoutHorizontal() { }

	[Address(RVA = "0x1E221D0", Offset = "0x1E215D0", Length = "0x7F")]
	[Token(Token = "0x6000130")]
	public override void SetLayoutVertical() { }

	[Address(RVA = "0x1E22250", Offset = "0x1E21650", Length = "0x54")]
	[Token(Token = "0x600012C")]
	public void Terminate() { }

}

