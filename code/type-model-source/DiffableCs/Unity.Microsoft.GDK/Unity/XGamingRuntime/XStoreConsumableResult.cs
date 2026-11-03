namespace Unity.XGamingRuntime;

[Token(Token = "0x2000272")]
public class XStoreConsumableResult
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40006A6")]
	internal XStoreConsumableResult interop; //Field offset: 0x10

	[Token(Token = "0x170002C1")]
	public uint Quantity
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[Token(Token = "0x6000CEB")]
		 get { } //Length: 85
		[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
		[Token(Token = "0x6000CEC")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x28A9B20", Offset = "0x28A8F20", Length = "0x24")]
	[Token(Token = "0x6000CE9")]
	internal XStoreConsumableResult(XStoreConsumableResult interop) { }

	[Address(RVA = "0x2B6DFE0", Offset = "0x2B6D3E0", Length = "0x1B")]
	[Token(Token = "0x6000CEA")]
	public XStoreConsumableResult() { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[Token(Token = "0x6000CEB")]
	public uint get_Quantity() { }

	[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
	[Token(Token = "0x6000CEC")]
	public void set_Quantity(uint value) { }

}

