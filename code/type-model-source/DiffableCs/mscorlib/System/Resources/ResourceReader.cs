namespace System.Resources;

[ComVisible(True)]
[Token(Token = "0x20004C5")]
public sealed class ResourceReader : IResourceReader, IEnumerable, IDisposable
{
	[Token(Token = "0x20004C6")]
	public sealed class ResourceEnumerator : IDictionaryEnumerator, IEnumerator
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40012E2")]
		private ResourceReader _reader; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40012E3")]
		private bool _currentIsValid; //Field offset: 0x18
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x40012E4")]
		private int _currentName; //Field offset: 0x1C
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40012E5")]
		private int _dataPosition; //Field offset: 0x20

		[Token(Token = "0x1700041B")]
		public override object Current
		{
			[Address(RVA = "0x1F3A420", Offset = "0x1F39820", Length = "0x54")]
			[Token(Token = "0x60021EC")]
			 get { } //Length: 84
		}

		[Token(Token = "0x1700041C")]
		internal int DataPosition
		{
			[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
			[Token(Token = "0x60021ED")]
			internal get { } //Length: 4
		}

		[Token(Token = "0x1700041D")]
		public override DictionaryEntry Entry
		{
			[Address(RVA = "0x1F3A480", Offset = "0x1F39880", Length = "0x3F3")]
			[Token(Token = "0x60021EE")]
			 get { } //Length: 1011
		}

		[Token(Token = "0x1700041A")]
		public override object Key
		{
			[Address(RVA = "0x1F3A880", Offset = "0x1F39C80", Length = "0x154")]
			[Token(Token = "0x60021EB")]
			 get { } //Length: 340
		}

		[Token(Token = "0x1700041E")]
		public override object Value
		{
			[Address(RVA = "0x1F3A9E0", Offset = "0x1F39DE0", Length = "0x150")]
			[Token(Token = "0x60021EF")]
			 get { } //Length: 336
		}

		[Address(RVA = "0x1F3A3E0", Offset = "0x1F397E0", Length = "0x40")]
		[Token(Token = "0x60021E9")]
		internal ResourceEnumerator(ResourceReader reader) { }

		[Address(RVA = "0x1F3A420", Offset = "0x1F39820", Length = "0x54")]
		[Token(Token = "0x60021EC")]
		public override object get_Current() { }

		[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
		[Token(Token = "0x60021ED")]
		internal int get_DataPosition() { }

		[Address(RVA = "0x1F3A480", Offset = "0x1F39880", Length = "0x3F3")]
		[Token(Token = "0x60021EE")]
		public override DictionaryEntry get_Entry() { }

		[Address(RVA = "0x1F3A880", Offset = "0x1F39C80", Length = "0x154")]
		[Token(Token = "0x60021EB")]
		public override object get_Key() { }

		[Address(RVA = "0x1F3A9E0", Offset = "0x1F39DE0", Length = "0x150")]
		[Token(Token = "0x60021EF")]
		public override object get_Value() { }

		[Address(RVA = "0x1F3A2F0", Offset = "0x1F396F0", Length = "0x45")]
		[Token(Token = "0x60021EA")]
		public override bool MoveNext() { }

		[Address(RVA = "0x1F3A340", Offset = "0x1F39740", Length = "0x93")]
		[Token(Token = "0x60021F0")]
		public override void Reset() { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40012D4")]
	private BinaryReader _store; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40012D5")]
	internal Dictionary<String, ResourceLocator> _resCache; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40012D6")]
	private long _nameSectionOffset; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40012D7")]
	private long _dataSectionOffset; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40012D8")]
	private Int32[] _nameHashes; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40012D9")]
	private Int32* _nameHashesPtr; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40012DA")]
	private Int32[] _namePositions; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40012DB")]
	private Int32* _namePositionsPtr; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40012DC")]
	private RuntimeType[] _typeTable; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40012DD")]
	private Int32[] _typeNamePositions; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40012DE")]
	private BinaryFormatter _objFormatter; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40012DF")]
	private int _numResources; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40012E0")]
	private UnmanagedMemoryStream _ums; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40012E1")]
	private int _version; //Field offset: 0x78

	[Address(RVA = "0x1F3D940", Offset = "0x1F3CD40", Length = "0x7FC")]
	[Token(Token = "0x60021E2")]
	private object _LoadObjectV1(int pos) { }

	[Address(RVA = "0x1F3E140", Offset = "0x1F3D540", Length = "0xACC")]
	[Token(Token = "0x60021E4")]
	private object _LoadObjectV2(int pos, out ResourceTypeCode typeCode) { }

	[Address(RVA = "0x1F3ECA0", Offset = "0x1F3E0A0", Length = "0xACE")]
	[Token(Token = "0x60021E7")]
	private void _ReadResources() { }

	[Address(RVA = "0x1F3F770", Offset = "0x1F3EB70", Length = "0x149")]
	[Token(Token = "0x60021CF")]
	internal ResourceReader(Stream stream, Dictionary<String, ResourceLocator> resCache) { }

	[Address(RVA = "0x1F3B4E0", Offset = "0x1F3A8E0", Length = "0x754")]
	[Token(Token = "0x60021DC")]
	private string AllocateStringForNameIndex(int index, out int dataOffset) { }

	[Address(RVA = "0x1F3BC40", Offset = "0x1F3B040", Length = "0xB1")]
	[Token(Token = "0x60021D0")]
	public override void Close() { }

	[Address(RVA = "0x1F3BD00", Offset = "0x1F3B100", Length = "0x3E3")]
	[Token(Token = "0x60021DB")]
	private bool CompareStringEqualsName(string name) { }

	[Address(RVA = "0x1F3C0F0", Offset = "0x1F3B4F0", Length = "0x1AD")]
	[Token(Token = "0x60021E5")]
	private object DeserializeObject(int typeIndex) { }

	[Address(RVA = "0x1F3C360", Offset = "0x1F3B760", Length = "0x7")]
	[Token(Token = "0x60021D1")]
	public override void Dispose() { }

	[Address(RVA = "0x1F3C2A0", Offset = "0x1F3B6A0", Length = "0xB8")]
	[Token(Token = "0x60021D2")]
	private void Dispose(bool disposing) { }

	[Address(RVA = "0x1F3C370", Offset = "0x1F3B770", Length = "0x4C2")]
	[Token(Token = "0x60021DA")]
	internal int FindPosForResource(string name) { }

	[Address(RVA = "0x1F3C840", Offset = "0x1F3BC40", Length = "0x380")]
	[Token(Token = "0x60021E8")]
	private RuntimeType FindType(int typeIndex) { }

	[Address(RVA = "0x1F3CC40", Offset = "0x1F3C040", Length = "0xCB")]
	[Token(Token = "0x60021D8")]
	public override IDictionaryEnumerator GetEnumerator() { }

	[Address(RVA = "0x1F3CBD0", Offset = "0x1F3BFD0", Length = "0x6E")]
	[Token(Token = "0x60021D9")]
	internal ResourceEnumerator GetEnumeratorInternal() { }

	[Address(RVA = "0x1F3CD10", Offset = "0x1F3C110", Length = "0x65")]
	[Token(Token = "0x60021D5")]
	private int GetNameHash(int index) { }

	[Address(RVA = "0x1F3CD80", Offset = "0x1F3C180", Length = "0x130")]
	[Token(Token = "0x60021D6")]
	private int GetNamePosition(int index) { }

	[Address(RVA = "0x1F3CEB0", Offset = "0x1F3C2B0", Length = "0x29B")]
	[Token(Token = "0x60021DD")]
	private object GetValueForNameIndex(int index) { }

	[Address(RVA = "0x1F3D380", Offset = "0x1F3C780", Length = "0x59")]
	[Token(Token = "0x60021E0")]
	internal object LoadObject(int pos, out ResourceTypeCode typeCode) { }

	[Address(RVA = "0x1F3D350", Offset = "0x1F3C750", Length = "0x30")]
	[Token(Token = "0x60021DF")]
	internal object LoadObject(int pos) { }

	[Address(RVA = "0x1F3D150", Offset = "0x1F3C550", Length = "0xFB")]
	[Token(Token = "0x60021E1")]
	internal object LoadObjectV1(int pos) { }

	[Address(RVA = "0x1F3D250", Offset = "0x1F3C650", Length = "0xFB")]
	[Token(Token = "0x60021E3")]
	internal object LoadObjectV2(int pos, out ResourceTypeCode typeCode) { }

	[Address(RVA = "0x1F3D3E0", Offset = "0x1F3C7E0", Length = "0x2E4")]
	[Token(Token = "0x60021DE")]
	internal string LoadString(int pos) { }

	[Address(RVA = "0x1F3D6D0", Offset = "0x1F3CAD0", Length = "0x173")]
	[Token(Token = "0x60021E6")]
	private void ReadResources() { }

	[Address(RVA = "0x1F3D850", Offset = "0x1F3CC50", Length = "0x1F")]
	[Token(Token = "0x60021D3")]
	internal static int ReadUnalignedI4(Int32* p) { }

	[Address(RVA = "0x1F3D870", Offset = "0x1F3CC70", Length = "0xCB")]
	[Token(Token = "0x60021D4")]
	private void SkipString() { }

	[Address(RVA = "0x1F3CC40", Offset = "0x1F3C040", Length = "0xCB")]
	[Token(Token = "0x60021D7")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

