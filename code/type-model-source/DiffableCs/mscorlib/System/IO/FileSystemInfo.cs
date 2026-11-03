namespace System.IO;

[Token(Token = "0x2000663")]
public abstract class FileSystemInfo : MarshalByRefObject, ISerializable
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400199B")]
	private WIN32_FILE_ATTRIBUTE_DATA _data; //Field offset: 0x18
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x400199C")]
	private int _dataInitialized; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400199D")]
	protected string FullPath; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400199E")]
	protected string OriginalPath; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400199F")]
	internal string _name; //Field offset: 0x50

	[Token(Token = "0x17000778")]
	public FileAttributes Attributes
	{
		[Address(RVA = "0x1FF6AA0", Offset = "0x1FF5EA0", Length = "0x6D")]
		[Token(Token = "0x6002FA6")]
		 get { } //Length: 109
	}

	[Token(Token = "0x1700077E")]
	public override bool Exists
	{
		[Address(RVA = "0x1FF6B90", Offset = "0x1FF5F90", Length = "0x81")]
		[Token(Token = "0x6002FB0")]
		 get { } //Length: 129
	}

	[Token(Token = "0x17000779")]
	internal bool ExistsCore
	{
		[Address(RVA = "0x1FF6B10", Offset = "0x1FF5F10", Length = "0x7E")]
		[Token(Token = "0x6002FA7")]
		internal get { } //Length: 126
	}

	[Token(Token = "0x1700077C")]
	public override string FullName
	{
		[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
		[Token(Token = "0x6002FAE")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700077A")]
	internal long LengthCore
	{
		[Address(RVA = "0x1FF6C20", Offset = "0x1FF6020", Length = "0x77")]
		[Token(Token = "0x6002FA8")]
		internal get { } //Length: 119
	}

	[Token(Token = "0x1700077D")]
	public override string Name
	{
		[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
		[Token(Token = "0x6002FAF")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700077B")]
	internal string NormalizedPath
	{
		[Address(RVA = "0x1FF6CA0", Offset = "0x1FF60A0", Length = "0x8B")]
		[Token(Token = "0x6002FAB")]
		internal get { } //Length: 139
	}

	[Address(RVA = "0x1FF1120", Offset = "0x1FF0520", Length = "0xE")]
	[Token(Token = "0x6002FA5")]
	protected FileSystemInfo() { }

	[Address(RVA = "0x1FF0E10", Offset = "0x1FF0210", Length = "0x17F")]
	[Token(Token = "0x6002FAC")]
	protected FileSystemInfo(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x1FF68A0", Offset = "0x1FF5CA0", Length = "0x6A")]
	[Token(Token = "0x6002FA9")]
	private void EnsureDataInitialized() { }

	[Address(RVA = "0x1FF6AA0", Offset = "0x1FF5EA0", Length = "0x6D")]
	[Token(Token = "0x6002FA6")]
	public FileAttributes get_Attributes() { }

	[Address(RVA = "0x1FF6B90", Offset = "0x1FF5F90", Length = "0x81")]
	[Token(Token = "0x6002FB0")]
	public override bool get_Exists() { }

	[Address(RVA = "0x1FF6B10", Offset = "0x1FF5F10", Length = "0x7E")]
	[Token(Token = "0x6002FA7")]
	internal bool get_ExistsCore() { }

	[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
	[Token(Token = "0x6002FAE")]
	public override string get_FullName() { }

	[Address(RVA = "0x1FF6C20", Offset = "0x1FF6020", Length = "0x77")]
	[Token(Token = "0x6002FA8")]
	internal long get_LengthCore() { }

	[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
	[Token(Token = "0x6002FAF")]
	public override string get_Name() { }

	[Address(RVA = "0x1FF6CA0", Offset = "0x1FF60A0", Length = "0x8B")]
	[Token(Token = "0x6002FAB")]
	internal string get_NormalizedPath() { }

	[Address(RVA = "0x1FF6910", Offset = "0x1FF5D10", Length = "0x137")]
	[ComVisible(False)]
	[Token(Token = "0x6002FAD")]
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x1FF6A50", Offset = "0x1FF5E50", Length = "0x25")]
	[Token(Token = "0x6002FAA")]
	public void Refresh() { }

	[Address(RVA = "0x1FF6A80", Offset = "0x1FF5E80", Length = "0x1B")]
	[Token(Token = "0x6002FB1")]
	public virtual string ToString() { }

}

