namespace Mono;

[Token(Token = "0x200003C")]
internal struct MonoAssemblyName
{
	[CompilerGenerated]
	[Token(Token = "0x200003D")]
	[UnsafeValueType]
	internal struct <public_key_token>e__FixedBuffer
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000126")]
		public byte FixedElementField; //Field offset: 0x0

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000119")]
	internal IntPtr name; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400011A")]
	internal IntPtr culture; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400011B")]
	internal IntPtr hash_value; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400011C")]
	internal IntPtr public_key; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[FixedBuffer(typeof(byte), 17)]
	[Token(Token = "0x400011D")]
	internal <public_key_token>e__FixedBuffer public_key_token; //Field offset: 0x20
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x400011E")]
	internal uint hash_alg; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400011F")]
	internal uint hash_len; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4000120")]
	internal uint flags; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000121")]
	internal ushort major; //Field offset: 0x40
	[FieldOffset(Offset = "0x42")]
	[Token(Token = "0x4000122")]
	internal ushort minor; //Field offset: 0x42
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x4000123")]
	internal ushort build; //Field offset: 0x44
	[FieldOffset(Offset = "0x46")]
	[Token(Token = "0x4000124")]
	internal ushort revision; //Field offset: 0x46
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000125")]
	internal ushort arch; //Field offset: 0x48

}

