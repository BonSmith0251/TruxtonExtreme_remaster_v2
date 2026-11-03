namespace TXEKernel;

[Token(Token = "0x200008A")]
public abstract class RecordValue : RecordValueBase
{
	[Token(Token = "0x200008B")]
	internal class BaseParamsT : BaseParams
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000309")]
		public readonly T DefaultValue; //Field offset: 0x0

		[Address(RVA = "0x169C3C0", Offset = "0x169B7C0", Length = "0x26")]
		[Token(Token = "0x60004C8")]
		public BaseParamsT(string key, T defaultValue) { }

		[Address(RVA = "0x169C380", Offset = "0x169B780", Length = "0x33")]
		[Token(Token = "0x60004C9")]
		public BaseParamsT(BaseParamsT<T> other) { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000307")]
	private T _valueNow; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000308")]
	private Nullable<T> _valuePrev; //Field offset: 0x0

	[Token(Token = "0x17000193")]
	public T DefaultValue
	{
		[Address(RVA = "0xF4ABC0", Offset = "0xF49FC0", Length = "0xC9")]
		[Token(Token = "0x60004C4")]
		 get { } //Length: 201
	}

	[Token(Token = "0x17000194")]
	public override T Value
	{
		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[Token(Token = "0x60004C5")]
		 get { } //Length: 4
		[Address(RVA = "0xF4AFB0", Offset = "0xF4A3B0", Length = "0x4")]
		[Token(Token = "0x60004C6")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000195")]
	public T ValuePrev
	{
		[Address(RVA = "0xF4AED0", Offset = "0xF4A2D0", Length = "0x27")]
		[Token(Token = "0x60004C7")]
		 get { } //Length: 39
	}

	[Address(RVA = "0xF4A6E0", Offset = "0xF49AE0", Length = "0xC6")]
	[Token(Token = "0x60004B9")]
	public RecordValue`1(string key, T defaultValue = null) { }

	[Address(RVA = "0xF4AA00", Offset = "0xF49E00", Length = "0x43")]
	[Token(Token = "0x60004BA")]
	public RecordValue`1(BaseParamsT<T> p) { }

	[Address(RVA = "0xF4A6A0", Offset = "0xF49AA0", Length = "0x3B")]
	[Token(Token = "0x60004BB")]
	public RecordValue`1(RecordValue<T> other) { }

	[Address(RVA = "0xF48D80", Offset = "0xF48180", Length = "0x32")]
	[Token(Token = "0x60004C3")]
	public virtual void CompleteReset() { }

	[Address(RVA = "0xF48E90", Offset = "0xF48290", Length = "0x21")]
	[Token(Token = "0x60004BC")]
	protected void Copy(RecordValue<T> other) { }

	[Address(RVA = "0xF4ABC0", Offset = "0xF49FC0", Length = "0xC9")]
	[Token(Token = "0x60004C4")]
	public T get_DefaultValue() { }

	[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
	[Token(Token = "0x60004C5")]
	public override T get_Value() { }

	[Address(RVA = "0xF4AED0", Offset = "0xF4A2D0", Length = "0x27")]
	[Token(Token = "0x60004C7")]
	public T get_ValuePrev() { }

	[Address(RVA = "0xF49050", Offset = "0xF48450", Length = "0x70")]
	[Token(Token = "0x60004BD")]
	public virtual bool IsChanged() { }

	[Address(RVA = "0xF49620", Offset = "0xF48A20", Length = "0x6B")]
	[Token(Token = "0x60004BE")]
	public virtual bool IsDefault() { }

	[Address(RVA = "0xF499B0", Offset = "0xF48DB0", Length = "0x18B")]
	[Token(Token = "0x60004BF")]
	public virtual bool Load() { }

	[Address(RVA = "0xF49F50", Offset = "0xF49350", Length = "0x51")]
	[Token(Token = "0x60004C1")]
	public virtual void RollBack() { }

	[Address(RVA = "0xF4A4A0", Offset = "0xF498A0", Length = "0xE9")]
	[Token(Token = "0x60004C0")]
	public virtual void Save(bool forceFlg = false) { }

	[Address(RVA = "0xF4AFB0", Offset = "0xF4A3B0", Length = "0x4")]
	[Token(Token = "0x60004C6")]
	public override void set_Value(T value) { }

	[Address(RVA = "0xF4A5C0", Offset = "0xF499C0", Length = "0x26")]
	[Token(Token = "0x60004C2")]
	public virtual void SetDefault() { }

}

