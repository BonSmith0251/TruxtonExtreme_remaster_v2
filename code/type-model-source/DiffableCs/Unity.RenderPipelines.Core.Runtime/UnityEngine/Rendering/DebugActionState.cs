namespace UnityEngine.Rendering;

[Token(Token = "0x2000093")]
internal class DebugActionState
{
	[Token(Token = "0x2000094")]
	private enum DebugActionKeyType : int
	{
		Button = 0,
		Axis = 1,
		Key = 2,
	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001FE")]
	private DebugActionKeyType m_Type; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40001FF")]
	private InputAction inputAction; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000200")]
	private Boolean[] m_TriggerPressedUp; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000201")]
	private float m_Timer; //Field offset: 0x28
	[CompilerGenerated]
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000202")]
	private bool <runningAction>k__BackingField; //Field offset: 0x2C
	[CompilerGenerated]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000203")]
	private float <actionState>k__BackingField; //Field offset: 0x30

	[Token(Token = "0x17000068")]
	internal float actionState
	{
		[Address(RVA = "0x1D33230", Offset = "0x1D32630", Length = "0x6")]
		[CompilerGenerated]
		[Token(Token = "0x6000674")]
		internal get { } //Length: 6
		[Address(RVA = "0x2828CF0", Offset = "0x28280F0", Length = "0x6")]
		[CompilerGenerated]
		[Token(Token = "0x6000675")]
		private set { } //Length: 6
	}

	[Token(Token = "0x17000067")]
	internal bool runningAction
	{
		[Address(RVA = "0x1CC5390", Offset = "0x1CC4790", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000672")]
		internal get { } //Length: 5
		[Address(RVA = "0x25D7F90", Offset = "0x25D7390", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000673")]
		private set { } //Length: 4
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x600067A")]
	public DebugActionState() { }

	[Address(RVA = "0x1D33230", Offset = "0x1D32630", Length = "0x6")]
	[CompilerGenerated]
	[Token(Token = "0x6000674")]
	internal float get_actionState() { }

	[Address(RVA = "0x1CC5390", Offset = "0x1CC4790", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000672")]
	internal bool get_runningAction() { }

	[Address(RVA = "0x2BD4A50", Offset = "0x2BD3E50", Length = "0x18")]
	[Token(Token = "0x6000678")]
	private void Reset() { }

	[Address(RVA = "0x2828CF0", Offset = "0x28280F0", Length = "0x6")]
	[CompilerGenerated]
	[Token(Token = "0x6000675")]
	private void set_actionState(float value) { }

	[Address(RVA = "0x25D7F90", Offset = "0x25D7390", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000673")]
	private void set_runningAction(bool value) { }

	[Address(RVA = "0x2BD4B80", Offset = "0x2BD3F80", Length = "0xBB")]
	[Token(Token = "0x6000676")]
	private void Trigger(int triggerCount, float state) { }

	[Address(RVA = "0x2BD4A70", Offset = "0x2BD3E70", Length = "0x109")]
	[Token(Token = "0x6000677")]
	public void TriggerWithButton(InputAction action, float state) { }

	[Address(RVA = "0x2BD4C40", Offset = "0x2BD4040", Length = "0x185")]
	[Token(Token = "0x6000679")]
	public void Update(DebugActionDesc desc) { }

}

