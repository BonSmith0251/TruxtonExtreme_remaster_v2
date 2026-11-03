namespace TXEKernel.Comic;

[CreateAssetMenu(menuName = "Comic/CreateDatabase", fileName = "ComicEpisodes", order = 1)]
[Token(Token = "0x2000142")]
public class ComicDataBaseRecords : ScriptableObject
{
	[CompilerGenerated]
	[Token(Token = "0x2000144")]
	private sealed class <>c__DisplayClass2_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000928")]
		public string episode; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000929")]
		public string locale; //Field offset: 0x18

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60008B2")]
		public <>c__DisplayClass2_0() { }

		[Address(RVA = "0x1D73DE0", Offset = "0x1D731E0", Length = "0x25")]
		[Token(Token = "0x60008B3")]
		internal bool <IsAvailableLocale>b__0(Record x) { }

		[Address(RVA = "0x272B640", Offset = "0x272AA40", Length = "0x12")]
		[Token(Token = "0x60008B4")]
		internal bool <IsAvailableLocale>b__1(string x) { }

	}

	[Token(Token = "0x2000143")]
	internal class Record
	{
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		[Token(Token = "0x4000925")]
		public string _episode; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Token(Token = "0x4000926")]
		public List<String> _pages; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Token(Token = "0x4000927")]
		public List<String> _locales; //Field offset: 0x20

		[Address(RVA = "0x1D39B10", Offset = "0x1D38F10", Length = "0x36")]
		[Token(Token = "0x60008B1")]
		public Record() { }

	}

	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x4000924")]
	public List<Record> _list; //Field offset: 0x18

	[Address(RVA = "0x2720390", Offset = "0x271F790", Length = "0x77")]
	[Token(Token = "0x60008B0")]
	public ComicDataBaseRecords() { }

	[Address(RVA = "0x2720210", Offset = "0x271F610", Length = "0x17B")]
	[Token(Token = "0x60008AF")]
	public bool IsAvailableLocale(string episode, string locale) { }

}

