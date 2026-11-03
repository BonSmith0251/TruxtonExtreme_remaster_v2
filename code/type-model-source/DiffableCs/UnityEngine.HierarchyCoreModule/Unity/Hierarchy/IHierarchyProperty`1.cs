namespace Unity.Hierarchy;

[Token(Token = "0x2000014")]
public interface IHierarchyProperty
{

	[Token(Token = "0x600004D")]
	public T GetValue(in HierarchyNode node) { }

	[Token(Token = "0x600004E")]
	public void SetValue(in HierarchyNode node, T value) { }

}

