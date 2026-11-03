namespace System.ComponentModel;

[DefaultMember("Item")]
[Token(Token = "0x2000149")]
public class ComponentCollection : ReadOnlyCollectionBase
{

	[Token(Token = "0x1700017F")]
	public override IComponent Item
	{
		[Address(RVA = "0x2642B90", Offset = "0x2641F90", Length = "0x25E")]
		[Token(Token = "0x6000824")]
		 get { } //Length: 606
	}

	[Address(RVA = "0x2642B90", Offset = "0x2641F90", Length = "0x25E")]
	[Token(Token = "0x6000824")]
	public override IComponent get_Item(string name) { }

}

