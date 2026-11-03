namespace UnityEngine;

[NativeHeader("Runtime/Scripting/TextAsset.h")]
[Token(Token = "0x20001C5")]
public class TextAsset : object
{
	[Token(Token = "0x20001C6")]
	public enum CreateOptions : int
	{
		None = 0,
		CreateNativeObject = 1,
	}

	[Token(Token = "0x20001C7")]
	private static class EncodingUtility
	{
		[Token(Token = "0x4000693")]
		internal static readonly KeyValuePair<Byte[], Encoding>[] encodingLookup; //Field offset: 0x0
		[Token(Token = "0x4000694")]
		internal static readonly Encoding targetEncoding; //Field offset: 0x8

		[Address(RVA = "0x305E670", Offset = "0x305DA70", Length = "0x466")]
		[Token(Token = "0x6001422")]
		private static EncodingUtility() { }

	}


	[Token(Token = "0x170002F6")]
	public Byte[] bytes
	{
		[Address(RVA = "0x30730C0", Offset = "0x30724C0", Length = "0x76")]
		[Token(Token = "0x6001414")]
		 get { } //Length: 118
	}

	[Token(Token = "0x170002F7")]
	public string text
	{
		[Address(RVA = "0x3072EF0", Offset = "0x30722F0", Length = "0xA3")]
		[Token(Token = "0x6001418")]
		 get { } //Length: 163
	}

	[Address(RVA = "0x3072FA0", Offset = "0x30723A0", Length = "0x57")]
	[Token(Token = "0x600141A")]
	public TextAsset() { }

	[Address(RVA = "0x3073000", Offset = "0x3072400", Length = "0x75")]
	[Token(Token = "0x600141B")]
	internal TextAsset(CreateOptions options, string text) { }

	[Address(RVA = "0x3072930", Offset = "0x3071D30", Length = "0x252")]
	[Token(Token = "0x600141D")]
	internal static string DecodeString(Byte[] bytes) { }

	[Address(RVA = "0x30730C0", Offset = "0x30724C0", Length = "0x76")]
	[Token(Token = "0x6001414")]
	public Byte[] get_bytes() { }

	[Address(RVA = "0x3073080", Offset = "0x3072480", Length = "0x33")]
	[Token(Token = "0x600141E")]
	private static Byte[] get_bytes_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3072EF0", Offset = "0x30722F0", Length = "0xA3")]
	[Token(Token = "0x6001418")]
	public string get_text() { }

	[Address(RVA = "0x942FB0", Offset = "0x9423B0", Length = "0x96")]
	[Token(Token = "0x600141C")]
	public NativeArray<T> GetData() { }

	[Address(RVA = "0x3072BD0", Offset = "0x3071FD0", Length = "0x76")]
	[Token(Token = "0x6001416")]
	private IntPtr GetDataPtr() { }

	[Address(RVA = "0x3072B90", Offset = "0x3071F90", Length = "0x33")]
	[Token(Token = "0x6001420")]
	private static IntPtr GetDataPtr_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3072C90", Offset = "0x3072090", Length = "0x76")]
	[Token(Token = "0x6001417")]
	private long GetDataSize() { }

	[Address(RVA = "0x3072C50", Offset = "0x3072050", Length = "0x33")]
	[Token(Token = "0x6001421")]
	private static long GetDataSize_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3072D60", Offset = "0x3072160", Length = "0x187")]
	[Token(Token = "0x6001415")]
	private static void Internal_CreateInstance(TextAsset self, string text) { }

	[Address(RVA = "0x3072D10", Offset = "0x3072110", Length = "0x42")]
	[Token(Token = "0x600141F")]
	private static void Internal_CreateInstance_Injected(TextAsset self, ref ManagedSpanWrapper text) { }

	[Address(RVA = "0x3072EF0", Offset = "0x30722F0", Length = "0xA3")]
	[Token(Token = "0x6001419")]
	public virtual string ToString() { }

}

