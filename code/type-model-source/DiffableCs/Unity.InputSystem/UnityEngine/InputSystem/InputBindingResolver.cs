namespace UnityEngine.InputSystem;

[Token(Token = "0x200005D")]
internal struct InputBindingResolver : IDisposable
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000225")]
	public int totalProcessorCount; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000226")]
	public int totalCompositeCount; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000227")]
	public int totalInteractionCount; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000228")]
	public InputActionMap[] maps; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000229")]
	public InputControl[] controls; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400022A")]
	public UnmanagedMemory memory; //Field offset: 0x20
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x400022B")]
	public IInputInteraction[] interactions; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x400022C")]
	public InputProcessor[] processors; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x400022D")]
	public InputBindingComposite[] composites; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x400022E")]
	public Nullable<InputBinding> bindingMask; //Field offset: 0xB8
	[FieldOffset(Offset = "0x118")]
	[Token(Token = "0x400022F")]
	private bool m_IsControlOnlyResolve; //Field offset: 0x118
	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x4000230")]
	private List<NameAndParameters> m_Parameters; //Field offset: 0x120

	[Token(Token = "0x17000142")]
	public int totalActionCount
	{
		[Address(RVA = "0xE0D780", Offset = "0xE0CB80", Length = "0x4")]
		[Token(Token = "0x600043C")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000143")]
	public int totalBindingCount
	{
		[Address(RVA = "0x1BBC140", Offset = "0x1BBB540", Length = "0x4")]
		[Token(Token = "0x600043D")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000144")]
	public int totalControlCount
	{
		[Address(RVA = "0x115C7B0", Offset = "0x115BBB0", Length = "0x4")]
		[Token(Token = "0x600043E")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000141")]
	public int totalMapCount
	{
		[Address(RVA = "0xE30F80", Offset = "0xE30380", Length = "0x4")]
		[Token(Token = "0x600043B")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x292E7C0", Offset = "0x292DBC0", Length = "0x1B0E")]
	[Token(Token = "0x6000441")]
	public void AddActionMap(InputActionMap actionMap) { }

	[Address(RVA = "0x29302D0", Offset = "0x292F6D0", Length = "0x578")]
	[Token(Token = "0x6000444")]
	private static void ApplyParameters(ReadOnlyArray<NamedValue> parameters, object instance, InputActionMap actionMap, ref InputBinding binding, string objectRegistrationName, string namesAndParameters) { }

	[Address(RVA = "0x2930850", Offset = "0x292FC50", Length = "0x247")]
	[Token(Token = "0x6000445")]
	private static int AssignCompositePartIndex(object composite, string name, ref int currentCompositePartCount) { }

	[Address(RVA = "0x2930AA0", Offset = "0x292FEA0", Length = "0xB")]
	[Token(Token = "0x600043F")]
	public override void Dispose() { }

	[Address(RVA = "0xE0D780", Offset = "0xE0CB80", Length = "0x4")]
	[Token(Token = "0x600043C")]
	public int get_totalActionCount() { }

	[Address(RVA = "0x1BBC140", Offset = "0x1BBB540", Length = "0x4")]
	[Token(Token = "0x600043D")]
	public int get_totalBindingCount() { }

	[Address(RVA = "0x115C7B0", Offset = "0x115BBB0", Length = "0x4")]
	[Token(Token = "0x600043E")]
	public int get_totalControlCount() { }

	[Address(RVA = "0xE30F80", Offset = "0xE30380", Length = "0x4")]
	[Token(Token = "0x600043B")]
	public int get_totalMapCount() { }

	[Address(RVA = "0x2930AB0", Offset = "0x292FEB0", Length = "0x2FF")]
	[Token(Token = "0x6000443")]
	private static InputBindingComposite InstantiateBindingComposite(ref InputBinding binding, InputActionMap actionMap) { }

	[Address(RVA = "0x839B10", Offset = "0x838F10", Length = "0x5D4")]
	[Token(Token = "0x6000442")]
	private int InstantiateWithParameters(TypeTable registrations, string namesAndParameters, ref TType[] array, ref int count, InputActionMap actionMap, ref InputBinding binding) { }

	[Address(RVA = "0x2930DB0", Offset = "0x29301B0", Length = "0x1BD")]
	[Token(Token = "0x6000440")]
	public void StartWithPreviousResolve(InputActionState state, bool isFullResolve) { }

}

