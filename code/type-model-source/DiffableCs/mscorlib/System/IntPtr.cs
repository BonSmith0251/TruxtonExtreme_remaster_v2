namespace System;

[ComVisible(True)]
[IsReadOnly]
[Token(Token = "0x20001B8")]
public struct IntPtr : ISerializable, IEquatable<IntPtr>
{
	[Token(Token = "0x4000707")]
	public static readonly IntPtr Zero; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000706")]
	private readonly Void* m_value; //Field offset: 0x0

	[Token(Token = "0x1700015F")]
	public static int Size
	{
		[Address(RVA = "0x9DCBA0", Offset = "0x9DBFA0", Length = "0x6")]
		[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
		[Token(Token = "0x6000FB6")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x2081A60", Offset = "0x2080E60", Length = "0x7")]
	[ReliabilityContract(Consistency::MayCorruptInstance (2), Cer::MayFail (1))]
	[Token(Token = "0x6000FB2")]
	public IntPtr(int value) { }

	[Address(RVA = "0x604A00", Offset = "0x603E00", Length = "0x4")]
	[ReliabilityContract(Consistency::MayCorruptInstance (2), Cer::MayFail (1))]
	[Token(Token = "0x6000FB3")]
	public IntPtr(long value) { }

	[Address(RVA = "0x604A00", Offset = "0x603E00", Length = "0x4")]
	[CLSCompliant(False)]
	[ReliabilityContract(Consistency::MayCorruptInstance (2), Cer::MayFail (1))]
	[Token(Token = "0x6000FB4")]
	public IntPtr(Void* value) { }

	[Address(RVA = "0x2081A70", Offset = "0x2080E70", Length = "0x56")]
	[Token(Token = "0x6000FB5")]
	private IntPtr(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x9D7630", Offset = "0x9D6A30", Length = "0x7")]
	[ReliabilityContract(Consistency::MayCorruptInstance (2), Cer::MayFail (1))]
	[Token(Token = "0x6000FC7")]
	public static IntPtr Add(IntPtr pointer, int offset) { }

	[Address(RVA = "0x2081900", Offset = "0x2080D00", Length = "0x57")]
	[Token(Token = "0x6000FB8")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x9DCBA0", Offset = "0x9DBFA0", Length = "0x6")]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x6000FB6")]
	public static int get_Size() { }

	[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
	[Token(Token = "0x6000FB9")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1F12030", Offset = "0x1F11430", Length = "0x8")]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x6000FCA")]
	internal bool IsNull() { }

	[Address(RVA = "0x9D7630", Offset = "0x9D6A30", Length = "0x7")]
	[ReliabilityContract(Consistency::MayCorruptInstance (2), Cer::MayFail (1))]
	[Token(Token = "0x6000FC8")]
	public static IntPtr op_Addition(IntPtr pointer, int offset) { }

	[Address(RVA = "0x604B30", Offset = "0x603F30", Length = "0x7")]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x6000FBF")]
	public static bool op_Equality(IntPtr value1, IntPtr value2) { }

	[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
	[CLSCompliant(False)]
	[ReliabilityContract(Consistency::MayCorruptInstance (2), Cer::MayFail (1))]
	[Token(Token = "0x6000FC3")]
	public static IntPtr op_Explicit(Void* value) { }

	[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
	[CLSCompliant(False)]
	[Token(Token = "0x6000FC6")]
	public static Void* op_Explicit(IntPtr value) { }

	[Address(RVA = "0x2081AD0", Offset = "0x2080ED0", Length = "0x6")]
	[Token(Token = "0x6000FC5")]
	public static long op_Explicit(IntPtr value) { }

	[Address(RVA = "0x1F97C20", Offset = "0x1F97020", Length = "0x4")]
	[ReliabilityContract(Consistency::MayCorruptInstance (2), Cer::MayFail (1))]
	[Token(Token = "0x6000FC1")]
	public static IntPtr op_Explicit(int value) { }

	[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
	[ReliabilityContract(Consistency::MayCorruptInstance (2), Cer::MayFail (1))]
	[Token(Token = "0x6000FC2")]
	public static IntPtr op_Explicit(long value) { }

	[Address(RVA = "0x604260", Offset = "0x603660", Length = "0x3")]
	[Token(Token = "0x6000FC4")]
	public static int op_Explicit(IntPtr value) { }

	[Address(RVA = "0x604B50", Offset = "0x603F50", Length = "0x7")]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x6000FC0")]
	public static bool op_Inequality(IntPtr value1, IntPtr value2) { }

	[Address(RVA = "0x2081AE0", Offset = "0x2080EE0", Length = "0xA")]
	[ReliabilityContract(Consistency::MayCorruptInstance (2), Cer::MayFail (1))]
	[Token(Token = "0x6000FC9")]
	public static IntPtr op_Subtraction(IntPtr pointer, int offset) { }

	[Address(RVA = "0x604730", Offset = "0x603B30", Length = "0x7")]
	[Token(Token = "0x6000FCB")]
	private override bool System.IEquatable<System.IntPtr>.Equals(IntPtr other) { }

	[Address(RVA = "0x2081960", Offset = "0x2080D60", Length = "0x98")]
	[Token(Token = "0x6000FB7")]
	private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x6000FBA")]
	public int ToInt32() { }

	[Address(RVA = "0x88F140", Offset = "0x88E540", Length = "0x6")]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x6000FBB")]
	public long ToInt64() { }

	[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
	[CLSCompliant(False)]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x6000FBC")]
	public Void* ToPointer() { }

	[Address(RVA = "0x2081A30", Offset = "0x2080E30", Length = "0x23")]
	[Token(Token = "0x6000FBD")]
	public virtual string ToString() { }

	[Address(RVA = "0x2081A00", Offset = "0x2080E00", Length = "0x21")]
	[Token(Token = "0x6000FBE")]
	public string ToString(string format) { }

}

