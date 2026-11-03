namespace UnityEngine.InputSystem.Composites;

[DisplayName("Binding With One Modifier")]
[DisplayStringFormat("{modifier}+{binding}")]
[Token(Token = "0x2000278")]
public class OneModifierComposite : InputBindingComposite
{
	[Token(Token = "0x2000279")]
	internal enum ModifiersOrder : int
	{
		Default = 0,
		Ordered = 1,
		Unordered = 2,
	}

	[FieldOffset(Offset = "0x10")]
	[InputControl(layout = "Button")]
	[Token(Token = "0x4000D15")]
	public int modifier; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[InputControl]
	[Token(Token = "0x4000D16")]
	public int binding; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Obsolete("Use ModifiersOrder.Unordered with 'modifiersOrder' instead")]
	[Token(Token = "0x4000D17")]
	[Tooltip("Obsolete please use modifiers Order. If enabled, this will override the Input Consumption setting, allowing the modifier keys to be pressed after the button and the composite will still trigger.")]
	public bool overrideModifiersNeedToBePressedFirst; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000D18")]
	[Tooltip("By default it follows the Input Consumption setting to determine if the modifers keys need to be pressed first.")]
	public ModifiersOrder modifiersOrder; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000D19")]
	private int m_ValueSizeInBytes; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000D1A")]
	private Type m_ValueType; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000D1B")]
	private bool m_BindingIsButton; //Field offset: 0x30

	[Token(Token = "0x1700061A")]
	public virtual int valueSizeInBytes
	{
		[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
		[Token(Token = "0x60016CF")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000619")]
	public virtual Type valueType
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x60016CE")]
		 get { } //Length: 5
	}

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x60016D6")]
	public OneModifierComposite() { }

	[Address(RVA = "0x2924A40", Offset = "0x2923E40", Length = "0x454")]
	[Token(Token = "0x60016D5")]
	internal static void DetermineValueTypeAndSize(ref InputBindingCompositeContext context, int part, out Type valueType, out int valueSizeInBytes, out bool isButton) { }

	[Address(RVA = "0x2924EA0", Offset = "0x29242A0", Length = "0x88")]
	[Token(Token = "0x60016D0")]
	public virtual float EvaluateMagnitude(ref InputBindingCompositeContext context) { }

	[Address(RVA = "0x2924F30", Offset = "0x2924330", Length = "0xAE")]
	[Token(Token = "0x60016D3")]
	protected virtual void FinishSetup(ref InputBindingCompositeContext context) { }

	[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
	[Token(Token = "0x60016CF")]
	public virtual int get_valueSizeInBytes() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x60016CE")]
	public virtual Type get_valueType() { }

	[Address(RVA = "0x2924FE0", Offset = "0x29243E0", Length = "0x69")]
	[Token(Token = "0x60016D2")]
	private bool ModifierIsPressed(ref InputBindingCompositeContext context) { }

	[Address(RVA = "0x29250A0", Offset = "0x29244A0", Length = "0xB2")]
	[Token(Token = "0x60016D1")]
	public virtual void ReadValue(ref InputBindingCompositeContext context, Void* buffer, int bufferSize) { }

	[Address(RVA = "0x2925050", Offset = "0x2924450", Length = "0x47")]
	[Token(Token = "0x60016D4")]
	public virtual object ReadValueAsObject(ref InputBindingCompositeContext context) { }

}

