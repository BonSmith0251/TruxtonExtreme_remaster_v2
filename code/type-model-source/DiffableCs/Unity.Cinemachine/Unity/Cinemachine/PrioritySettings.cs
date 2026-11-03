namespace Unity.Cinemachine;

[Token(Token = "0x20000DD")]
public struct PrioritySettings
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400035A")]
	[Tooltip("Enable this to expose the Priority field")]
	public bool Enabled; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[SerializeField]
	[Token(Token = "0x400035B")]
	[Tooltip("Priority to use.  0 is default.  Camera with highest priority is prioritized.")]
	private int m_Value; //Field offset: 0x4

	[Token(Token = "0x170000E0")]
	public int Value
	{
		[Address(RVA = "0x2847AE0", Offset = "0x2846EE0", Length = "0xC")]
		[IsReadOnly]
		[Token(Token = "0x6000414")]
		 get { } //Length: 12
		[Address(RVA = "0xDA8670", Offset = "0xDA7A70", Length = "0x7")]
		[Token(Token = "0x6000415")]
		 set { } //Length: 7
	}

	[Address(RVA = "0x2847AE0", Offset = "0x2846EE0", Length = "0xC")]
	[IsReadOnly]
	[Token(Token = "0x6000414")]
	public int get_Value() { }

	[Address(RVA = "0x2847AF0", Offset = "0x2846EF0", Length = "0xE")]
	[Token(Token = "0x6000416")]
	public static int op_Implicit(PrioritySettings prioritySettings) { }

	[Address(RVA = "0x239C440", Offset = "0x239B840", Length = "0x18")]
	[Token(Token = "0x6000417")]
	public static PrioritySettings op_Implicit(int priority) { }

	[Address(RVA = "0xDA8670", Offset = "0xDA7A70", Length = "0x7")]
	[Token(Token = "0x6000415")]
	public void set_Value(int value) { }

}

