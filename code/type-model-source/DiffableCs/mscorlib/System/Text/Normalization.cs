namespace System.Text;

[Token(Token = "0x20002C7")]
internal class Normalization
{
	[Token(Token = "0x4000C01")]
	private static Byte* props; //Field offset: 0x0
	[Token(Token = "0x4000C02")]
	private static Int32* mappedChars; //Field offset: 0x8
	[Token(Token = "0x4000C03")]
	private static Int16* charMapIndex; //Field offset: 0x10
	[Token(Token = "0x4000C04")]
	private static Int16* helperIndex; //Field offset: 0x18
	[Token(Token = "0x4000C05")]
	private static UInt16* mapIdxToComposite; //Field offset: 0x20
	[Token(Token = "0x4000C06")]
	private static Byte* combiningClass; //Field offset: 0x28
	[Token(Token = "0x4000C07")]
	private static object forLock; //Field offset: 0x30
	[Token(Token = "0x4000C08")]
	public static readonly bool isReady; //Field offset: 0x38

	[Address(RVA = "0x1EA8090", Offset = "0x1EA7490", Length = "0x252")]
	[Token(Token = "0x6001773")]
	private static Normalization() { }

	[Address(RVA = "0x1EA5CB0", Offset = "0x1EA50B0", Length = "0x8E")]
	[Token(Token = "0x600175E")]
	private static int CharMapIdx(int cp) { }

	[Address(RVA = "0x1EA6070", Offset = "0x1EA5470", Length = "0x22A")]
	[Token(Token = "0x6001764")]
	private static void Combine(StringBuilder sb, int i, int checkType) { }

	[Address(RVA = "0x1EA5F40", Offset = "0x1EA5340", Length = "0x127")]
	[Token(Token = "0x6001763")]
	private static StringBuilder Combine(string source, int start, int checkType) { }

	[Address(RVA = "0x1EA5D40", Offset = "0x1EA5140", Length = "0x1FC")]
	[Token(Token = "0x6001765")]
	private static int CombineHangul(StringBuilder sb, string s, int current) { }

	[Address(RVA = "0x1EA62A0", Offset = "0x1EA56A0", Length = "0x1EA")]
	[Token(Token = "0x6001762")]
	private static string Compose(string source, int checkType) { }

	[Address(RVA = "0x1EA66A0", Offset = "0x1EA5AA0", Length = "0x587")]
	[Token(Token = "0x6001769")]
	private static string Decompose(string source, int checkType) { }

	[Address(RVA = "0x1EA6C30", Offset = "0x1EA6030", Length = "0x2EF")]
	[Token(Token = "0x600176A")]
	private static void Decompose(string source, ref StringBuilder sb, int checkType) { }

	[Address(RVA = "0x1EA6490", Offset = "0x1EA5890", Length = "0x200")]
	[Token(Token = "0x600176C")]
	private static void DecomposeChar(ref StringBuilder sb, ref Int32[] buf, string s, int i, int checkType, ref int start) { }

	[Address(RVA = "0x1EA6F20", Offset = "0x1EA6320", Length = "0x42")]
	[Token(Token = "0x6001766")]
	private static int Fetch(StringBuilder sb, string s, int i) { }

	[Address(RVA = "0x1EA7090", Offset = "0x1EA6490", Length = "0x33D")]
	[Token(Token = "0x600176F")]
	private static int GetCanonical(int c, Int32[] buf, int bufIdx, int checkType) { }

	[Address(RVA = "0x1EA6F70", Offset = "0x1EA6370", Length = "0x11F")]
	[Token(Token = "0x600176E")]
	private static int GetCanonicalHangul(int s, Int32[] buf, int bufIdx) { }

	[Address(RVA = "0x1EA73D0", Offset = "0x1EA67D0", Length = "0xAE")]
	[Token(Token = "0x600175F")]
	private static byte GetCombiningClass(int c) { }

	[Address(RVA = "0x1EA7480", Offset = "0x1EA6880", Length = "0xAE")]
	[Token(Token = "0x6001760")]
	private static int GetPrimaryCompositeFromMapIndex(int src) { }

	[Address(RVA = "0x1EA7530", Offset = "0x1EA6930", Length = "0xAE")]
	[Token(Token = "0x6001761")]
	private static int GetPrimaryCompositeHelperIndex(int cp) { }

	[Address(RVA = "0x1EA82F0", Offset = "0x1EA76F0", Length = "0x5")]
	[Token(Token = "0x6001772")]
	private static void load_normalization_resource(out IntPtr props, out IntPtr mappedChars, out IntPtr charMapIndex, out IntPtr helperIndex, out IntPtr mapIdxToComposite, out IntPtr combiningClass) { }

	[Address(RVA = "0x1EA76B0", Offset = "0x1EA6AB0", Length = "0x98")]
	[Token(Token = "0x6001771")]
	public static string Normalize(string source, int type) { }

	[Address(RVA = "0x1EA75E0", Offset = "0x1EA69E0", Length = "0xC6")]
	[Token(Token = "0x6001770")]
	public static string Normalize(string source, NormalizationForm normalizationForm) { }

	[Address(RVA = "0x1EA7750", Offset = "0x1EA6B50", Length = "0x8D")]
	[Token(Token = "0x600175D")]
	private static uint PropValue(int cp) { }

	[Address(RVA = "0x1EA77E0", Offset = "0x1EA6BE0", Length = "0x136")]
	[Token(Token = "0x600176D")]
	public static NormalizationCheck QuickCheck(char c, int type) { }

	[Address(RVA = "0x1EA7920", Offset = "0x1EA6D20", Length = "0x283")]
	[Token(Token = "0x600176B")]
	private static void ReorderCanonical(string src, ref StringBuilder sb, int start) { }

	[Address(RVA = "0x1EA7F20", Offset = "0x1EA7320", Length = "0x169")]
	[Token(Token = "0x6001768")]
	private static int TryCompose(int i, int starter, int candidate) { }

	[Address(RVA = "0x1EA7BB0", Offset = "0x1EA6FB0", Length = "0x367")]
	[Token(Token = "0x6001767")]
	private static int TryComposeWithPreviousStarter(StringBuilder sb, string s, int current) { }

}

