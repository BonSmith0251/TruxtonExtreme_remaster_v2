namespace UnityEngine.InputSystem;

[Token(Token = "0x2000072")]
public abstract class InputControl : InputControl
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400029F")]
	internal InlinedArray<InputProcessor`1<TValue>> m_ProcessorStack; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40002A0")]
	private TValue m_CachedValue; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40002A1")]
	private TValue m_UnprocessedCachedValue; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40002A2")]
	internal bool evaluateProcessorsEveryRead; //Field offset: 0x0

	[Token(Token = "0x17000194")]
	internal InputProcessor<TValue>[] processors
	{
		[Address(RVA = "0x1CB3C90", Offset = "0x1CB3090", Length = "0x1E")]
		[Token(Token = "0x600056C")]
		internal get { } //Length: 30
	}

	[IsReadOnly]
	[Token(Token = "0x17000193")]
	internal TValue unprocessedValue
	{
		[Address(RVA = "0x1CB3F20", Offset = "0x1CB3320", Length = "0xD9")]
		[Token(Token = "0x6000556")]
		internal get { } //Length: 217
	}

	[IsReadOnly]
	[Token(Token = "0x17000192")]
	public TValue value
	{
		[Address(RVA = "0x1CB4EE0", Offset = "0x1CB42E0", Length = "0x103")]
		[Token(Token = "0x6000555")]
		 get { } //Length: 259
	}

	[Token(Token = "0x17000191")]
	public virtual int valueSizeInBytes
	{
		[Address(RVA = "0x9DCBC0", Offset = "0x9DBFC0", Length = "0x6")]
		[Token(Token = "0x6000554")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000190")]
	public virtual Type valueType
	{
		[Address(RVA = "0xE36D40", Offset = "0xE36140", Length = "0x38")]
		[Token(Token = "0x6000553")]
		 get { } //Length: 56
	}

	[Address(RVA = "0x1CB3C80", Offset = "0x1CB3080", Length = "0x7")]
	[Token(Token = "0x600056D")]
	protected InputControl`1() { }

	[Address(RVA = "0x1CA3B70", Offset = "0x1CA2F70", Length = "0x1F9")]
	[Token(Token = "0x600056A")]
	internal virtual void AddProcessor(object processor) { }

	[Address(RVA = "0x1CA5700", Offset = "0x1CA4B00", Length = "0x218")]
	[Token(Token = "0x6000566")]
	public virtual bool CompareValue(Void* firstStatePtr, Void* secondStatePtr) { }

	[Address(RVA = "0x1CA5210", Offset = "0x1CA4610", Length = "0x46")]
	[Token(Token = "0x6000565")]
	private static bool CompareValue(ref TValue firstValue, ref TValue secondValue) { }

	[Address(RVA = "0x1CA6E50", Offset = "0x1CA6250", Length = "0x1F5")]
	[Token(Token = "0x600056B")]
	protected virtual void FinishSetup() { }

	[Address(RVA = "0x1CB3C90", Offset = "0x1CB3090", Length = "0x1E")]
	[Token(Token = "0x600056C")]
	internal InputProcessor<TValue>[] get_processors() { }

	[Address(RVA = "0x1CB3F20", Offset = "0x1CB3320", Length = "0xD9")]
	[Token(Token = "0x6000556")]
	internal TValue get_unprocessedValue() { }

	[Address(RVA = "0x1CB4EE0", Offset = "0x1CB42E0", Length = "0x103")]
	[Token(Token = "0x6000555")]
	public TValue get_value() { }

	[Address(RVA = "0x9DCBC0", Offset = "0x9DBFC0", Length = "0x6")]
	[Token(Token = "0x6000554")]
	public virtual int get_valueSizeInBytes() { }

	[Address(RVA = "0xE36D40", Offset = "0xE36140", Length = "0x38")]
	[Token(Token = "0x6000553")]
	public virtual Type get_valueType() { }

	[Address(RVA = "0x1CA7CB0", Offset = "0x1CA70B0", Length = "0x144")]
	[Token(Token = "0x6000568")]
	public void ProcessValue(ref TValue value) { }

	[Address(RVA = "0x1CA84F0", Offset = "0x1CA78F0", Length = "0x49")]
	[Token(Token = "0x6000567")]
	public TValue ProcessValue(TValue value) { }

	[Address(RVA = "0x1CA8C70", Offset = "0x1CA8070", Length = "0x123")]
	[Token(Token = "0x6000559")]
	public TValue ReadDefaultValue() { }

	[Address(RVA = "0x1CAA5B0", Offset = "0x1CA99B0", Length = "0x3A")]
	[Token(Token = "0x600055D")]
	public TValue ReadUnprocessedValue() { }

	[Token(Token = "0x600055E")]
	public abstract TValue ReadUnprocessedValueFromState(Void* statePtr) { }

	[Address(RVA = "0x1CA9A30", Offset = "0x1CA8E30", Length = "0x96")]
	[Token(Token = "0x600055C")]
	public TValue ReadUnprocessedValueFromStateWithCaching(Void* statePtr) { }

	[Address(RVA = "0x1CB0820", Offset = "0x1CAFC20", Length = "0x3A")]
	[Token(Token = "0x6000557")]
	public TValue ReadValue() { }

	[Address(RVA = "0x1CAB060", Offset = "0x1CAA460", Length = "0x1C0")]
	[Token(Token = "0x6000564")]
	public virtual object ReadValueFromBufferAsObject(Void* buffer, int bufferSize) { }

	[Address(RVA = "0x1CAC260", Offset = "0x1CAB660", Length = "0x104")]
	[Token(Token = "0x6000558")]
	public TValue ReadValueFromPreviousFrame() { }

	[Address(RVA = "0x1CB0190", Offset = "0x1CAF590", Length = "0xD1")]
	[Token(Token = "0x600055A")]
	public TValue ReadValueFromState(Void* statePtr) { }

	[Address(RVA = "0x1CAD0F0", Offset = "0x1CAC4F0", Length = "0x108")]
	[Token(Token = "0x600055F")]
	public virtual object ReadValueFromStateAsObject(Void* statePtr) { }

	[Address(RVA = "0x1CADF90", Offset = "0x1CAD390", Length = "0x214")]
	[Token(Token = "0x6000560")]
	public virtual void ReadValueFromStateIntoBuffer(Void* statePtr, Void* bufferPtr, int bufferSize) { }

	[Address(RVA = "0x1CAF2F0", Offset = "0x1CAE6F0", Length = "0x136")]
	[Token(Token = "0x600055B")]
	public TValue ReadValueFromStateWithCaching(Void* statePtr) { }

	[Address(RVA = "0x69BDD0", Offset = "0x69B1D0", Length = "0x1AF")]
	[Token(Token = "0x6000569")]
	internal TProcessor TryGetProcessor() { }

	[Address(RVA = "0x1CB1D10", Offset = "0x1CB1110", Length = "0x1AB")]
	[Token(Token = "0x6000561")]
	public virtual void WriteValueFromBufferIntoState(Void* bufferPtr, int bufferSize, Void* statePtr) { }

	[Address(RVA = "0x1CB33D0", Offset = "0x1CB27D0", Length = "0x1EE")]
	[Token(Token = "0x6000562")]
	public virtual void WriteValueFromObjectIntoState(object value, Void* statePtr) { }

	[Address(RVA = "0x1CB3C10", Offset = "0x1CB3010", Length = "0x62")]
	[Token(Token = "0x6000563")]
	public override void WriteValueIntoState(TValue value, Void* statePtr) { }

}

