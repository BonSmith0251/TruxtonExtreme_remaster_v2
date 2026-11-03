namespace System.Runtime.Serialization.Formatters.Binary;

[Token(Token = "0x2000437")]
internal sealed class NameInfo
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400116B")]
	internal string NIFullName; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400116C")]
	internal long NIobjectId; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400116D")]
	internal long NIassemId; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400116E")]
	internal InternalPrimitiveTypeE NIprimitiveTypeEnum; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400116F")]
	internal Type NItype; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001170")]
	internal bool NIisSealed; //Field offset: 0x38
	[FieldOffset(Offset = "0x39")]
	[Token(Token = "0x4001171")]
	internal bool NIisArray; //Field offset: 0x39
	[FieldOffset(Offset = "0x3A")]
	[Token(Token = "0x4001172")]
	internal bool NIisArrayItem; //Field offset: 0x3A
	[FieldOffset(Offset = "0x3B")]
	[Token(Token = "0x4001173")]
	internal bool NItransmitTypeOnObject; //Field offset: 0x3B
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4001174")]
	internal bool NItransmitTypeOnMember; //Field offset: 0x3C
	[FieldOffset(Offset = "0x3D")]
	[Token(Token = "0x4001175")]
	internal bool NIisParentTypeOnObject; //Field offset: 0x3D
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001176")]
	internal InternalArrayTypeE NIarrayEnum; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x4001177")]
	private bool NIsealedStatusChecked; //Field offset: 0x44

	[Token(Token = "0x170003EB")]
	public bool IsSealed
	{
		[Address(RVA = "0x1F39580", Offset = "0x1F38980", Length = "0x35")]
		[Token(Token = "0x6001FFF")]
		 get { } //Length: 53
	}

	[Token(Token = "0x170003EC")]
	public string NIname
	{
		[Address(RVA = "0x1F395C0", Offset = "0x1F389C0", Length = "0x4B")]
		[Token(Token = "0x6002000")]
		 get { } //Length: 75
		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[Token(Token = "0x6002001")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6001FFD")]
	internal NameInfo() { }

	[Address(RVA = "0x1F39580", Offset = "0x1F38980", Length = "0x35")]
	[Token(Token = "0x6001FFF")]
	public bool get_IsSealed() { }

	[Address(RVA = "0x1F395C0", Offset = "0x1F389C0", Length = "0x4B")]
	[Token(Token = "0x6002000")]
	public string get_NIname() { }

	[Address(RVA = "0x1F39520", Offset = "0x1F38920", Length = "0x5A")]
	[Token(Token = "0x6001FFE")]
	internal void Init() { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[Token(Token = "0x6002001")]
	public void set_NIname(string value) { }

}

