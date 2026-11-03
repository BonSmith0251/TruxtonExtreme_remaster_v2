namespace TXEKernel;

[Token(Token = "0x200008C")]
public abstract class RecordClampedValue : RecordValue<T>
{
	[Token(Token = "0x200008D")]
	internal class ClampedValueParams : BaseParamsT<T>
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400030A")]
		public readonly T MaxValue; //Field offset: 0x0

		[Address(RVA = "0x16D2420", Offset = "0x16D1820", Length = "0x3D")]
		[Token(Token = "0x60004D1")]
		public ClampedValueParams(string label, T maxValue, T defaultValue) { }

		[Address(RVA = "0x16D23A0", Offset = "0x16D17A0", Length = "0x3F")]
		[Token(Token = "0x60004D2")]
		public ClampedValueParams(ClampedValueParams<T> other) { }

	}


	[Token(Token = "0x17000196")]
	public T MaxValue
	{
		[Address(RVA = "0xF48890", Offset = "0xF47C90", Length = "0xC9")]
		[Token(Token = "0x60004CE")]
		 get { } //Length: 201
	}

	[Token(Token = "0x17000197")]
	public virtual T Value
	{
		[Address(RVA = "0xF48C10", Offset = "0xF48010", Length = "0x16")]
		[Token(Token = "0x60004CF")]
		 get { } //Length: 22
		[Address(RVA = "0xF48D50", Offset = "0xF48150", Length = "0x25")]
		[Token(Token = "0x60004D0")]
		 set { } //Length: 37
	}

	[Address(RVA = "0xF48200", Offset = "0xF47600", Length = "0xDE")]
	[Token(Token = "0x60004CA")]
	public RecordClampedValue`1(string key, T maxValue, T defaultValue = null) { }

	[Address(RVA = "0xF48490", Offset = "0xF47890", Length = "0x4F")]
	[Token(Token = "0x60004CB")]
	public RecordClampedValue`1(ClampedValueParams<T> p) { }

	[Address(RVA = "0xF48360", Offset = "0xF47760", Length = "0x12A")]
	[Token(Token = "0x60004CC")]
	public RecordClampedValue`1(RecordClampedValue<T> other) { }

	[Token(Token = "0x60004CD")]
	public abstract T Clamp(T v) { }

	[Address(RVA = "0xF48890", Offset = "0xF47C90", Length = "0xC9")]
	[Token(Token = "0x60004CE")]
	public T get_MaxValue() { }

	[Address(RVA = "0xF48C10", Offset = "0xF48010", Length = "0x16")]
	[Token(Token = "0x60004CF")]
	public virtual T get_Value() { }

	[Address(RVA = "0xF48D50", Offset = "0xF48150", Length = "0x25")]
	[Token(Token = "0x60004D0")]
	public virtual void set_Value(T value) { }

}

