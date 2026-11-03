namespace System.Buffers;

[Token(Token = "0x2000627")]
public abstract class ArrayPool
{
	[CompilerGenerated]
	[Token(Token = "0x40018B1")]
	private static readonly ArrayPool<T> <Shared>k__BackingField; //Field offset: 0x0

	[Token(Token = "0x1700073F")]
	public static ArrayPool<T> Shared
	{
		[Address(RVA = "0xB47F00", Offset = "0xB47300", Length = "0x99")]
		[CompilerGenerated]
		[Token(Token = "0x6002DD8")]
		 get { } //Length: 153
	}

	[Address(RVA = "0xB47060", Offset = "0xB46460", Length = "0xF6")]
	[Token(Token = "0x6002DDC")]
	private static ArrayPool`1() { }

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6002DDB")]
	protected ArrayPool`1() { }

	[Address(RVA = "0xB47F00", Offset = "0xB47300", Length = "0x99")]
	[CompilerGenerated]
	[Token(Token = "0x6002DD8")]
	public static ArrayPool<T> get_Shared() { }

	[Token(Token = "0x6002DD9")]
	public abstract T[] Rent(int minimumLength) { }

	[Token(Token = "0x6002DDA")]
	public abstract void Return(T[] array, bool clearArray = false) { }

}

