namespace KANAI.Kernel;

[Token(Token = "0x2000015")]
public class ChunkChain
{
	[Token(Token = "0x2000017")]
	internal class Chunks
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400006C")]
		private Byte[] bytes; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400006D")]
		private int head; //Field offset: 0x18
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x400006E")]
		private int limit; //Field offset: 0x1C

		[Address(RVA = "0x1DE6C60", Offset = "0x1DE6060", Length = "0x4A")]
		[Token(Token = "0x60000B5")]
		public Chunks(Byte[] b) { }

		[Address(RVA = "0x1DE6400", Offset = "0x1DE5800", Length = "0xF")]
		[Token(Token = "0x60000B8")]
		private int GetChunkSize() { }

		[Address(RVA = "0x1DE6410", Offset = "0x1DE5810", Length = "0x2F")]
		[Token(Token = "0x60000B9")]
		public TYPE GetChunkType() { }

		[Address(RVA = "0x1DE6440", Offset = "0x1DE5840", Length = "0x32")]
		[Token(Token = "0x60000BC")]
		private int GetDataOffset(int idx = 0) { }

		[Address(RVA = "0x1DE6480", Offset = "0x1DE5880", Length = "0x4D")]
		[Token(Token = "0x60000C1")]
		public float GetFloat() { }

		[Address(RVA = "0x1DE6AF0", Offset = "0x1DE5EF0", Length = "0x126")]
		[Token(Token = "0x60000C2")]
		public Single[] Getfloats() { }

		[Address(RVA = "0x1DE6640", Offset = "0x1DE5A40", Length = "0x45")]
		[Token(Token = "0x60000BD")]
		public int GetInt() { }

		[Address(RVA = "0x1DE64D0", Offset = "0x1DE58D0", Length = "0x45")]
		[Token(Token = "0x60000BF")]
		public long GetInt64() { }

		[Address(RVA = "0x1DE6520", Offset = "0x1DE5920", Length = "0x11E")]
		[Token(Token = "0x60000C0")]
		public Int64[] GetInt64s() { }

		[Address(RVA = "0x1DE6690", Offset = "0x1DE5A90", Length = "0x122")]
		[Token(Token = "0x60000BE")]
		public Int32[] GetInts() { }

		[Address(RVA = "0x1DE67F0", Offset = "0x1DE5BF0", Length = "0x68")]
		[Token(Token = "0x60000BB")]
		public string GetName() { }

		[Address(RVA = "0x1DE67C0", Offset = "0x1DE5BC0", Length = "0x2F")]
		[Token(Token = "0x60000BA")]
		public int GetNameSize() { }

		[Address(RVA = "0x1DE6860", Offset = "0x1DE5C60", Length = "0xB3")]
		[Token(Token = "0x60000C3")]
		public string GetString() { }

		[Address(RVA = "0x1DE6920", Offset = "0x1DE5D20", Length = "0x1C6")]
		[Token(Token = "0x60000C4")]
		public String[] GetStrings() { }

		[Address(RVA = "0xF4AFB0", Offset = "0xF4A3B0", Length = "0x4")]
		[Token(Token = "0x60000B6")]
		public void SetHead(int n) { }

