namespace Newtonsoft.Json.Bson;

[Obsolete("BSON reading and writing has been moved to its own package. See https://www.nuget.org/packages/Newtonsoft.Json.Bson for more details.")]
[Token(Token = "0x20001D7")]
public class BsonReader : JsonReader
{
	[Token(Token = "0x20001D8")]
	private enum BsonReaderState : int
	{
		Normal = 0,
		ReferenceStart = 1,
		ReferenceRef = 2,
		ReferenceId = 3,
		CodeWScopeStart = 4,
		CodeWScopeCode = 5,
		CodeWScopeScope = 6,
		CodeWScopeScopeObject = 7,
		CodeWScopeScopeEnd = 8,
	}

	[Token(Token = "0x20001D9")]
	private class ContainerContext
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000850")]
		public readonly BsonType Type; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x4000851")]
		public int Length; //Field offset: 0x14
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000852")]
		public int Position; //Field offset: 0x18

		[Address(RVA = "0x21AF260", Offset = "0x21AE660", Length = "0x26")]
		[Token(Token = "0x6000FFF")]
		public ContainerContext(BsonType type) { }

	}

	[Token(Token = "0x4000837")]
	private const int MaxCharBytesSize = 128; //Field offset: 0x0
	[Token(Token = "0x4000838")]
	private static readonly Byte[] SeqRange1; //Field offset: 0x0
	[Token(Token = "0x4000839")]
	private static readonly Byte[] SeqRange2; //Field offset: 0x8
	[Token(Token = "0x400083A")]
	private static readonly Byte[] SeqRange3; //Field offset: 0x10
	[Token(Token = "0x400083B")]
	private static readonly Byte[] SeqRange4; //Field offset: 0x18
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x400083C")]
	private readonly BinaryReader _reader; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x400083D")]
	private readonly List<ContainerContext> _stack; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x400083E")]
	private Byte[] _byteBuffer; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x400083F")]
	private Char[] _charBuffer; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000840")]
	private BsonType _currentElementType; //Field offset: 0x98
	[FieldOffset(Offset = "0x9C")]
	[Token(Token = "0x4000841")]
	private BsonReaderState _bsonReaderState; //Field offset: 0x9C
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000842")]
	private ContainerContext _currentContext; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4000843")]
	private bool _readRootValueAsArray; //Field offset: 0xA8
	[FieldOffset(Offset = "0xA9")]
	[Token(Token = "0x4000844")]
	private bool _jsonNet35BinaryCompatibility; //Field offset: 0xA9
	[FieldOffset(Offset = "0xAC")]
	[Token(Token = "0x4000845")]
	private DateTimeKind _dateTimeKindHandling; //Field offset: 0xAC

	[Token(Token = "0x170002B0")]
	public DateTimeKind DateTimeKindHandling
	{
		[Address(RVA = "0x1F7B610", Offset = "0x1F7AA10", Length = "0x7")]
		[Token(Token = "0x6000FE1")]
		 get { } //Length: 7
		[Address(RVA = "0x21AD620", Offset = "0x21ACA20", Length = "0x7")]
		[Token(Token = "0x6000FE2")]
		 set { } //Length: 7
	}

	[Obsolete("JsonNet35BinaryCompatibility will be removed in a future version of Json.NET.")]
	[Token(Token = "0x170002AE")]
	public bool JsonNet35BinaryCompatibility
	{
		[Address(RVA = "0x1D16D40", Offset = "0x1D16140", Length = "0x8")]
		[Token(Token = "0x6000FDD")]
		 get { } //Length: 8
		[Address(RVA = "0x21AD630", Offset = "0x21ACA30", Length = "0x7")]
		[Token(Token = "0x6000FDE")]
		 set { } //Length: 7
	}

	[Token(Token = "0x170002AF")]
	public bool ReadRootValueAsArray
	{
		[Address(RVA = "0x1D16D50", Offset = "0x1D16150", Length = "0x8")]
		[Token(Token = "0x6000FDF")]
		 get { } //Length: 8
		[Address(RVA = "0x21AD640", Offset = "0x21ACA40", Length = "0x7")]
		[Token(Token = "0x6000FE0")]
		 set { } //Length: 7
	}

	[Address(RVA = "0x21AD0C0", Offset = "0x21AC4C0", Length = "0x1AA")]
	[Token(Token = "0x6000FFE")]
	private static BsonReader() { }

	[Address(RVA = "0x21AD270", Offset = "0x21AC670", Length = "0xD7")]
	[Token(Token = "0x6000FE6")]
	public BsonReader(BinaryReader reader, bool readRootValueAsArray, DateTimeKind dateTimeKindHandling) { }

	[Address(RVA = "0x21AD410", Offset = "0x21AC810", Length = "0xF3")]
	[Token(Token = "0x6000FE3")]
	public BsonReader(Stream stream) { }

	[Address(RVA = "0x21AD350", Offset = "0x21AC750", Length = "0xC0")]
	[Token(Token = "0x6000FE4")]
	public BsonReader(BinaryReader reader) { }

	[Address(RVA = "0x21AD510", Offset = "0x21AC910", Length = "0x10C")]
	[Token(Token = "0x6000FE5")]
	public BsonReader(Stream stream, bool readRootValueAsArray, DateTimeKind dateTimeKindHandling) { }

	[Address(RVA = "0x21AB180", Offset = "0x21AA580", Length = "0x1E9")]
	[Token(Token = "0x6000FF6")]
	private int BytesInSequence(byte b) { }

	[Address(RVA = "0x21AB370", Offset = "0x21AA770", Length = "0x3E")]
	[Token(Token = "0x6000FE9")]
	public virtual void Close() { }

	[Address(RVA = "0x21AB3B0", Offset = "0x21AA7B0", Length = "0xC8")]
	[Token(Token = "0x6000FF7")]
	private void EnsureBuffers() { }

	[Address(RVA = "0x1F7B610", Offset = "0x1F7AA10", Length = "0x7")]
	[Token(Token = "0x6000FE1")]
	public DateTimeKind get_DateTimeKindHandling() { }

	[Address(RVA = "0x1D16D40", Offset = "0x1D16140", Length = "0x8")]
	[Token(Token = "0x6000FDD")]
	public bool get_JsonNet35BinaryCompatibility() { }

	[Address(RVA = "0x1D16D50", Offset = "0x1D16150", Length = "0x8")]
	[Token(Token = "0x6000FDF")]
	public bool get_ReadRootValueAsArray() { }

	[Address(RVA = "0x21AB480", Offset = "0x21AA880", Length = "0x95")]
	[Token(Token = "0x6000FF5")]
	private int GetLastFullCharStop(int start) { }

	[Address(RVA = "0x21AB520", Offset = "0x21AA920", Length = "0x31A")]
	[Token(Token = "0x6000FF4")]
	private string GetString(int length) { }

	[Address(RVA = "0x21AB840", Offset = "0x21AAC40", Length = "0x1E")]
	[Token(Token = "0x6000FFC")]
	private void MovePosition(int count) { }

	[Address(RVA = "0x21AB860", Offset = "0x21AAC60", Length = "0xC0")]
	[Token(Token = "0x6000FED")]
	private void PopContext() { }

	[Address(RVA = "0x21AB930", Offset = "0x21AAD30", Length = "0xBA")]
	[Token(Token = "0x6000FEE")]
	private void PushContext(ContainerContext newContext) { }

	[Address(RVA = "0x21ACF80", Offset = "0x21AC380", Length = "0x11C")]
	[Token(Token = "0x6000FE8")]
	public virtual bool Read() { }

	[Address(RVA = "0x21AB9F0", Offset = "0x21AADF0", Length = "0xFD")]
	[Token(Token = "0x6000FF1")]
	private Byte[] ReadBinary(out BsonBinaryType binaryType) { }

	[Address(RVA = "0x21ABAF0", Offset = "0x21AAEF0", Length = "0x39")]
	[Token(Token = "0x6000FEF")]
	private byte ReadByte() { }

	[Address(RVA = "0x21ABB30", Offset = "0x21AAF30", Length = "0x3A")]
	[Token(Token = "0x6000FFD")]
	private Byte[] ReadBytes(int count) { }

	[Address(RVA = "0x21ABB70", Offset = "0x21AAF70", Length = "0x26B")]
	[Token(Token = "0x6000FEA")]
	private bool ReadCodeWScope() { }

	[Address(RVA = "0x21ABDE0", Offset = "0x21AB1E0", Length = "0x3A")]
	[Token(Token = "0x6000FF8")]
	private double ReadDouble() { }

	[Address(RVA = "0x21ABE20", Offset = "0x21AB220", Length = "0x4E")]
	[Token(Token = "0x6000FE7")]
	private string ReadElement() { }

	[Address(RVA = "0x21ABE70", Offset = "0x21AB270", Length = "0x3A")]
	[Token(Token = "0x6000FF9")]
	private int ReadInt32() { }

	[Address(RVA = "0x21ABEB0", Offset = "0x21AB2B0", Length = "0x3A")]
	[Token(Token = "0x6000FFA")]
	private long ReadInt64() { }

	[Address(RVA = "0x21ABEF0", Offset = "0x21AB2F0", Length = "0x8A")]
	[Token(Token = "0x6000FF3")]
	private string ReadLengthString() { }

	[Address(RVA = "0x21ABF80", Offset = "0x21AB380", Length = "0x30C")]
	[Token(Token = "0x6000FEC")]
	private bool ReadNormal() { }

	[Address(RVA = "0x21AC2C0", Offset = "0x21AB6C0", Length = "0x2D1")]
	[Token(Token = "0x6000FEB")]
	private bool ReadReference() { }

	[Address(RVA = "0x21AC5A0", Offset = "0x21AB9A0", Length = "0x2E9")]
	[Token(Token = "0x6000FF2")]
	private string ReadString() { }

	[Address(RVA = "0x21AC890", Offset = "0x21ABC90", Length = "0x668")]
	[Token(Token = "0x6000FF0")]
	private void ReadType(BsonType type) { }

	[Address(RVA = "0x21ACF40", Offset = "0x21AC340", Length = "0x39")]
	[Token(Token = "0x6000FFB")]
	private BsonType ReadType() { }

	[Address(RVA = "0x21AD620", Offset = "0x21ACA20", Length = "0x7")]
	[Token(Token = "0x6000FE2")]
	public void set_DateTimeKindHandling(DateTimeKind value) { }

	[Address(RVA = "0x21AD630", Offset = "0x21ACA30", Length = "0x7")]
	[Token(Token = "0x6000FDE")]
	public void set_JsonNet35BinaryCompatibility(bool value) { }

	[Address(RVA = "0x21AD640", Offset = "0x21ACA40", Length = "0x7")]
	[Token(Token = "0x6000FE0")]
	public void set_ReadRootValueAsArray(bool value) { }

}

