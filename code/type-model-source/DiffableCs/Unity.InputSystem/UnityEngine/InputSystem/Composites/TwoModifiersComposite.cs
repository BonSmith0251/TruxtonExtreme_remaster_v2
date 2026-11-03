namespace UnityEngine.InputSystem.Composites;

[DisplayName("Binding With Two Modifiers")]
[DisplayStringFormat("{modifier1}+{modifier2}+{binding}")]
[Token(Token = "0x200027A")]
public class TwoModifiersComposite : InputBindingComposite
{
	[Token(Token = "0x200027B")]
	internal enum ModifiersOrder : int
	{
		Default = 0,
		Ordered = 1,
		Unordered = 2,
	}

	[FieldOffset(Offset = "0x10")]
	[InputControl(layout = "Button")]
	[Token(Token = "0x4000D20")]
	public int modifier1; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[InputControl(layout = "Button")]
	[Token(Token = "0x4000D21")]
	public int modifier2; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[InputControl]
	[Token(Token = "0x4000D22")]
	public int binding; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Obsolete("Use ModifiersOrder.Unordered with 'modifiersOrder' instead")]
	[Token(Token = "0x4000D23")]
	[Tooltip("Obsolete please use modifiers Order. If enabled, this will override the Input Consumption setting, allowing the modifier keys to be pressed after the button and the composite will still trigger.")]
	public bool overrideModifiersNeedToBePressedFirst; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000D24")]
	[Tooltip("By default it follows the Input Consumption setting to determine if the modifers keys need to be pressed first.")]
	public ModifiersOrder modifiersOrder; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000D25")]
	private int m_ValueSizeInBytes; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000D26")]
	private Type m_ValueType; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000D27")]
	private bool m_BindingIsButton; //Field offset: 0x30

	[Token(Token = "0x1700061C")]
	public virtual int valueSizeInBytes
	{
		[Address(RVA = "0xEA4200", Offset = "0xEA3600", Length = "0x4")]
		[Token(Token = "0x60016D8")]
		 get { } //Length: 4
	}

	[Token(Token = "0x1700061B")]
	public virtual Type valueType
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x60016D7")]
		 get { } //Length: 5
	}

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x60016DE")]
	public TwoModifiersComposite() { }

	[Address(RVA = "0x2929660", Offset = "0x2928A60", Length = "0x42")]
	[Token(Token = "0x60016D9")]
	public virtual float EvaluateMagnitude(ref InputBindingCompositeContext context) { }

	[Address(RVA = "0x29296B0", Offset = "0x2928AB0", Length = "0xAE")]
	[Token(Token = "0x60016DC")]
	protected virtual void FinishSetup(ref InputBindingCompositeContext context) { }

	[Address(RVA = "0xEA4200", Offset = "0xEA3600", Length = "0x4")]
	[Token(Token = "0x60016D8")]
	public virtual int get_valueSizeInBytes() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x60016D7")]
	public virtual Type get_valueType() { }

	[Address(RVA = "0x2929760", Offset = "0x2928B60", Length = "0xB9")]
	[Token(Token = "0x60016DB")]
	private bool ModifiersArePressed(ref InputBindingCompositeContext context) { }

	[Address(RVA = "0x2929880", Offset = "0x2928C80", Length = "0x6C")]
	[Token(Token = "0x60016DA")]
	public virtual void ReadValue(ref InputBindingCompositeContext context, Void* buffer, int bufferSize) { }

	[Address(RVA = "0x2929820", Offset = "0x2928C20", Length = "0x59")]
	[Token(Token = "0x60016DD")]
	public virtual object ReadValueAsObject(ref InputBindingCompositeContext context) { }

}

