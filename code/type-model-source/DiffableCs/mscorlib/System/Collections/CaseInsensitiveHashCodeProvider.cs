namespace System.Collections;

[Obsolete("Please use StringComparer instead.")]
[Token(Token = "0x20005B3")]
public class CaseInsensitiveHashCodeProvider : IHashCodeProvider
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40017BC")]
	private readonly CompareInfo _compareInfo; //Field offset: 0x10

	[Token(Token = "0x17000633")]
	public static CaseInsensitiveHashCodeProvider Default
	{
		[Address(RVA = "0x1FC00D0", Offset = "0x1FBF4D0", Length = "0xAD")]
		[Token(Token = "0x6002995")]
		 get { } //Length: 173
	}

	[Address(RVA = "0x1FBFFA0", Offset = "0x1FBF3A0", Length = "0x81")]
	[Token(Token = "0x6002993")]
	public CaseInsensitiveHashCodeProvider() { }

	[Address(RVA = "0x1FC0030", Offset = "0x1FBF430", Length = "0x94")]
	[Token(Token = "0x6002994")]
	public CaseInsensitiveHashCodeProvider(CultureInfo culture) { }

	[Address(RVA = "0x1FC00D0", Offset = "0x1FBF4D0", Length = "0xAD")]
	[Token(Token = "0x6002995")]
	public static CaseInsensitiveHashCodeProvider get_Default() { }

	[Address(RVA = "0x1FBFEE0", Offset = "0x1FBF2E0", Length = "0xBE")]
	[Token(Token = "0x6002996")]
	public override int GetHashCode(object obj) { }

}

