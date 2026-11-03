namespace TXEKernel;

[Token(Token = "0x2000088")]
public abstract class RecordValueBase
{
	[Token(Token = "0x2000089")]
	internal class BaseParams
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000306")]
		private readonly string _key; //Field offset: 0x10

		[Token(Token = "0x17000191")]
		public string Key
		{
			[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
			[Token(Token = "0x60004B7")]
			 get { } //Length: 5
		}

		[Token(Token = "0x17000192")]
		public string UnencryptedKey
		{
			[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
			[Token(Token = "0x60004B8")]
			 get { } //Length: 5
		}

		[Address(RVA = "0x26ED8F0", Offset = "0x26ECCF0", Length = "0x6F")]
		[Token(Token = "0x60004B5")]
		public BaseParams(string key) { }

		[Address(RVA = "0x26ED960", Offset = "0x26ECD60", Length = "0x3C")]
		[Token(Token = "0x60004B6")]
		public BaseParams(BaseParams other) { }

		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x60004B7")]
		public string get_Key() { }

		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x60004B8")]
		public string get_UnencryptedKey() { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000305")]
	protected readonly BaseParams _params; //Field offset: 0x10

	[Token(Token = "0x1700018F")]
	public string RecordKey
	{
		[Address(RVA = "0x141B2F0", Offset = "0x141A6F0", Length = "0x1B")]
		[Token(Token = "0x60004B3")]
		 get { } //Length: 27
	}

	[Token(Token = "0x17000190")]
	public string UnencryptedKey
	{
		[Address(RVA = "0x141B2F0", Offset = "0x141A6F0", Length = "0x1B")]
		[Token(Token = "0x60004B4")]
		 get { } //Length: 27
	}

	[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
	[Token(Token = "0x60004AA")]
	public RecordValueBase(BaseParams p) { }

	[Address(RVA = "0x26F6BC0", Offset = "0x26F5FC0", Length = "0x97")]
	[Token(Token = "0x60004AB")]
	public RecordValueBase(RecordValueBase other) { }

	[Token(Token = "0x60004B2")]
	public abstract void CompleteReset() { }

	[Address(RVA = "0x141B2F0", Offset = "0x141A6F0", Length = "0x1B")]
	[Token(Token = "0x60004B3")]
	public string get_RecordKey() { }

	[Address(RVA = "0x141B2F0", Offset = "0x141A6F0", Length = "0x1B")]
	[Token(Token = "0x60004B4")]
	public string get_UnencryptedKey() { }

	[Token(Token = "0x60004AC")]
	public abstract bool IsChanged() { }

	[Token(Token = "0x60004AD")]
	public abstract bool IsDefault() { }

	[Token(Token = "0x60004AE")]
	public abstract bool Load() { }

	[Token(Token = "0x60004B0")]
	public abstract void RollBack() { }

	[Token(Token = "0x60004AF")]
	public abstract void Save(bool forceFlg = false) { }

	[Token(Token = "0x60004B1")]
	public abstract void SetDefault() { }

}

