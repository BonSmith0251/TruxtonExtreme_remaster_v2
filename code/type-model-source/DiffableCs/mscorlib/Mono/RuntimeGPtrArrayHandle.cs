namespace Mono;

[DefaultMember("Item")]
[Token(Token = "0x2000035")]
internal struct RuntimeGPtrArrayHandle
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400010C")]
	private GPtrArray* value; //Field offset: 0x0

	[Token(Token = "0x1700000C")]
	internal IntPtr Item
	{
		[Address(RVA = "0x1E64310", Offset = "0x1E63710", Length = "0x8")]
		[Token(Token = "0x6000060")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x1700000B")]
	internal int Length
	{
		[Address(RVA = "0x1E64320", Offset = "0x1E63720", Length = "0x19")]
		[Token(Token = "0x600005F")]
		internal get { } //Length: 25
	}

	[Address(RVA = "0x1E64150", Offset = "0x1E63550", Length = "0x1F")]
	[Token(Token = "0x600005E")]
	internal RuntimeGPtrArrayHandle(IntPtr ptr) { }

	[Address(RVA = "0x1E64260", Offset = "0x1E63660", Length = "0x1E")]
	[Token(Token = "0x6000063")]
	internal static void DestroyAndFree(ref RuntimeGPtrArrayHandle h) { }

	[Address(RVA = "0x1E64310", Offset = "0x1E63710", Length = "0x8")]
	[Token(Token = "0x6000060")]
	internal IntPtr get_Item(int i) { }

	[Address(RVA = "0x1E64320", Offset = "0x1E63720", Length = "0x19")]
	[Token(Token = "0x600005F")]
	internal int get_Length() { }

	[Address(RVA = "0x1E64280", Offset = "0x1E63680", Length = "0x5")]
	[Token(Token = "0x6000062")]
	private static void GPtrArrayFree(GPtrArray* value) { }

	[Address(RVA = "0x1E64290", Offset = "0x1E63690", Length = "0x70")]
	[Token(Token = "0x6000061")]
	internal IntPtr Lookup(int i) { }

}

