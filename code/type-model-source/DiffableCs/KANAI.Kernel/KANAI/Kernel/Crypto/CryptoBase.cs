namespace KANAI.Kernel.Crypto;

[Token(Token = "0x2000046")]
public class CryptoBase : IDisposable
{
	[Token(Token = "0x4000115")]
	public const int KeyLength = 32; //Field offset: 0x0
	[Token(Token = "0x4000116")]
	public const int InitialVectorLength = 16; //Field offset: 0x0
	[Token(Token = "0x4000117")]
	public const int PaddingSize = 16; //Field offset: 0x0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000118")]
	private PaddingMode <Padding>k__BackingField; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000119")]
	protected AesManaged _aes; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400011A")]
	protected ICryptoTransform _crypto; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400011B")]
	protected CryptoStream _stream; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400011C")]
	protected MemoryStream _buffer; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400011D")]
	private Byte[] _key; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400011E")]
	private BitArray _mask; //Field offset: 0x40

	[Token(Token = "0x1700003F")]
	public PaddingMode Padding
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[CompilerGenerated]
		[Token(Token = "0x600024F")]
		 get { } //Length: 85
		[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000250")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x1DE70F0", Offset = "0x1DE64F0", Length = "0x55")]
	[Token(Token = "0x6000251")]
	public CryptoBase(Byte[] keyData, BitArray maskData) { }

	[Address(RVA = "0x1DE6CB0", Offset = "0x1DE60B0", Length = "0xB8")]
	[Token(Token = "0x6000252")]
	public override void Dispose() { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[CompilerGenerated]
	[Token(Token = "0x600024F")]
	public PaddingMode get_Padding() { }

	[Address(RVA = "0x1DE6D70", Offset = "0x1DE6170", Length = "0xF1")]
	[Token(Token = "0x6000255")]
	public static Byte[] ParseBytes(Byte[] iBuffer, BitArray mask) { }

	[Address(RVA = "0x1DE6E70", Offset = "0x1DE6270", Length = "0x4C")]
	[Token(Token = "0x6000254")]
	public Byte[] Read() { }

	[Address(RVA = "0x1DE6EC0", Offset = "0x1DE62C0", Length = "0x2F")]
	[Token(Token = "0x6000253")]
	public override void Receive(Byte[] data, int offset, int length) { }

	[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000250")]
	public void set_Padding(PaddingMode value) { }

	[Address(RVA = "0x1DE6EF0", Offset = "0x1DE62F0", Length = "0x1F9")]
	[Token(Token = "0x6000256")]
	protected bool SetupAES(Byte[] iv) { }

}

