namespace KANAI.Kernel;

[Token(Token = "0x200002C")]
public class PrefsDictionary
{
	[Token(Token = "0x2000030")]
	internal class CryptData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000CB")]
		public Byte[] CryptKey; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40000CC")]
		public BitArray MaskData; //Field offset: 0x18

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000187")]
		public CryptData() { }

	}

	[Token(Token = "0x200002F")]
	internal class DataPrefs
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000C9")]
		public int version; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40000CA")]
		public ListPrefs[] prefslist; //Field offset: 0x18

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000186")]
		public DataPrefs() { }

	}

	[Token(Token = "0x200002E")]
	internal class ListPrefs
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000C6")]
		public string key; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40000C7")]
		public VTYPE type; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40000C8")]
		public string basedata; //Field offset: 0x20

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000185")]
		public ListPrefs() { }

	}

	[Token(Token = "0x200002D")]
	internal enum VTYPE : int
	{
		INT = 0,
		INT64 = 1,
		FLOAT = 2,
		BOOL = 3,
		STRING = 4,
		ENUM = 5,
	}

	[Token(Token = "0x40000BB")]
	private static BitArray MaskData; //Field offset: 0x0
	[Token(Token = "0x40000BC")]
	private static CryptData samplecryptdata; //Field offset: 0x8
	[Token(Token = "0x40000BD")]
	[TupleElementNames(new IL2CPP_TYPE_STRING[] {"Type", "Data"})]
	private static Dictionary<String, ValueTuple`2<Int32, String>> _prefs; //Field offset: 0x10
	[Token(Token = "0x40000BE")]
	private static List<ListPrefs> _prefslist; //Field offset: 0x18

	[Token(Token = "0x17000028")]
	private static Byte[] CryptKey
	{
		[Address(RVA = "0x1DEFF80", Offset = "0x1DEF380", Length = "0x5D")]
		[Token(Token = "0x6000182")]
		private get { } //Length: 93
	}

	[Token(Token = "0x17000027")]
	public static bool IsInitialized
	{
		[Address(RVA = "0x1DEFFE0", Offset = "0x1DEF3E0", Length = "0x53")]
		[Token(Token = "0x6000181")]
		 get { } //Length: 83
	}

	[Address(RVA = "0x1DEFD20", Offset = "0x1DEF120", Length = "0x25D")]
	[Token(Token = "0x6000184")]
	private static PrefsDictionary() { }

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000183")]
	public PrefsDictionary() { }

	[Address(RVA = "0x1DEDBC0", Offset = "0x1DECFC0", Length = "0x676")]
	[Token(Token = "0x6000179")]
	public static Dictionary<String, ValueTuple`2<Int32, String>> BytesToDictionary(Byte[] data, CryptData crpt) { }

	[Address(RVA = "0x1DEE240", Offset = "0x1DED640", Length = "0x70")]
	[Token(Token = "0x6000167")]
	public static void Clear() { }

	[Address(RVA = "0x1DEE2B0", Offset = "0x1DED6B0", Length = "0xA2")]
	[Token(Token = "0x6000168")]
	public static bool DeleteKey(string key) { }

	[Address(RVA = "0x1DEE360", Offset = "0x1DED760", Length = "0x357")]
	[Token(Token = "0x600017A")]
	public static ListPrefs[] DictionaryToArray() { }

	[Address(RVA = "0x1DEE6C0", Offset = "0x1DEDAC0", Length = "0x581")]
	[Token(Token = "0x6000178")]
	public static Byte[] DictionaryToBytes(Dictionary<String, ValueTuple`2<Int32, String>> dict, CryptData crpt) { }

	[Address(RVA = "0x8B3340", Offset = "0x8B2740", Length = "0x13B")]
	[Token(Token = "0x6000174")]
	public static T Get(string key) { }

	[Address(RVA = "0x1DEFF80", Offset = "0x1DEF380", Length = "0x5D")]
	[Token(Token = "0x6000182")]
	private static Byte[] get_CryptKey() { }

	[Address(RVA = "0x1DEFFE0", Offset = "0x1DEF3E0", Length = "0x53")]
	[Token(Token = "0x6000181")]
	public static bool get_IsInitialized() { }

	[Address(RVA = "0x1DEEC50", Offset = "0x1DEE050", Length = "0x4F")]
	[Token(Token = "0x600016A")]
	public static Dictionary<String, ValueTuple`2<Int32, String>> GetDict() { }

	[Address(RVA = "0x1DEECA0", Offset = "0x1DEE0A0", Length = "0xD6")]
	[Token(Token = "0x6000170")]
	public static float GetFloat(string key) { }

	[Address(RVA = "0x1DEEE70", Offset = "0x1DEE270", Length = "0xDD")]
	[Token(Token = "0x600016E")]
	public static int GetInt(string key) { }

	[Address(RVA = "0x1DE5020", Offset = "0x1DE4420", Length = "0x8")]
	[Token(Token = "0x6000177")]
	private static int GetInt(Byte[] bytes, int offset) { }

	[Address(RVA = "0x1DEED80", Offset = "0x1DEE180", Length = "0xE1")]
	[Token(Token = "0x6000172")]
	public static long GetInt64(string key) { }

	[Address(RVA = "0x1DEEF50", Offset = "0x1DEE350", Length = "0xBE")]
	[Token(Token = "0x600016C")]
	public static string GetString(string key) { }

	[Address(RVA = "0x1DEF010", Offset = "0x1DEE410", Length = "0x7C")]
	[Token(Token = "0x600016B")]
	public static bool HasKey(string key) { }

	[Address(RVA = "0x1DEF090", Offset = "0x1DEE490", Length = "0xE8")]
	[Token(Token = "0x6000165")]
	public static void Initialize() { }

	[Address(RVA = "0x1DEF180", Offset = "0x1DEE580", Length = "0x12A")]
	[Token(Token = "0x600017B")]
	public static Dictionary<String, ValueTuple`2<Int32, String>> ListToDictionary(ListPrefs[] list) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000169")]
	public static void Save() { }

	[Address(RVA = "0x8B3480", Offset = "0x8B2880", Length = "0x107")]
	[Token(Token = "0x6000175")]
	public static void Set(string key, T value) { }

	[Address(RVA = "0x1DEF2B0", Offset = "0x1DEE6B0", Length = "0x6E")]
	[Token(Token = "0x600017C")]
	public static void SetDictionary(Dictionary<String, ValueTuple`2<Int32, String>> dict) { }

	[Address(RVA = "0x1DEF320", Offset = "0x1DEE720", Length = "0x75")]
	[Token(Token = "0x600017D")]
	public static void SetDictionary(ListPrefs[] list) { }

	[Address(RVA = "0x1DEF3A0", Offset = "0x1DEE7A0", Length = "0x18A")]
	[Token(Token = "0x6000171")]
	public static void SetFloat(string key, float value) { }

	[Address(RVA = "0x1DEF6C0", Offset = "0x1DEEAC0", Length = "0x17E")]
	[Token(Token = "0x600016F")]
	public static void SetInt(string key, int value) { }

	[Address(RVA = "0x1DE62A0", Offset = "0x1DE56A0", Length = "0x60")]
	[Token(Token = "0x6000176")]
	private static int SetInt(Byte[] dst, int offset, int data) { }

	[Address(RVA = "0x1DEF530", Offset = "0x1DEE930", Length = "0x189")]
	[Token(Token = "0x6000173")]
	public static void SetInt64(string key, long value) { }

	[Address(RVA = "0x1DEF840", Offset = "0x1DEEC40", Length = "0x17E")]
	[Token(Token = "0x600016D")]
	public static void SetString(string key, string value) { }

	[Address(RVA = "0x1DEF9C0", Offset = "0x1DEEDC0", Length = "0x6F")]
	[Token(Token = "0x6000166")]
	public static void Terminate() { }

	[Address(RVA = "0x1DEFA30", Offset = "0x1DEEE30", Length = "0x1C6")]
	[Token(Token = "0x6000180")]
	public static void TestArray() { }

	[Address(RVA = "0x1DEFC00", Offset = "0x1DEF000", Length = "0x72")]
	[Token(Token = "0x600017F")]
	public static void ToDictionary(string json) { }

	[Address(RVA = "0x1DEFC80", Offset = "0x1DEF080", Length = "0x93")]
	[Token(Token = "0x600017E")]
	public static string ToJson() { }

}

