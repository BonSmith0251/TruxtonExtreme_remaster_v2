namespace UnityEngine;

[RequiredByNativeCode]
[Token(Token = "0x2000179")]
public class ResourceRequest : AsyncOperation
{
	[Token(Token = "0x200017A")]
	public static class BindingsMarshaller
	{

		[Address(RVA = "0x30582C0", Offset = "0x30576C0", Length = "0x80")]
		[Token(Token = "0x600122E")]
		public static ResourceRequest ConvertToManaged(IntPtr ptr) { }

	}

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000616")]
	internal string m_Path; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000617")]
	internal Type m_Type; //Field offset: 0x28

	[Token(Token = "0x170002C1")]
	public object asset
	{
		[Address(RVA = "0x22918F0", Offset = "0x2290CF0", Length = "0x14")]
		[Token(Token = "0x600122C")]
		 get { } //Length: 20
	}

	[Address(RVA = "0x3054B60", Offset = "0x3053F60", Length = "0x52")]
	[Token(Token = "0x600122D")]
	protected ResourceRequest(IntPtr ptr) { }

	[Address(RVA = "0x22918F0", Offset = "0x2290CF0", Length = "0x14")]
	[Token(Token = "0x600122C")]
	public object get_asset() { }

	[Address(RVA = "0x306FE10", Offset = "0x306F210", Length = "0x12")]
	[Token(Token = "0x600122B")]
	protected override object GetResult() { }

}