		[Address(RVA = "0x1DE6C20", Offset = "0x1DE6020", Length = "0x35")]
		[Token(Token = "0x60000B7")]
		public bool ToNext() { }

	}

	[Token(Token = "0x2000016")]
	internal enum TYPE : byte
	{
		NONE = 0,
		Int = 1,
		Ints = 2,
		Int64 = 3,
		Int64s = 4,
		Short = 5,
		Shorts = 6,
		Byte = 7,
		Bytes = 8,
		Float = 9,
		Floats = 10,
		Double = 11,
		Doubles = 12,
		Bool = 13,
		Bools = 14,
		String = 15,
		Strings = 16,
		Enum = 17,
		Enums = 18,
	}


	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x60000B4")]
	public ChunkChain() { }

	[Address(RVA = "0x1DE4FE0", Offset = "0x1DE43E0", Length = "0x12")]
	[Token(Token = "0x60000A9")]
	private static ushort ConvineTypeSize(TYPE t, int s) { }

	[Address(RVA = "0x1DE5000", Offset = "0x1DE4400", Length = "0x8")]
	[Token(Token = "0x600009E")]
	private static short Get2Byte(Byte[] bytes, int offset) { }

	[Address(RVA = "0x1DE5010", Offset = "0x1DE4410", Length = "0x8")]
	[Token(Token = "0x600009C")]
	private static bool GetBool(Byte[] bytes, int offset) { }

	[Address(RVA = "0x1DE5020", Offset = "0x1DE4420", Length = "0x8")]
	[Token(Token = "0x60000B3")]
	public static int GetSize(Byte[] bytes, int offset = 0) { }

	[Address(RVA = "0x1DE5820", Offset = "0x1DE4C20", Length = "0x1F9")]
	[Token(Token = "0x60000AC")]
	public static Byte[] MakeChunk(string name, Int32[] datas) { }

	[Address(RVA = "0x1DE5030", Offset = "0x1DE4430", Length = "0x17D")]
	[Token(Token = "0x60000AD")]
	public static Byte[] MakeChunk(string name, long data) { }

	[Address(RVA = "0x1DE5DD0", Offset = "0x1DE51D0", Length = "0x1FA")]
	[Token(Token = "0x60000AE")]
	public static Byte[] MakeChunk(string name, Int64[] datas) { }

	[Address(RVA = "0x1DE5690", Offset = "0x1DE4A90", Length = "0x183")]
	[Token(Token = "0x60000AF")]
	public static Byte[] MakeChunk(string name, float data) { }

	[Address(RVA = "0x1DE5BD0", Offset = "0x1DE4FD0", Length = "0x1FB")]
	[Token(Token = "0x60000B0")]
	public static Byte[] MakeChunk(string name, Single[] datas) { }

	[Address(RVA = "0x1DE5A20", Offset = "0x1DE4E20", Length = "0x1AF")]
	[Token(Token = "0x60000B1")]
	public static Byte[] MakeChunk(string name, string data) { }

	[Address(RVA = "0x1DE5330", Offset = "0x1DE4730", Length = "0x350")]
	[Token(Token = "0x60000B2")]
	public static Byte[] MakeChunk(string name, String[] datas) { }

	[Address(RVA = "0x1DE51B0", Offset = "0x1DE45B0", Length = "0x17C")]
	[Token(Token = "0x60000AB")]
	public static Byte[] MakeChunk(string name, int data) { }

	[Address(RVA = "0x1DE5FD0", Offset = "0x1DE53D0", Length = "0x8")]
	[Token(Token = "0x60000A0")]
	private static byte Separate2ByteHi(short ts) { }

	[Address(RVA = "0x732D80", Offset = "0x732180", Length = "0x4")]
	[Token(Token = "0x600009F")]
	private static byte Separate2ByteLow(short ts) { }

	[Address(RVA = "0x1DE5FE0", Offset = "0x1DE53E0", Length = "0xD")]
	[Token(Token = "0x60000AA")]
	private static void SepareteTypeSize(ushort ts, out TYPE t, out byte s) { }

	[Address(RVA = "0x1DE5FF0", Offset = "0x1DE53F0", Length = "0x75")]
	[Token(Token = "0x600009D")]
	private static int Set2Byte(Byte[] dst, int offset, byte l, byte h) { }

	[Address(RVA = "0x1DE6070", Offset = "0x1DE5470", Length = "0x63")]
	[Token(Token = "0x600009B")]
	private static int SetBool(Byte[] dst, int offset, bool data) { }

	[Address(RVA = "0x1DE60E0", Offset = "0x1DE54E0", Length = "0x2B")]
	[Token(Token = "0x60000A1")]
	private static int SetByte(Byte[] dst, int offset, byte b) { }

	[Address(RVA = "0x1DE6110", Offset = "0x1DE5510", Length = "0x3D")]
	[Token(Token = "0x60000A8")]
	private static int SetBytes(Byte[] dst, int offset, Byte[] bytes) { }

	[Address(RVA = "0x1DE6150", Offset = "0x1DE5550", Length = "0x60")]
	[Token(Token = "0x60000A6")]
	private static int SetDouble(Byte[] dst, int offset, double data) { }

	[Address(RVA = "0x1DE61C0", Offset = "0x1DE55C0", Length = "0x60")]
	[Token(Token = "0x60000A5")]
	private static int SetFloat(Byte[] dst, int offset, float data) { }

	[Address(RVA = "0x1DE62A0", Offset = "0x1DE56A0", Length = "0x60")]
	[Token(Token = "0x60000A3")]
	private static int SetInt(Byte[] dst, int offset, int data) { }

	[Address(RVA = "0x1DE6230", Offset = "0x1DE5630", Length = "0x60")]
	[Token(Token = "0x60000A4")]
	private static int SetInt64(Byte[] dst, int offset, long data) { }

	[Address(RVA = "0x1DE6310", Offset = "0x1DE5710", Length = "0x61")]
	[Token(Token = "0x60000A2")]
	private static int SetShort(Byte[] dst, int offset, short data) { }

	[Address(RVA = "0x1DE6380", Offset = "0x1DE5780", Length = "0x7D")]
	[Token(Token = "0x60000A7")]
	private static int SetString(Byte[] dst, int offset, string data) { }

}

