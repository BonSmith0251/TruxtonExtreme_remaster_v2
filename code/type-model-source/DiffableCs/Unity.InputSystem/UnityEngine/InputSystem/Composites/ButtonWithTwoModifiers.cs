namespace UnityEngine.InputSystem.Composites;

[DesignTimeVisible(False)]
[DisplayStringFormat("{modifier1}+{modifier2}+{button}")]
[Token(Token = "0x2000276")]
public class ButtonWithTwoModifiers : InputBindingComposite<Single>
{
	[Token(Token = "0x2000277")]
	internal enum ModifiersOrder : int
	{
		Default = 0,
		Ordered = 1,
		Unordered = 2,
	}

	[FieldOffset(Offset = "0x10")]
	[InputControl(layout = "Button")]
	[Token(Token = "0x4000D0C")]
	public int modifier1; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[InputControl(layout = "Button")]
	[Token(Token = "0x4000D0D")]
	public int modifier2; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[InputControl(layout = "Button")]
	[Token(Token = "0x4000D0E")]
	public int button; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Obsolete("Use ModifiersOrder.Unordered with 'modifiersOrder' instead")]
	[Token(Token = "0x4000D0F")]
	[Tooltip("Obsolete please use modifiers Order. If enabled, this will override the Input Consumption setting, allowing the modifier keys to be pressed after the button and the composite will still trigger.")]
	public bool overrideModifiersNeedToBePressedFirst; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000D10")]
	[Tooltip("By default it follows the Input Consumption setting to determine if the modifers keys need to be pressed first.")]
	public ModifiersOrder modifiersOrder; //Field offset: 0x20

	[Address(RVA = "0x2921C10", Offset = "0x2921010", Length = "0x39")]
	[Token(Token = "0x60016CD")]
	public ButtonWithTwoModifiers() { }

	[Address(RVA = "0x29217F0", Offset = "0x2920BF0", Length = "0x14")]
	[Token(Token = "0x60016CB")]
	public virtual float EvaluateMagnitude(ref InputBindingCompositeContext context) { }

	[Address(RVA = "0x29219F0", Offset = "0x2920DF0", Length = "0x78")]
	[Token(Token = "0x60016CC")]
	protected virtual void FinishSetup(ref InputBindingCompositeContext context) { }

	[Address(RVA = "0x2921A70", Offset = "0x2920E70", Length = "0xB3")]
	[Token(Token = "0x60016CA")]
	private bool ModifiersArePressed(ref InputBindingCompositeContext context) { }

	[Address(RVA = "0x2921B30", Offset = "0x2920F30", Length = "0xDC")]
	[Token(Token = "0x60016C9")]
	public virtual float ReadValue(ref InputBindingCompositeContext context) { }

}

