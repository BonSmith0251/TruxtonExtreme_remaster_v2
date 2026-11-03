namespace UnityEngine.InputSystem;

[Token(Token = "0x2000067")]
public struct InputInteractionContext
{
	[Flags]
	[Token(Token = "0x2000068")]
	public enum Flags : int
	{
		TimerHasExpired = 2,
	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400024F")]
	internal InputActionState m_State; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000250")]
	internal Flags m_Flags; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000251")]
	internal TriggerState m_TriggerState; //Field offset: 0xC

	[Token(Token = "0x17000159")]
	public InputAction action
	{
		[Address(RVA = "0x293B850", Offset = "0x293AC50", Length = "0x24")]
		[Token(Token = "0x600047E")]
		 get { } //Length: 36
	}

	[Token(Token = "0x17000163")]
	internal int bindingIndex
	{
		[Address(RVA = "0x2161F10", Offset = "0x2161310", Length = "0x5")]
		[Token(Token = "0x6000494")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x1700015A")]
	public InputControl control
	{
		[Address(RVA = "0x293B890", Offset = "0x293AC90", Length = "0x24")]
		[Token(Token = "0x600047F")]
		 get { } //Length: 36
	}

	[Token(Token = "0x17000162")]
	internal int controlIndex
	{
		[Address(RVA = "0x293B880", Offset = "0x293AC80", Length = "0xB")]
		[Token(Token = "0x6000493")]
		internal get { } //Length: 11
	}

	[Token(Token = "0x17000164")]
	internal int interactionIndex
	{
		[Address(RVA = "0x293B8C0", Offset = "0x293ACC0", Length = "0xB")]
		[Token(Token = "0x6000495")]
		internal get { } //Length: 11
	}

	[Token(Token = "0x17000160")]
	public bool isStarted
	{
		[Address(RVA = "0x293B8D0", Offset = "0x293ACD0", Length = "0x8")]
		[Token(Token = "0x6000486")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700015F")]
	public bool isWaiting
	{
		[Address(RVA = "0x293B8E0", Offset = "0x293ACE0", Length = "0x8")]
		[Token(Token = "0x6000485")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000161")]
	internal int mapIndex
	{
		[Address(RVA = "0x293B8F0", Offset = "0x293ACF0", Length = "0x5")]
		[Token(Token = "0x6000492")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x1700015B")]
	public InputActionPhase phase
	{
		[Address(RVA = "0x293B900", Offset = "0x293AD00", Length = "0x5")]
		[Token(Token = "0x6000480")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700015D")]
	public double startTime
	{
		[Address(RVA = "0x293B910", Offset = "0x293AD10", Length = "0x6")]
		[Token(Token = "0x6000482")]
		 get { } //Length: 6
	}

	[Token(Token = "0x1700015C")]
	public double time
	{
		[Address(RVA = "0x293B920", Offset = "0x293AD20", Length = "0x6")]
		[Token(Token = "0x6000481")]
		 get { } //Length: 6
	}

	[Token(Token = "0x1700015E")]
	public internal bool timerHasExpired
	{
		[Address(RVA = "0x292D530", Offset = "0x292C930", Length = "0x8")]
		[Token(Token = "0x6000483")]
		 get { } //Length: 8
		[Address(RVA = "0x292D640", Offset = "0x292CA40", Length = "0x19")]
		[Token(Token = "0x6000484")]
		internal set { } //Length: 25
	}

	[Address(RVA = "0x293B520", Offset = "0x293A920", Length = "0x49")]
	[Token(Token = "0x600048D")]
	public void Canceled() { }

	[Address(RVA = "0x1D376B0", Offset = "0x1D36AB0", Length = "0x6")]
	[Token(Token = "0x6000487")]
	public float ComputeMagnitude() { }

	[Address(RVA = "0x293B570", Offset = "0x293A970", Length = "0x5B")]
	[Token(Token = "0x6000488")]
	public bool ControlIsActuated(float threshold = 0) { }

	[Address(RVA = "0x293B850", Offset = "0x293AC50", Length = "0x24")]
	[Token(Token = "0x600047E")]
	public InputAction get_action() { }

	[Address(RVA = "0x2161F10", Offset = "0x2161310", Length = "0x5")]
	[Token(Token = "0x6000494")]
	internal int get_bindingIndex() { }

	[Address(RVA = "0x293B890", Offset = "0x293AC90", Length = "0x24")]
	[Token(Token = "0x600047F")]
	public InputControl get_control() { }

	[Address(RVA = "0x293B880", Offset = "0x293AC80", Length = "0xB")]
	[Token(Token = "0x6000493")]
	internal int get_controlIndex() { }

	[Address(RVA = "0x293B8C0", Offset = "0x293ACC0", Length = "0xB")]
	[Token(Token = "0x6000495")]
	internal int get_interactionIndex() { }

	[Address(RVA = "0x293B8D0", Offset = "0x293ACD0", Length = "0x8")]
	[Token(Token = "0x6000486")]
	public bool get_isStarted() { }

	[Address(RVA = "0x293B8E0", Offset = "0x293ACE0", Length = "0x8")]
	[Token(Token = "0x6000485")]
	public bool get_isWaiting() { }

	[Address(RVA = "0x293B8F0", Offset = "0x293ACF0", Length = "0x5")]
	[Token(Token = "0x6000492")]
	internal int get_mapIndex() { }

	[Address(RVA = "0x293B900", Offset = "0x293AD00", Length = "0x5")]
	[Token(Token = "0x6000480")]
	public InputActionPhase get_phase() { }

	[Address(RVA = "0x293B910", Offset = "0x293AD10", Length = "0x6")]
	[Token(Token = "0x6000482")]
	public double get_startTime() { }

	[Address(RVA = "0x293B920", Offset = "0x293AD20", Length = "0x6")]
	[Token(Token = "0x6000481")]
	public double get_time() { }

	[Address(RVA = "0x292D530", Offset = "0x292C930", Length = "0x8")]
	[Token(Token = "0x6000483")]
	public bool get_timerHasExpired() { }

	[Address(RVA = "0x293B680", Offset = "0x293AA80", Length = "0x51")]
	[Token(Token = "0x600048A")]
	public void Performed() { }

	[Address(RVA = "0x293B5D0", Offset = "0x293A9D0", Length = "0x4E")]
	[Token(Token = "0x600048C")]
	public void PerformedAndStayPerformed() { }

	[Address(RVA = "0x293B620", Offset = "0x293AA20", Length = "0x51")]
	[Token(Token = "0x600048B")]
	public void PerformedAndStayStarted() { }

	[Address(RVA = "0x847740", Offset = "0x846B40", Length = "0xE6")]
	[Token(Token = "0x6000491")]
	public TValue ReadValue() { }

	[Address(RVA = "0x292D640", Offset = "0x292CA40", Length = "0x19")]
	[Token(Token = "0x6000484")]
	internal void set_timerHasExpired(bool value) { }

	[Address(RVA = "0x293B6E0", Offset = "0x293AAE0", Length = "0x24")]
	[Token(Token = "0x600048F")]
	public void SetTimeout(float seconds) { }

	[Address(RVA = "0x293B710", Offset = "0x293AB10", Length = "0x9A")]
	[Token(Token = "0x6000490")]
	public void SetTotalTimeoutCompletionTime(float seconds) { }

	[Address(RVA = "0x293B7B0", Offset = "0x293ABB0", Length = "0x4B")]
	[Token(Token = "0x6000489")]
	public void Started() { }

	[Address(RVA = "0x293B800", Offset = "0x293AC00", Length = "0x46")]
	[Token(Token = "0x600048E")]
	public void Waiting() { }

}

