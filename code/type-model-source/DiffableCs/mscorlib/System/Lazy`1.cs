namespace System;

[DebuggerDisplay("ThreadSafetyMode={Mode}, IsValueCreated={IsValueCreated}, IsValueFaulted={IsValueFaulted}, Value={ValueForDebugDisplay}")]
[DebuggerTypeProxy(typeof(LazyDebugView`1))]
[Token(Token = "0x2000109")]
public class Lazy
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000404")]
	private LazyHelper _state; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000405")]
	private Func<T> _factory; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000406")]
	private T _value; //Field offset: 0x0

	[Token(Token = "0x17000088")]
	public bool IsValueCreated
	{
		[Address(RVA = "0xAFE580", Offset = "0xAFD980", Length = "0x1B")]
		[Token(Token = "0x600083E")]
		 get { } //Length: 27
	}

	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x17000089")]
	public T Value
	{
		[Address(RVA = "0xAFE5E0", Offset = "0xAFD9E0", Length = "0x1BC")]
		[Token(Token = "0x600083F")]
		 get { } //Length: 444
	}

	[Address(RVA = "0xAFDED0", Offset = "0xAFD2D0", Length = "0x8C")]
	[Token(Token = "0x6000831")]
	public Lazy`1() { }

	[Address(RVA = "0xAFE490", Offset = "0xAFD890", Length = "0xE6")]
	[Token(Token = "0x6000832")]
	public Lazy`1(Func<T> valueFactory) { }

	[Address(RVA = "0xAFE140", Offset = "0xAFD540", Length = "0xC9")]
	[Token(Token = "0x6000833")]
	public Lazy`1(bool isThreadSafe) { }

	[Address(RVA = "0xAFE3A0", Offset = "0xAFD7A0", Length = "0xEE")]
	[Token(Token = "0x6000834")]
	private Lazy`1(Func<T> valueFactory, LazyThreadSafetyMode mode, bool useDefaultConstructor) { }

	[Address(RVA = "0xAFBFD0", Offset = "0xAFB3D0", Length = "0x188")]
	[Token(Token = "0x600083C")]
	private T CreateValue() { }

	[Address(RVA = "0xAFC470", Offset = "0xAFB870", Length = "0xF3")]
	[Token(Token = "0x6000830")]
	private static T CreateViaDefaultConstructor() { }

	[Address(RVA = "0xAFC930", Offset = "0xAFBD30", Length = "0x121")]
	[Token(Token = "0x6000837")]
	private void ExecutionAndPublication(LazyHelper executionAndPublication, bool useDefaultConstructor) { }

	[Address(RVA = "0xAFE580", Offset = "0xAFD980", Length = "0x1B")]
	[Token(Token = "0x600083E")]
	public bool get_IsValueCreated() { }

	[Address(RVA = "0xAFE5E0", Offset = "0xAFD9E0", Length = "0x1BC")]
	[Token(Token = "0x600083F")]
	public T get_Value() { }

	[Address(RVA = "0xAFD2B0", Offset = "0xAFC6B0", Length = "0xAE")]
	[Token(Token = "0x6000838")]
	private void PublicationOnly(LazyHelper publicationOnly, T possibleValue) { }

	[Address(RVA = "0xAFCB40", Offset = "0xAFBF40", Length = "0x59")]
	[Token(Token = "0x6000839")]
	private void PublicationOnlyViaConstructor(LazyHelper initializer) { }

	[Address(RVA = "0xAFCC00", Offset = "0xAFC000", Length = "0x82")]
	[Token(Token = "0x600083A")]
	private void PublicationOnlyViaFactory(LazyHelper initializer) { }

	[Address(RVA = "0xAFCF10", Offset = "0xAFC310", Length = "0x7A")]
	[Token(Token = "0x600083B")]
	private void PublicationOnlyWaitForOtherThreadToPublish() { }

	[Address(RVA = "0xAFD400", Offset = "0xAFC800", Length = "0xB6")]
	[Token(Token = "0x600083D")]
	public virtual string ToString() { }

	[Address(RVA = "0xAFD680", Offset = "0xAFCA80", Length = "0x3D")]
	[Token(Token = "0x6000835")]
	private void ViaConstructor() { }

	[Address(RVA = "0xAFD940", Offset = "0xAFCD40", Length = "0x11B")]
	[Token(Token = "0x6000836")]
	private void ViaFactory(LazyThreadSafetyMode mode) { }

}

