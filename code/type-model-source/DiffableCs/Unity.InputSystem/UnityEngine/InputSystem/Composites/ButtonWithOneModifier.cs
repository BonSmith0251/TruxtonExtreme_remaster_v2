namespace UnityEngine.InputSystem.Composites;

[DesignTimeVisible(False)]
[DisplayStringFormat("{modifier}+{button}")]
[Token(Token = "0x2000274")]
public class ButtonWithOneModifier : InputBindingComposite<Single>
{
	[Token(Token = "0x2000275")]
	internal enum ModifiersOrder : int
	{
		Default = 0,
		Ordered = 1,
		Unordered = 2,
	}

	[FieldOffset(Offset = "0x10")]
	[InputControl(layout = "Button")]
	[Token(Token = "0x4000D04")]
	public int modifier; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[InputControl(layout = "Button")]
	[Token(Token = "0x4000D05")]
	public int button; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Obsolete("Use ModifiersOrder.Unordered with 'modifiersOrder' instead")]
	[Token(Token = "0x4000D06")]
	[Tooltip("Obsolete please use modifiers Order. If enabled, this will override the Input Consumption setting, allowing the modifier keys to be pressed after the button and the composite will still trigger.")]
	public bool overrideModifiersNeedToBePressedFirst; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000D07")]
	[Tooltip("By default it follows the Input Consumption setting to determine if the modifers keys need to be pressed first.")]
	public ModifiersOrder modifiersOrder; //Field offset: 0x1C

	[Address(RVA = "0x29219B0", Offset = "0x2920DB0", Length = "0x39")]
	[Token(Token = "0x60016C8")]
	public ButtonWithOneModifier() { }

	[Address(RVA = "0x29217F0", Offset = "0x2920BF0", Length = "0x14")]
	[Token(Token = "0x60016C6")]
	public virtual float EvaluateMagnitude(ref InputBindingCompositeContext context) { }

	[Address(RVA = "0x2921810", Offset = "0x2920C10", Length = "0x78")]
	[Token(Token = "0x60016C7")]
	protected virtual void FinishSetup(ref InputBindingCompositeContext context) { }

	[Address(RVA = "0x2921890", Offset = "0x2920C90", Length = "0x63")]
	[Token(Token = "0x60016C5")]
	private bool ModifierIsPressed(ref InputBindingCompositeContext context) { }

	[Address(RVA = "0x2921900", Offset = "0x2920D00", Length = "0xA2")]
	[Token(Token = "0x60016C4")]
	public virtual float ReadValue(ref InputBindingCompositeContext context) { }

}

