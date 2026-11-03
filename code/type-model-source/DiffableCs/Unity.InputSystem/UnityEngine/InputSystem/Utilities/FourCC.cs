namespace UnityEngine.InputSystem.Utilities;

[Token(Token = "0x2000243")]
public struct FourCC : IEquatable<FourCC>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000C7A")]
	private int m_Code; //Field offset: 0x0

	[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
	[Token(Token = "0x6001519")]
	public FourCC(int code) { }

	[Address(RVA = "0x290FAF0", Offset = "0x290EEF0", Length = "0x2A")]
	[Token(Token = "0x600151A")]
	public FourCC(char a, char b =  , char c =  , char d =  ) { }

	[Address(RVA = "0x290F950", Offset = "0x290ED50", Length = "0x195")]
	[Token(Token = "0x600151B")]
	public FourCC(string str) { }

	[Address(RVA = "0x6041D0", Offset = "0x6035D0", Length = "0x6")]
	[Token(Token = "0x600151F")]
	public override bool Equals(FourCC other) { }

	[Address(RVA = "0x290F6B0", Offset = "0x290EAB0", Length = "0x7F")]
	[Token(Token = "0x6001520")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x604260", Offset = "0x603660", Length = "0x3")]
	[Token(Token = "0x6001524")]
	public static FourCC FromInt32(int i) { }

	[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
	[Token(Token = "0x6001521")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x604250", Offset = "0x603650", Length = "0x6")]
	[Token(Token = "0x6001522")]
	public static bool op_Equality(FourCC left, FourCC right) { }

	[Address(RVA = "0x604260", Offset = "0x603660", Length = "0x3")]
	[Token(Token = "0x600151C")]
	public static int op_Implicit(FourCC fourCC) { }

	[Address(RVA = "0x604260", Offset = "0x603660", Length = "0x3")]
	[Token(Token = "0x600151D")]
	public static FourCC op_Implicit(int i) { }

	[Address(RVA = "0x639780", Offset = "0x638B80", Length = "0x6")]
	[Token(Token = "0x6001523")]
	public static bool op_Inequality(FourCC left, FourCC right) { }

	[Address(RVA = "0x604260", Offset = "0x603660", Length = "0x3")]
	[Token(Token = "0x6001525")]
	public static int ToInt32(FourCC fourCC) { }

	[Address(RVA = "0x290F730", Offset = "0x290EB30", Length = "0x215")]
	[Token(Token = "0x600151E")]
	public virtual string ToString() { }

}

